/*
order: 20
title: Transcribe Live
slug: transcribe-live

Connect to the AssemblyAI v3 real-time streaming API for live speech-to-text transcription.
*/

using AssemblyAI.Realtime;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    //// Stream audio to AssemblyAI for real-time transcription using the v3 WebSocket API.

    [TestMethod]
    [TestCategory("Explicit")]
    public async Task TranscribeLive()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ASSEMBLYAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ASSEMBLYAI_API_KEY environment variable is not found.");

        //// Create the realtime client and connect.
        using var client = new AssemblyAIRealtimeClient();
        await client.ConnectAsync(
            new Uri($"wss://streaming.assemblyai.com/v3/ws?api_key={apiKey}"));

        client.IsConnected.Should().BeTrue();

        //// Receive the session started event.
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        var receivedSessionBegins = false;

        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
        {
            if (serverEvent.IsBegin)
            {
                receivedSessionBegins = true;
                Console.WriteLine($"Session started: {serverEvent.Begin?.Id}");
                Console.WriteLine($"Expires at: {serverEvent.Begin?.ExpiresAt}");

                //// After session starts, send audio data.
                //// In a real application, you would stream microphone PCM16 audio:
                //// await client.SendAsync(audioBytes, WebSocketMessageType.Binary, true, cts.Token);

                //// Update configuration for turn detection sensitivity.
                await client.SendUpdateConfigurationAsync(new UpdateConfigurationPayload
                {
                    EndOfTurnConfidenceThreshold = 0.5,
                    MaxTurnSilence = 2000,
                });

                //// For this example, manually force an endpoint to get results.
                await client.SendForceEndpointAsync(new ForceEndpointPayload());
            }
            else if (serverEvent.IsTurn)
            {
                var turn = serverEvent.Turn!;
                Console.WriteLine($"Turn {turn.TurnOrder}: {turn.Transcript}");
                Console.WriteLine($"  End of turn: {turn.EndOfTurn}");
                Console.WriteLine($"  Confidence: {turn.EndOfTurnConfidence}");

                if (turn.EndOfTurn == true)
                {
                    break;
                }
            }
            else if (serverEvent.IsTermination)
            {
                var termination = serverEvent.Termination!;
                Console.WriteLine($"Session terminated. Audio: {termination.AudioDurationSeconds}s, Session: {termination.SessionDurationSeconds}s");
                break;
            }
        }

        //// Gracefully terminate the session.
        await client.SendSessionTerminationAsync(new SessionTerminationPayload());

        receivedSessionBegins.Should().BeTrue();
    }
}
