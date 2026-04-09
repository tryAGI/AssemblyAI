
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponseSpeakerIdentification
    {
        /// <summary>
        /// A mapping of the original generic speaker labels (e.g., "A", "B") to the identified speaker names or roles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? Mapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponseSpeakerIdentification" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="mapping">
        /// A mapping of the original generic speaker labels (e.g., "A", "B") to the identified speaker names or roles.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponseSpeakerIdentification(
            string status,
            global::System.Collections.Generic.Dictionary<string, string>? mapping)
        {
            this.Mapping = mapping;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponseSpeakerIdentification" /> class.
        /// </summary>
        public LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponseSpeakerIdentification()
        {
        }
    }
}