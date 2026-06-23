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

        //// Create the realtime client and connect with API-key auth (Authorization header).
        using var client = new AssemblyAIRealtimeClient();
        await client.ConnectAsync(apiKey, new StreamingConnectOptions
        {
            FormatTurns = true,
            AgentContext = "Thanks for calling Contoso support. What is your email address?",
            VoiceFocus = "near-field",
            SpeakerLabels = true,
            MaxSpeakers = 2,
        });

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

                //// After the session starts, send audio data.
                //// In a real application, you would stream microphone PCM16 audio:
                //// await client.SendAsync(new ArraySegment<byte>(audioBytes), WebSocketMessageType.Binary, true, cts.Token);

                //// Update configuration for turn detection sensitivity.
                await client.SendUpdateConfigurationAsync(new UpdateConfigurationPayload
                {
                    AgentContext = "Got it. Could you spell the account ID?",
                    Mode = UpdateConfigurationPayloadMode.Balanced,
                    MaxTurnSilence = 2000,
                });

                //// For this example, manually force an endpoint to get results.
                await client.SendForceEndpointAsync(new ForceEndpointPayload());
                break;
            }
        }

        //// Gracefully terminate the session.
        await client.SendSessionTerminationAsync(new SessionTerminationPayload());

        receivedSessionBegins.Should().BeTrue();
    }
}
