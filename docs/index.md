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

## Support

Priority place for bugs: https://github.com/tryAGI/AssemblyAI/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/AssemblyAI/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).