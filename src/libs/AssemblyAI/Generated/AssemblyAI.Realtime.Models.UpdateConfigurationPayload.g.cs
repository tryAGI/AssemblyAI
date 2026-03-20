
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConfigurationPayload(
            global::AssemblyAI.Realtime.UpdateConfigurationPayloadType type,
            double? endOfTurnConfidenceThreshold,
            int? minTurnSilence,
            int? maxTurnSilence)
        {
            this.Type = type;
            this.EndOfTurnConfidenceThreshold = endOfTurnConfidenceThreshold;
            this.MinTurnSilence = minTurnSilence;
            this.MaxTurnSilence = maxTurnSilence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigurationPayload" /> class.
        /// </summary>
        public UpdateConfigurationPayload()
        {
        }
    }
}