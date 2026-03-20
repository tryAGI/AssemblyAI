# AssemblyAI

[![Nuget package](https://img.shields.io/nuget/vpre/tryAGI.AssemblyAI)](https://www.nuget.org/packages/tryAGI.AssemblyAI/)
[![dotnet](https://github.com/tryAGI/AssemblyAI/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/AssemblyAI/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/AssemblyAI)](https://github.com/tryAGI/AssemblyAI/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

AssemblyAI has [an official .NET SDK](https://github.com/AssemblyAI/assemblyai-csharp-sdk) available, 
and we use this SDK primarily to improve the overall experience 
of our SDK/try to reach/exceed the level of the official one and 
extend it to all our generated SDKs for other platforms. 

## Features 🔥
- Fully generated C# SDK based on [official AssemblyAI OpenAPI specification](https://raw.githubusercontent.com/AssemblyAI/assemblyai-api-spec/main/openapi.yml) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Microsoft.Extensions.AI `ISpeechToTextClient` support

### Usage
```csharp
using AssemblyAI;

using var api = new AssemblyAIClient(apiKey);

var fileUrl = "https://github.com/AssemblyAI-Community/audio-examples/raw/main/20230607_me_canadian_wildfires.mp3";

//// You can also transcribe a local file by passing in a file path
// var filePath = "./path/to/file.mp3";
// var uploadedFile = await client.Transcript.UploadFileAsync();
// fileUrl = uploadedFile.UploadUrl;

Transcript transcript = await client.Transcript.CreateTranscriptAsync(TranscriptParams.FromUrl(
    fileUrl,
    new TranscriptOptionalParams
    {
        LanguageDetection = true,
        SpeakerLabels = true, // Identify speakers in your audios
        AutoHighlights = true, // Identifying highlights in your audio
    }));

transcript.EnsureStatusCompleted();

Console.WriteLine(transcript);
```

### Microsoft.Extensions.AI

The SDK implements [`ISpeechToTextClient`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ispeechtotextclient):
```csharp
using AssemblyAI;
using Microsoft.Extensions.AI;

ISpeechToTextClient speechClient = new AssemblyAIClient(apiKey);

await using var audioStream = File.OpenRead("recording.wav");
var response = await speechClient.GetTextAsync(audioStream);

Console.WriteLine(response.Text);
```

<!-- EXAMPLES:START -->
### Transcribe


```csharp
using var client = GetAuthenticatedApi();

var fileUrl = "https://github.com/AssemblyAI-Community/audio-examples/raw/main/20230607_me_canadian_wildfires.mp3";

// You can also transcribe a local file by passing in a file path
// var filePath = "./path/to/file.mp3";
// var uploadedFile = await client.Transcript.UploadFileAsync();
// fileUrl = uploadedFile.UploadUrl;

Transcript transcript = await client.Transcript.CreateTranscriptAsync(TranscriptParams.FromUrl(
    fileUrl,
    new TranscriptOptionalParams
    {
        SpeechModels = [],
        LanguageDetection = true,
        SpeakerLabels = true, // Identify speakers in your audios
        AutoHighlights = true, // Identifying highlights in your audio
    }));

transcript.EnsureStatusCompleted();

Console.WriteLine(transcript);

// If you want to summarize the transcript, you can use the Lemur API
// LemurTaskResponse response = await client.LeMUR.LemurTaskAsync(LemurTaskParams.FromPrompt(
//     prompt: "Provide a brief summary of the transcript.",
//     @params: new LemurBaseParams
//     {
//         TranscriptIds = [transcript.Id],
//         FinalModel = LemurModel.AnthropicClaude35Sonnet
//     }));
//
// Console.WriteLine(response.String?.Value1?.Response ?? "No response found.");
// Console.WriteLine($"Input tokens: {response.String?.Value2?.Usage.InputTokens}");
// Console.WriteLine($"Input tokens: {response.String?.Value2?.Usage.OutputTokens}");
```

### Transcribe Live


```csharp
using var client = GetAuthenticatedApi();

// - You need to have `sox` installed on your system. If not, run:
//   macOS: brew install sox (macOS)
//   Linux: sudo apt-get install sox libsox-fmt-all
//   Windows: manually download and install sox, and add sox to your PATH environment variable.
//            https://sourceforge.net/projects/sox/

// Set up the cancellation token, so we can stop the program with Ctrl+C
var cts = new CancellationTokenSource();
var ct = cts.Token;
Console.CancelKeyPress += (sender, e) => cts.Cancel();

// Set up the realtime transcriber
// await using var transcriber = new RealtimeTranscriber(new RealtimeTranscriberOptions
// {
//     SampleRate = 16_000
// });
//
// transcriber.PartialTranscriptReceived.Subscribe(transcript =>
// {
//     if (transcript.Text == "") return;
//     Console.WriteLine($"Partial transcript: {transcript.Text}");
// });
// transcriber.FinalTranscriptReceived.Subscribe(transcript =>
// {
//     Console.WriteLine($"Final transcript: {transcript.Text}");
// });

//await transcriber.ConnectAsync();

var soxArguments = string.Join(' ', [
    // --default-device doesn't work on Windows
    OperatingSystem.IsWindows() ? "-t waveaudio default" : "--default-device",
    "--no-show-progress",
    "--rate 16000",
    "--channels 1",
    "--encoding signed-integer",
    "--bits 16",
    "--type wav",
    "-" // pipe
]);
Console.WriteLine($"sox {soxArguments}");
using var soxProcess = new Process();
soxProcess.StartInfo = new ProcessStartInfo
{
    FileName = "sox",
    Arguments = soxArguments,
    RedirectStandardOutput = true,
    RedirectStandardError = true,
    UseShellExecute = false,
    CreateNoWindow = true
};

soxProcess.Start();
soxProcess.BeginErrorReadLine();
var soxOutputStream = soxProcess.StandardOutput.BaseStream;
var buffer = new Memory<byte>(new byte[4096]);
while (await soxOutputStream.ReadAsync(buffer, ct) > 0)
{
    if (ct.IsCancellationRequested) break;
    //await transcriber.SendAudioAsync(buffer);
}

soxProcess.Kill();
//await transcriber.CloseAsync();
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/AssemblyAI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/AssemblyAI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).