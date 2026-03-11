
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakerIdentificationResponseSpeakerIdentification
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
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerIdentificationResponseSpeakerIdentification" /> class.
        /// </summary>
        /// <param name="mapping">
        /// A mapping of the original generic speaker labels (e.g., "A", "B") to the identified speaker names or roles.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerIdentificationResponseSpeakerIdentification(
            global::System.Collections.Generic.Dictionary<string, string>? mapping,
            string? status)
        {
            this.Mapping = mapping;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerIdentificationResponseSpeakerIdentification" /> class.
        /// </summary>
        public SpeakerIdentificationResponseSpeakerIdentification()
        {
        }
    }
}