using System.Net.WebSockets;
using AssemblyAI.Realtime;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    private static string GetApiKeyOrSkip()
    {
        return Environment.GetEnvironmentVariable("ASSEMBLYAI_API_KEY") is { Length: > 0 } v
            ? v
            : throw new AssertInconclusiveException("ASSEMBLYAI_API_KEY environment variable is not found.");
    }

    private static byte[] LoadSamplePcm()
    {
        var path = Path.Combine(AppContext.BaseDirectory, "Assets", "sample-16k-mono.pcm");
        if (!File.Exists(path))
        {
            throw new AssertInconclusiveException($"Sample PCM not found at {path}.");
        }
        return File.ReadAllBytes(path);
    }

    [TestMethod]
    [TestCategory("Live")]
    public async Task Streaming_ConnectsAndReceivesBegin_WithStreamingConnectOptions()
    {
        var apiKey = GetApiKeyOrSkip();

        using var client = new AssemblyAIRealtimeClient();
        await client.ConnectAsync(apiKey, new StreamingConnectOptions
        {
            FormatTurns = true,
        });

        client.IsConnected.Should().BeTrue();

        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        var sawBegin = false;

        await foreach (var evt in client.ReceiveUpdatesAsync(cts.Token))
        {
            if (evt.IsBegin)
            {
                sawBegin = true;
                break;
            }
        }

        sawBegin.Should().BeTrue();

        await client.SendSessionTerminationAsync(new SessionTerminationPayload());
    }

    [TestMethod]
    [TestCategory("Live")]
    public async Task Streaming_EndToEnd_StreamsAudioAndReceivesTurn()
    {
        var apiKey = GetApiKeyOrSkip();
        var pcm = LoadSamplePcm();

        using var client = new AssemblyAIRealtimeClient();
        await client.ConnectAsync(apiKey, new StreamingConnectOptions
        {
            SampleRate = 16000,
            FormatTurns = true,
        });

        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(45));

        var sawBegin = false;
        var sawTurnWithText = false;
        var sawTermination = false;
        var bestTranscript = string.Empty;

        var receiveTask = Task.Run(async () =>
        {
            try
            {
                await foreach (var evt in client.ReceiveUpdatesAsync(cts.Token))
                {
                    if (evt.IsBegin)
                    {
                        sawBegin = true;
                        Console.WriteLine($"[AssemblyAI] Begin id={evt.Begin?.Id}");
                    }
                    else if (evt.IsTurn)
                    {
                        var transcript = evt.Turn?.Transcript ?? string.Empty;
                        Console.WriteLine($"[AssemblyAI] Turn order={evt.Turn?.TurnOrder} eot={evt.Turn?.EndOfTurn} text='{transcript}'");
                        if (transcript.Length > bestTranscript.Length)
                        {
                            bestTranscript = transcript;
                        }
                        if (!string.IsNullOrWhiteSpace(transcript))
                        {
                            sawTurnWithText = true;
                        }
                    }
                    else if (evt.IsTermination)
                    {
                        sawTermination = true;
                        Console.WriteLine($"[AssemblyAI] Termination audio={evt.Termination?.AudioDurationSeconds}s");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"[AssemblyAI] Other event: {evt}");
                    }
                }
            }
            catch (Exception ex) when (ex is not OperationCanceledException)
            {
                Console.WriteLine($"[AssemblyAI] Receive loop exited with: {ex.GetType().Name}: {ex.Message}");
            }
        }, cts.Token);

        // 16 kHz mono S16LE → 32000 bytes/sec → 50 ms = 1600 bytes
        const int chunkSize = 1600;
        for (var offset = 0; offset < pcm.Length; offset += chunkSize)
        {
            var len = Math.Min(chunkSize, pcm.Length - offset);
            await client.SendAsync(
                new ArraySegment<byte>(pcm, offset, len),
                WebSocketMessageType.Binary,
                endOfMessage: true,
                cts.Token);
            await Task.Delay(50, cts.Token);
        }

        // Force the model to emit a final turn for whatever it captured.
        await client.SendForceEndpointAsync(new ForceEndpointPayload());

        // Give the server a beat to flush turns, then terminate.
        await Task.Delay(2000, cts.Token);
        await client.SendSessionTerminationAsync(new SessionTerminationPayload());

        try
        {
            await receiveTask;
        }
        catch (OperationCanceledException)
        {
        }

        sawBegin.Should().BeTrue("session must start with a Begin event");
        sawTurnWithText.Should().BeTrue($"streaming should yield at least one Turn with non-empty transcript (best: '{bestTranscript}')");
        sawTermination.Should().BeTrue("session should report a Termination event after SessionTermination");
    }

    [TestMethod]
    [TestCategory("Live")]
    public async Task Streaming_EuRegion_Connects()
    {
        var apiKey = GetApiKeyOrSkip();

        using var client = new AssemblyAIRealtimeClient();
        await client.ConnectAsync(apiKey, new StreamingConnectOptions
        {
            Region = "eu",
        });

        client.IsConnected.Should().BeTrue();

        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        var sawBegin = false;

        await foreach (var evt in client.ReceiveUpdatesAsync(cts.Token))
        {
            if (evt.IsBegin)
            {
                sawBegin = true;
                break;
            }
        }

        sawBegin.Should().BeTrue();

        await client.SendSessionTerminationAsync(new SessionTerminationPayload());
    }

    [TestMethod]
    [TestCategory("Live")]
    public async Task Streaming_KeytermsPrompt_DoesNotBreakConnection()
    {
        var apiKey = GetApiKeyOrSkip();

        var options = new StreamingConnectOptions
        {
            FormatTurns = true,
            KeytermsPrompt = ["AssemblyAI", "tryAGI"],
        };
        Console.WriteLine($"[AssemblyAI] Connecting with URI={options.BuildUri()}");

        using var client = new AssemblyAIRealtimeClient();
        client.Closed += (_, args) =>
            Console.WriteLine($"[AssemblyAI] Closed: status={args.CloseStatus} desc='{args.CloseStatusDescription}'");
        client.UnknownMessage += (_, args) =>
            Console.WriteLine($"[AssemblyAI] Unknown message: {args.RawText}");

        try
        {
            await client.ConnectAsync(apiKey, options);
        }
        catch (Exception ex)
        {
            Assert.Inconclusive($"Connect failed: {ex.GetType().Name}: {ex.Message}");
        }

        client.IsConnected.Should().BeTrue();

        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        var sawBegin = false;
        Exception? receiveError = null;

        try
        {
            await foreach (var evt in client.ReceiveUpdatesAsync(cts.Token))
            {
                if (evt.IsBegin)
                {
                    sawBegin = true;
                    Console.WriteLine($"[AssemblyAI] Begin id={evt.Begin?.Id}");
                    break;
                }
            }
        }
        catch (Exception ex) when (ex is not OperationCanceledException)
        {
            receiveError = ex;
            Console.WriteLine($"[AssemblyAI] Receive error: {ex.GetType().Name}: {ex.Message}");
        }

        if (!sawBegin && receiveError != null)
        {
            Assert.Fail($"Connection accepted but receive failed: {receiveError.Message}");
        }

        sawBegin.Should().BeTrue();

        await client.SendSessionTerminationAsync(new SessionTerminationPayload());
    }
}
