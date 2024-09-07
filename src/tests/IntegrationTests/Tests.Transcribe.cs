namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Transcribe()
    {
        using var client = GetAuthenticatedApi();
        
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
    }
}
