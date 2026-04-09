/*
order: 10
title: Transcribe
slug: transcribe
*/

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
        // var uploadedFile = await client.Files.UploadAsync(await File.ReadAllBytesAsync(filePath));
        // fileUrl = uploadedFile.UploadUrl;

        Transcript transcript = await client.Transcripts.SubmitAsync(new TranscriptParams
        {
            AudioUrl = fileUrl,
            SpeechModels = [],
            LanguageDetection = true,
            SpeakerLabels = true, // Identify speakers in your audios
            AutoHighlights = true, // Identifying highlights in your audio
        });

        transcript.EnsureStatusCompleted();
        
        Console.WriteLine(transcript);
    }
}
