
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A warning message emitted while processing a transcription request. Warnings are surfaced on the transcript response under `metadata.warnings`.
    /// </summary>
    public sealed partial class TranscriptWarning
    {
        /// <summary>
        /// A human-readable description of the warning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptWarning" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable description of the warning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptWarning(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptWarning" /> class.
        /// </summary>
        public TranscriptWarning()
        {
        }

    }
}