using System.Text.Json;
using AssemblyAI.Realtime;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
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
}
