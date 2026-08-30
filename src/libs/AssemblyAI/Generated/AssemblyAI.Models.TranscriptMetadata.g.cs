
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Additional information about the transcript, including any warnings raised while processing the request.
    /// </summary>
    public sealed partial class TranscriptMetadata
    {
        /// <summary>
        /// Warnings raised while processing the request, for example when [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) was skipped because the audio contained no speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptMetadataWarning>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMetadata" /> class.
        /// </summary>
        /// <param name="warnings">
        /// Warnings raised while processing the request, for example when [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) was skipped because the audio contained no speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptMetadata(
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptMetadataWarning>? warnings)
        {
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