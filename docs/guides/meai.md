# Microsoft.Extensions.AI Integration

The `tryAGI.AssemblyAI` SDK implements the `ISpeechToTextClient` interface from `Microsoft.Extensions.AI`, enabling you to use AssemblyAI transcription through a standardized .NET AI abstraction.

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

### Checking Transcription Status

AssemblyAI transcription is asynchronous. The SDK polls until completion:

```csharp
ISpeechToTextClient sttClient = client;

var response = await sttClient.GetTextAsync(
    new SpeechToTextOptions
    {
        AudioData = new DataContent(audioBytes, "audio/mpeg"),
    });

// Response is returned after polling completes
Console.WriteLine($"Status: completed");
Console.WriteLine($"Text: {response.Text}");
Console.WriteLine($"Confidence: {response.AdditionalProperties?["confidence"]}");
```

### Usage Information

Usage data is available on the response:

```csharp
var response = await sttClient.GetTextAsync(options);

Console.WriteLine($"Audio duration: {response.Usage?.InputTokenCount}");
Console.WriteLine($"Characters: {response.Usage?.OutputTokenCount}");
```
