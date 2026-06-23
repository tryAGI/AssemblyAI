
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Server event indicating speech has been detected.
    /// </summary>
    public sealed partial class SpeechStartedPayload
    {
        /// <summary>
        /// Message type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.SpeechStartedPayloadTypeJsonConverter))]
        public global::AssemblyAI.Realtime.SpeechStartedPayloadType Type { get; set; }

        /// <summary>
        /// Audio timestamp in milliseconds where speech was detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Timestamp { get; set; }

        /// <summary>
        /// Speech detection confidence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStartedPayload" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Audio timestamp in milliseconds where speech was detected.
        /// </param>
        /// <param name="confidence">
        /// Speech detection confidence.
        /// </param>
        /// <param name="type">
        /// Message type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechStartedPayload(
            int timestamp,
            double confidence,
            global::AssemblyAI.Realtime.SpeechStartedPayloadType type)
        {
            this.Type = type;
            this.Timestamp = timestamp;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStartedPayload" /> class.
        /// </summary>
        public SpeechStartedPayload()
        {
        }

    }
}