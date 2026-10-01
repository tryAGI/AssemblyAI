# Transcribe Live

Connect to AssemblyAI's v3 realtime streaming API with Universal-3.6 Pro Realtime.

```csharp
using AssemblyAI.Realtime;

using var client = new AssemblyAIRealtimeClient();
using var cts = new CancellationTokenSource();

await client.ConnectAsync(apiKey, new StreamingConnectOptions
{
    SpeechModel = StreamingSpeechModel.Universal36ProRealtime,
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

New connections use Universal-3.6 Pro Realtime by default. To upgrade an integration that pins a model, set `SpeechModel` to `StreamingSpeechModel.Universal36ProRealtime` or `"universal-3-6-pro"`. Universal-3.5 Pro remains selectable through `StreamingSpeechModel.Universal35ProRealtime` (`"universal-3-5-pro"`).

Universal-3.6 Pro can transcribe all 32 supported languages automatically and switch languages within a turn. To steer it toward languages your application expects, pass `LanguageCodes`:

```csharp
var options = new StreamingConnectOptions
{
    LanguageCodes = [StreamingLanguageCode.English, StreamingLanguageCode.Russian],
};
```

`LanguageCode` remains a shorthand for a single language. The SDK sends either option as the API's JSON-array `language_codes` query parameter. For AAC streams, set `Encoding = "aac"` and send ADTS-framed bytes; for raw Opus, set `Encoding = "opus"` and send one packet per WebSocket message. Ogg Opus streams use `Encoding = "ogg_opus"`. The server derives sample rate from these encoded streams.

For voice-agent context carryover, send your agent's spoken reply after TTS starts or finishes:

```csharp
await client.SendUpdateConfigurationAsync(new UpdateConfigurationPayload
{
    AgentContext = "Got it. Could you spell the account ID?",
    Mode = UpdateConfigurationPayloadMode.Balanced,
});
```
