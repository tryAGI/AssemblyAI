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

        //// You can also transcribe a local file by uploading bytes first:
        //// var apiKey = Environment.GetEnvironmentVariable("ASSEMBLYAI_API_KEY")!;
        //// var uploaded = await client.Files.UploadAsync(apiKey, await File.ReadAllBytesAsync("./path/to/file.mp3"));
        //// fileUrl = uploaded.UploadUrl!;

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

        //// Submit returns immediately; poll Transcripts.GetAsync until the status is Completed (or Error).
        var transcript = await PollUntilTerminalAsync(client, queued.Id);

        transcript.EnsureStatusCompleted();
        transcript.Text.Should().NotBeNullOrWhiteSpace();
    }

    private static async Task<Transcript> PollUntilTerminalAsync(
        AssemblyAIClient client,
        Guid id,
        TimeSpan? timeout = null,
        CancellationToken cancellationToken = default)
    {
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        cts.CancelAfter(timeout ?? TimeSpan.FromMinutes(5));

        while (true)
        {
            cts.Token.ThrowIfCancellationRequested();
            var t = await client.Transcripts.GetAsync(
                id.ToString(),
                cancellationToken: cts.Token);
            if (t.Status is TranscriptStatus.Completed or TranscriptStatus.Error)
            {
                return t;
            }
            await Task.Delay(TimeSpan.FromSeconds(2), cts.Token);
        }
    }
}
