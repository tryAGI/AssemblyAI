using System.Text.Json;
using AssemblyAI.Realtime;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void RealtimePayloads_PreserveExistingConstructors()
    {
        var begin = new SessionBeginsPayload("session", DateTimeOffset.UnixEpoch, SessionBeginsPayloadType.Begin);
        begin.Id.Should().Be("session");
        begin.Configuration.Should().BeNull();

        var update = new UpdateConfigurationPayload(
            UpdateConfigurationPayloadType.UpdateConfiguration, null, 512, 2560, null, null,
            UpdateConfigurationPayloadMode.MaxAccuracy, null, "Your account number?", ["Contoso"], true);
        update.MaxTurnSilence.Should().Be(2560);
        update.AgentContext.Should().Be("Your account number?");
        update.ContinuousPartials.Should().BeTrue();
        update.LanguageCodes.Should().BeNull();
    }

    [TestMethod]
    public void ServerEvent_ConfirmsUniversal36SessionConfiguration()
    {
        var serverEvent = JsonSerializer.Deserialize(
            """
            {
              "type": "Begin",
              "id": "session-36",
              "expires_at": 1772570132,
              "configuration": {
                "model": "universal-3-6-pro",
                "mode": "balanced",
                "api_version": "2025-05-12",
                "speaker_labels": false,
                "redact_pii": false,
                "filter_profanity": false,
                "domain": null,
                "voice_focus": null
              }
            }
            """,
            RealtimeSourceGenerationContext.Default.ServerEvent2);

        serverEvent.IsBegin.Should().BeTrue();
        serverEvent.Begin!.Configuration!.Model.Should().Be("universal-3-6-pro");
        serverEvent.Begin.Configuration.Mode.Should().Be("balanced");
        serverEvent.Begin.Configuration.ApiVersion.Should().Be("2025-05-12");
        serverEvent.Begin.Configuration.SpeakerLabels.Should().BeFalse();
        serverEvent.Begin.Configuration.VoiceFocus.Should().BeNull();
    }

    [TestMethod]
    public void ServerEvent_AcceptsBeginWithoutConfiguration()
    {
        var serverEvent = JsonSerializer.Deserialize(
            """{"type":"Begin","id":"legacy-session","expires_at":1772570132}""",
            RealtimeSourceGenerationContext.Default.ServerEvent2);

        serverEvent.IsBegin.Should().BeTrue();
        serverEvent.Begin!.Configuration.Should().BeNull();
    }

    [TestMethod]
    public void UpdateConfiguration_SendsAndClearsLanguageSteering()
    {
        var update = new UpdateConfigurationPayload
        {
            LanguageCodes = [StreamingLanguageCode.English, StreamingLanguageCode.Russian],
        };

        using var steered = JsonDocument.Parse(update.ToJson());
        steered.RootElement.GetProperty("type").GetString().Should().Be("UpdateConfiguration");
        steered.RootElement.GetProperty("language_codes").EnumerateArray()
            .Select(code => code.GetString()).Should().Equal("en", "ru");
        steered.RootElement.TryGetProperty("mode", out _).Should().BeFalse();

        update.LanguageCodes = [];
        using var cleared = JsonDocument.Parse(update.ToJson());
        cleared.RootElement.GetProperty("language_codes").GetArrayLength().Should().Be(0);

        update.LanguageCodes = null;
        using var unchanged = JsonDocument.Parse(update.ToJson());
        unchanged.RootElement.TryGetProperty("language_codes", out _).Should().BeFalse();
    }

    [TestMethod]
    public void ServerEvent_DeserializesSpeechStarted()
    {
        var serverEvent = JsonSerializer.Deserialize(
            """
            {
              "type": "SpeechStarted",
              "timestamp": 123,
              "confidence": 0.91
            }
            """,
            RealtimeSourceGenerationContext.Default.ServerEvent2);

        serverEvent.IsSpeechStarted.Should().BeTrue();
        serverEvent.SpeechStarted.Should().NotBeNull();
        serverEvent.SpeechStarted!.Timestamp.Should().Be(123);
        serverEvent.SpeechStarted.Confidence.Should().BeApproximately(0.91, 0.0001);
    }

    [TestMethod]
    public void ServerEvent_DeserializesSpeakerRevision()
    {
        var serverEvent = JsonSerializer.Deserialize(
            """
            {
              "type": "SpeakerRevision",
              "revisions": [
                {
                  "turn_order": 3,
                  "speaker_label": "B",
                  "words": [
                    {
                      "text": "Hello",
                      "start": 1200,
                      "end": 1450,
                      "confidence": 0.98,
                      "word_is_final": true,
                      "speaker": "B"
                    }
                  ]
                }
              ]
            }
            """,
            RealtimeSourceGenerationContext.Default.ServerEvent2);

        serverEvent.IsSpeakerRevision.Should().BeTrue();
        serverEvent.SpeakerRevision.Should().NotBeNull();
        serverEvent.SpeakerRevision!.Revisions.Should().ContainSingle();

        var revision = serverEvent.SpeakerRevision.Revisions[0];
        revision.TurnOrder.Should().Be(3);
        revision.SpeakerLabel.Should().Be("B");
        revision.Words.Should().ContainSingle();
        revision.Words[0].Text.Should().Be("Hello");
        revision.Words[0].Speaker.Should().Be("B");
    }

    [TestMethod]
    [DataRow(false, 0.25)]
    [DataRow(true, 0.96)]
    public void ServerEvent_DeserializesUniversal36TurnMetadata(bool isFinal, double confidence)
    {
        var serverEvent = JsonSerializer.Deserialize(
            $$"""
            {
              "type": "Turn",
              "turn_order": 0,
              "turn_is_formatted": {{(isFinal ? "true" : "false")}},
              "end_of_turn": {{(isFinal ? "true" : "false")}},
              "transcript": "Нет.",
              "utterance": "Нет.",
              "language_code": "ru",
              "language_confidence": 0.98,
              "end_of_turn_confidence": {{confidence.ToString(System.Globalization.CultureInfo.InvariantCulture)}},
              "words": [{"text":"Нет.","start":0,"end":300,"confidence":0.99,"word_is_final":{{(isFinal ? "true" : "false")}}}]
            }
            """,
            RealtimeSourceGenerationContext.Default.ServerEvent2);

        serverEvent.IsTurn.Should().BeTrue();
        serverEvent.Turn!.Transcript.Should().Be("Нет.");
        serverEvent.Turn.LanguageCode.Should().Be("ru");
        serverEvent.Turn.LanguageConfidence.Should().Be(0.98);
        serverEvent.Turn.EndOfTurnConfidence.Should().Be(confidence);
        serverEvent.Turn.EndOfTurn.Should().Be(isFinal);
        serverEvent.Turn.Words.Should().ContainSingle();
        serverEvent.Turn.Words[0].WordIsFinal.Should().Be(isFinal);
    }
}
