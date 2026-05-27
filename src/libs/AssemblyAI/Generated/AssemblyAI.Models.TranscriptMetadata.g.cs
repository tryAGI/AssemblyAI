
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Additional metadata about the transcription returned on the `Transcript` object under `metadata`. Only present when there is information to report — when all of its fields would be empty, the `metadata` object is omitted from the response entirely.
    /// </summary>
    public sealed partial class TranscriptMetadata
    {
        /// <summary>
        /// The domain-specific model that was applied to the transcription (for example, `"medical-v1"` when [Medical Mode](https://www.assemblyai.com/docs/pre-recorded-audio/medical-mode) was applied), or `null` if no domain-specific model was used. Always present when `metadata` is present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_used")]
        public string? DomainUsed { get; set; }

        /// <summary>
        /// Warning messages emitted while processing the request. Each warning is an object with a human-readable `message`. When there are no warnings to report, this field is omitted from the `metadata` object entirely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWarning>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMetadata" /> class.
        /// </summary>
        /// <param name="domainUsed">
        /// The domain-specific model that was applied to the transcription (for example, `"medical-v1"` when [Medical Mode](https://www.assemblyai.com/docs/pre-recorded-audio/medical-mode) was applied), or `null` if no domain-specific model was used. Always present when `metadata` is present.
        /// </param>
        /// <param name="warnings">
        /// Warning messages emitted while processing the request. Each warning is an object with a human-readable `message`. When there are no warnings to report, this field is omitted from the `metadata` object entirely.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptMetadata(
            string? domainUsed,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWarning>? warnings)
        {
            this.DomainUsed = domainUsed;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMetadata" /> class.
        /// </summary>
        public TranscriptMetadata()
        {
        }

    }
}