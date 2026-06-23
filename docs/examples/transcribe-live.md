# Transcribe Live

Connect to AssemblyAI's v3 realtime streaming API with Universal-3.5 Pro Realtime.

```csharp
using AssemblyAI.Realtime;

using var client = new AssemblyAIRealtimeClient();
using var cts = new CancellationTokenSource();

await client.ConnectAsync(apiKey, new StreamingConnectOptions
{
    SpeechModel = StreamingSpeechModel.Universal35ProRealtime,
    FormatTurns = true,
    AgentContext = "Thanks for calling Contoso support. What is your email address?",
    VoiceFocus = StreamingVoiceFocus.NearField,
    SpeakerLabels = true,
    MaxSpeakers = 2,
});

await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
{
    if (serverEvent.IsBegin)
    {
        Console.WriteLine($"Session started: {serverEvent.Begin?.Id}");
    }
    else if (serverEvent.IsTurn)
    {
        Console.WriteLine(serverEvent.Turn?.Transcript);
    }
    else if (serverEvent.IsSpeakerRevision)
    {
        foreach (var revision in serverEvent.SpeakerRevision!.Revisions)
        {
            Console.WriteLine($"Speaker revision for turn {revision.TurnOrder}: {revision.SpeakerLabel}");
        }
    }
}
```

To upgrade an existing realtime integration that pins models, set `SpeechModel` to `StreamingSpeechModel.Universal35ProRealtime` or the raw value `"u3-rt-pro"`.

For voice-agent context carryover, send your agent's spoken reply after TTS starts or finishes:

```csharp
await client.SendUpdateConfigurationAsync(new UpdateConfigurationPayload
{
    AgentContext = "Got it. Could you spell the account ID?",
    Mode = UpdateConfigurationPayloadMode.Balanced,
});
```
