
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A list of transcripts. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
    /// </summary>
    public sealed partial class TranscriptList
    {
        /// <summary>
        /// Details of the transcript page. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.PageDetails PageDetails { get; set; }

        /// <summary>
        /// An array of transcripts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcripts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptListItem> Transcripts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptList" /> class.
        /// </summary>
        /// <param name="pageDetails">
        /// Details of the transcript page. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
        /// </param>
        /// <param name="transcripts">
        /// An array of transcripts
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptList(
            global::AssemblyAI.PageDetails pageDetails,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptListItem> transcripts)
        {
            this.PageDetails = pageDetails ?? throw new global::System.ArgumentNullException(nameof(pageDetails));
            this.Transcripts = transcripts ?? throw new global::System.ArgumentNullException(nameof(transcripts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptList" /> class.
        /// </summary>
        public TranscriptList()
        {
        }
    }
}