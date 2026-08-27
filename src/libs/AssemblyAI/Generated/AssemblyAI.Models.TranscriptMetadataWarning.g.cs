
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Warning
    /// </summary>
    public sealed partial class TranscriptMetadataWarning
    {
        /// <summary>
        /// A human-readable description of the warning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMetadataWarning" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable description of the warning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptMetadataWarning(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMetadataWarning" /> class.
        /// </summary>
        public TranscriptMetadataWarning()
        {
        }

    }
}