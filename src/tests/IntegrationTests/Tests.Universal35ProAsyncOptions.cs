using System.Text.Json;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Universal35ProAsyncOptions_SerializesFeatureSet()
    {
        var request = TranscriptParams.FromUrl(
            "https://assembly.ai/code-switching-3",
            new TranscriptOptionalParams
            {
                SpeechModels = [SpeechModel2.Universal35Pro],
                LanguageDetection = true,
                SpeakerLabels = true,
                Prompt = "This is a League of Legends pro interview.",
                KeytermsPrompt = ["Azir", "solo queue"],
            });

        using var json = JsonDocument.Parse(request.ToJson());
        var root = json.RootElement;

        root.GetProperty("audio_url").GetString().Should().Be("https://assembly.ai/code-switching-3");
        root.GetProperty("speech_models")[0].GetString().Should().Be("universal-3-5-pro");
        root.GetProperty("language_detection").GetBoolean().Should().BeTrue("language detection enables native code-switching routing");
        root.GetProperty("speaker_labels").GetBoolean().Should().BeTrue("speaker labels enable diarization");
        root.GetProperty("prompt").GetString().Should().Be("This is a League of Legends pro interview.");
        root.GetProperty("keyterms_prompt")[0].GetString().Should().Be("Azir");
        root.GetProperty("keyterms_prompt")[1].GetString().Should().Be("solo queue");
    }
}
