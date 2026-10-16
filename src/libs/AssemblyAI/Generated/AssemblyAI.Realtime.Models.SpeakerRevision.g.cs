
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Corrected speaker labels for a single turn.
    /// </summary>
    public sealed partial class SpeakerRevision
    {
        /// <summary>
        /// Order of the revised turn in the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TurnOrder { get; set; }

        /// <summary>
        /// Corrected dominant speaker label for the turn, or null when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_label")]
        public string? SpeakerLabel { get; set; }

        /// <summary>
        /// Revised word-level speaker attribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.Realtime.SpeakerRevisionWord> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerRevision" /> class.
        /// </summary>
        /// <param name="turnOrder">
        /// Order of the revised turn in the conversation.
        /// </param>
        /// <param name="words">
        /// Revised word-level speaker attribution.
        /// </param>
        /// <param name="speakerLabel">
        /// Corrected dominant speaker label for the turn, or null when unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerRevision(
            int turnOrder,
            global::System.Collections.Generic.IList<global::AssemblyAI.Realtime.SpeakerRevisionWord> words,
            string? speakerLabel)
        {
            this.TurnOrder = turnOrder;
            this.SpeakerLabel = speakerLabel;
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerRevision" /> class.
        /// </summary>
        public SpeakerRevision()
        {
        }

    }
}