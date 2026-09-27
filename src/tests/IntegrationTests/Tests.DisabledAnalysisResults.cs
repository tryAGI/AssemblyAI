using System.Text.Json;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Transcript_DeserializesEmptyDisabledAnalysisResults()
    {
        var transcript = JsonSerializer.Deserialize(
            """
            {
              "id": "00000000-0000-0000-0000-000000000001",
              "audio_url": "https://example.invalid/audio.wav",
              "auto_highlights": false,
              "redact_pii": false,
              "status": "processing",
              "summarization": false,
              "webhook_auth": false,
              "acoustic_model": "assemblyai_default",
              "language_model": "assemblyai_default",
              "content_safety_labels": {},
              "iab_categories_result": {}
            }
            """,
            SourceGenerationContext.Default.Transcript);

        transcript.Should().NotBeNull();
        transcript!.ContentSafetyLabels.Should().NotBeNull();
        transcript.IabCategoriesResult.Should().NotBeNull();
    }
}
