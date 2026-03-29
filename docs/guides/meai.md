# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The AssemblyAI SDK implements `ISpeechToTextClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `ISpeechToTextClient` | Full (file-based transcription) |

## ISpeechToTextClient

### Installation

```bash
dotnet add package tryAGI.AssemblyAI
```

### File-Based Transcription

Transcribe an audio file to text:

```csharp
using AssemblyAI;
using Microsoft.Extensions.AI;

using var client = new AssemblyAIClient(apiKey);
ISpeechToTextClient sttClient = client;

var audioBytes = await File.ReadAllBytesAsync("audio.mp3");

var response = await sttClient.GetTextAsync(
    new SpeechToTextOptions
    {
        AudioData = new DataContent(audioBytes, "audio/mpeg"),
    });

Console.WriteLine(response.Text);
```

### Transcription from URL

Transcribe audio from a remote URL:

```csharp
ISpeechToTextClient sttClient = client;

var response = await sttClient.GetTextAsync(
    new SpeechToTextOptions
    {
        AudioData = new DataContent(
            new Uri("https://example.com/audio.mp3")),
    });

Console.WriteLine(response.Text);
```

### Transcription with Language Hint

Specify a language code for more accurate transcription:

```csharp
ISpeechToTextClient sttClient = client;
var audioBytes = await File.ReadAllBytesAsync("spanish-audio.mp3");

var response = await sttClient.GetTextAsync(
    new SpeechToTextOptions
    {
        AudioData = new DataContent(audioBytes, "audio/mpeg"),
        AdditionalProperties = new AdditionalPropertiesDictionary
        {
            ["language_code"] = "es",
        },
    });

Console.WriteLine(response.Text);
```

### Advanced Configuration with RawRepresentationFactory

Use `RawRepresentationFactory` to access AssemblyAI-specific features like speaker diarization, sentiment analysis, entity detection, and auto chapters:

```csharp
ISpeechToTextClient sttClient = client;

var response = await sttClient.GetTextAsync(
    new MemoryStream(audioBytes),
    new SpeechToTextOptions
    {
        RawRepresentationFactory = _ => TranscriptParams.FromUrl(
            "https://example.com/meeting.mp3",
            new TranscriptOptionalParams
            {
                SpeakerLabels = true,
                SentimentAnalysis = true,
                EntityDetection = true,
                AutoChapters = true,
                SpeechModels = [],
            }),
    });

Console.WriteLine(response.Text);
```

### Accessing the Raw Response

The full AssemblyAI transcript is available via `RawRepresentation` for speaker labels, sentiment analysis, entities, chapters, and word-level timestamps:

```csharp
ISpeechToTextClient sttClient = client;

var response = await sttClient.GetTextAsync(
    new SpeechToTextOptions
    {
        AudioData = new DataContent(audioBytes, "audio/mpeg"),
    });

// Access the full AssemblyAI Transcript object
var raw = (Transcript)response.RawRepresentation!;
Console.WriteLine($"Confidence: {raw.Confidence}");
Console.WriteLine($"Audio Duration: {raw.AudioDuration}s");

// Access word-level timestamps
if (raw.Words is { Count: > 0 })
{
    foreach (var word in raw.Words)
    {
        Console.WriteLine($"  [{word.Start}ms - {word.End}ms] {word.Text} " +
            $"(confidence: {word.Confidence:P0}, speaker: {word.Speaker})");
    }
}

// Access utterances (when speaker_labels is enabled)
if (raw.Utterances is { Count: > 0 })
{
    foreach (var utterance in raw.Utterances)
    {
        Console.WriteLine($"  Speaker {utterance.Speaker}: {utterance.Text}");
    }
}
```

### Streaming Behavior

`GetStreamingTextAsync` delegates to the non-streaming `GetTextAsync` method internally. The batch transcription job (upload + submit + poll) runs to completion first, and then the full result is converted to `SpeechToTextResponseUpdate` events using `ToSpeechToTextResponseUpdates()`.

This means you will not receive incremental transcription updates as audio is processed. The entire transcript is returned at once after the job finishes. For most use cases, calling `GetTextAsync` directly is equivalent and simpler.

!!! note
    AssemblyAI does offer a real-time streaming WebSocket API via the `AssemblyAIRealtimeClient` (in the `AssemblyAI.Realtime` namespace), but it is not exposed through the MEAI `ISpeechToTextClient` interface. Use `AssemblyAIRealtimeClient` directly for real-time streaming needs.

### Usage Information

Usage data is available on the response:

```csharp
var response = await sttClient.GetTextAsync(options);

Console.WriteLine($"Audio duration: {response.Usage?.InputTokenCount}");
Console.WriteLine($"Characters: {response.Usage?.OutputTokenCount}");
```
