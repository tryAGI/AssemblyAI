# Transcribe Live

Connect to AssemblyAI's v3 realtime streaming API with Universal-3.6 Pro Realtime.

```csharp
using AssemblyAI.Realtime;

using var client = new AssemblyAIRealtimeClient();
using var cts = new CancellationTokenSource();

await client.ConnectAsync(apiKey, new StreamingConnectOptions
{
    SpeechModel = StreamingSpeechModel.Universal36ProRealtime,
    AgentContext = "Thanks for calling Contoso support. What is your email address?",
    SpeakerLabels = true,
    MaxSpeakers = 2,
});

await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
{
    if (serverEvent.IsBegin)
    {
        Console.WriteLine($"Session started: {serverEvent.Begin?.Id}");
        Console.WriteLine($"Model: {serverEvent.Begin?.Configuration?.Model}");
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

To change languages for the next turn without reconnecting, or clear steering and restore automatic code-switching:

```csharp
await client.SendUpdateConfigurationAsync(new UpdateConfigurationPayload
{
    LanguageCodes = [StreamingLanguageCode.English, StreamingLanguageCode.Russian],
});
await client.SendUpdateConfigurationAsync(new UpdateConfigurationPayload { LanguageCodes = [] });
```

Omitting `LanguageCodes` from an update preserves the current selection. Set `LanguageDetection = true` when connecting to receive `Turn.LanguageCode` and `Turn.LanguageConfidence`. Check `Begin.Configuration.Model` to confirm that the server selected the requested model.

Voice Focus is off by default. Enable `VoiceFocus = StreamingVoiceFocus.NearField` or `FarField` when competing speakers are a problem; ordinary background noise does not require it. `VoiceFocusThreshold` controls suppression strength.

Entity-aware endpointing is part of the model. Use `Mode`, `MinTurnSilence`, and `MaxTurnSilence` to tune turn timing, including through `UpdateConfigurationPayload`. The legacy `EndOfTurnConfidenceThreshold` option does not apply to Universal-3.6 Pro. Read `Turn.EndOfTurnConfidence` for the server's confidence signal and `Turn.EndOfTurn` for the final result. Replace the previous partial for a given `TurnOrder` rather than appending it. Final turns are always formatted; `FormatTurns` applies only to the older Universal Streaming models.

See AssemblyAI's [release announcement](https://www.assemblyai.com/blog/universal-3-6-pro-realtime), [multilingual guide](https://www.assemblyai.com/docs/streaming/multilingual-transcription), and [message reference](https://www.assemblyai.com/docs/streaming/message-sequence).

For voice-agent context carryover, send your agent's spoken reply after TTS starts or finishes:

```csharp
await client.SendUpdateConfigurationAsync(new UpdateConfigurationPayload
{
    AgentContext = "Got it. Could you spell the account ID?",
    Mode = UpdateConfigurationPayloadMode.Balanced,
});
```
