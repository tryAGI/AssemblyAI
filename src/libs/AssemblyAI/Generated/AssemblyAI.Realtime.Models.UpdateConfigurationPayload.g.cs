
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Update streaming configuration parameters during an active session.
    /// </summary>
    public sealed partial class UpdateConfigurationPayload
    {
        /// <summary>
        /// Message type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.UpdateConfigurationPayloadTypeJsonConverter))]
        public global::AssemblyAI.Realtime.UpdateConfigurationPayloadType Type { get; set; }

        /// <summary>
        /// Confidence threshold (0-1) for detecting end of turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_of_turn_confidence_threshold")]
        public double? EndOfTurnConfidenceThreshold { get; set; }

        /// <summary>
        /// Minimum silence duration in ms when confident about end of turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_turn_silence")]
        public int? MinTurnSilence { get; set; }

        /// <summary>
        /// Maximum silence in ms before end of turn is triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turn_silence")]
        public int? MaxTurnSilence { get; set; }

        /// <summary>
        /// How soon the first partial is emitted, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_delay")]
        public int? InterruptionDelay { get; set; }

        /// <summary>
        /// Confidence threshold (0.0 to 1.0) for classifying audio frames as speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vad_threshold")]
        public double? VadThreshold { get; set; }

        /// <summary>
        /// Latency and accuracy preset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.UpdateConfigurationPayloadModeJsonConverter))]
        public global::AssemblyAI.Realtime.UpdateConfigurationPayloadMode? Mode { get; set; }

        /// <summary>
        /// Contextual prompt describing the audio domain, scenario, or conversation details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Your voice agent's most recent spoken reply. Used as context for the next user turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_context")]
        public string? AgentContext { get; set; }

        /// <summary>
        /// Words and phrases to improve recognition accuracy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms_prompt")]
        public global::System.Collections.Generic.IList<string>? KeytermsPrompt { get; set; }

        /// <summary>
        /// Whether to emit additional partial transcripts during long turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuous_partials")]
        public bool? ContinuousPartials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigurationPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier.
        /// </param>
        /// <param name="endOfTurnConfidenceThreshold">
        /// Confidence threshold (0-1) for detecting end of turn.
        /// </param>
        /// <param name="minTurnSilence">
        /// Minimum silence duration in ms when confident about end of turn.
        /// </param>
        /// <param name="maxTurnSilence">
        /// Maximum silence in ms before end of turn is triggered.
        /// </param>
        /// <param name="interruptionDelay">
        /// How soon the first partial is emitted, in milliseconds.
        /// </param>
        /// <param name="vadThreshold">
        /// Confidence threshold (0.0 to 1.0) for classifying audio frames as speech.
        /// </param>
        /// <param name="mode">
        /// Latency and accuracy preset.
        /// </param>
        /// <param name="prompt">
        /// Contextual prompt describing the audio domain, scenario, or conversation details.
        /// </param>
        /// <param name="agentContext">
        /// Your voice agent's most recent spoken reply. Used as context for the next user turn.
        /// </param>
        /// <param name="keytermsPrompt">
        /// Words and phrases to improve recognition accuracy.
        /// </param>
        /// <param name="continuousPartials">
        /// Whether to emit additional partial transcripts during long turns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConfigurationPayload(
            global::AssemblyAI.Realtime.UpdateConfigurationPayloadType type,
            double? endOfTurnConfidenceThreshold,
            int? minTurnSilence,
            int? maxTurnSilence,
            int? interruptionDelay,
            double? vadThreshold,
            global::AssemblyAI.Realtime.UpdateConfigurationPayloadMode? mode,
            string? prompt,
            string? agentContext,
            global::System.Collections.Generic.IList<string>? keytermsPrompt,
            bool? continuousPartials)
        {
            this.Type = type;
            this.EndOfTurnConfidenceThreshold = endOfTurnConfidenceThreshold;
            this.MinTurnSilence = minTurnSilence;
            this.MaxTurnSilence = maxTurnSilence;
            this.InterruptionDelay = interruptionDelay;
            this.VadThreshold = vadThreshold;
            this.Mode = mode;
            this.Prompt = prompt;
            this.AgentContext = agentContext;
            this.KeytermsPrompt = keytermsPrompt;
            this.ContinuousPartials = continuousPartials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigurationPayload" /> class.
        /// </summary>
        public UpdateConfigurationPayload()
        {
        }

    }
}