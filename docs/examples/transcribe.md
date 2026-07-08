# Transcribe



This example assumes `using AssemblyAI;` is in scope and `apiKey` contains your AssemblyAI API key.

```csharp
using var client = GetAuthenticatedApi();

var fileUrl = "https://github.com/AssemblyAI-Community/audio-examples/raw/main/20230607_me_canadian_wildfires.mp3";

// You can also transcribe a local file by uploading bytes first:
// var uploaded = await client.Files.UploadAsync(await File.ReadAllBytesAsync("./path/to/file.mp3"));
// fileUrl = uploaded.UploadUrl!;

var queued = await client.Transcripts.SubmitAsync(
    TranscriptParams.FromUrl(
        fileUrl,
        new TranscriptOptionalParams
        {
            SpeechModels = [SpeechModel2.Universal35Pro],
            LanguageDetection = true,
            SpeakerLabels = true,
            AutoHighlights = true,
        }));

var transcript = await PollUntilTerminalAsync(client, queued.Id);

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
