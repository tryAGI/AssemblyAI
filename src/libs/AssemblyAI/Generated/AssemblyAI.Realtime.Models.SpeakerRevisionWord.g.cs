
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// A word with corrected speaker attribution. Revisions preserve text and timestamps and contain no confidence or word_is_final fields.
    /// </summary>
    public sealed partial class SpeakerRevisionWord
    {
        /// <summary>
        /// The unchanged transcribed word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Unchanged start time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// Unchanged end time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// Corrected speaker assignment for this word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerRevisionWord" /> class.
        /// </summary>
        /// <param name="text">
        /// The unchanged transcribed word.
        /// </param>
        /// <param name="start">
        /// Unchanged start time in milliseconds.
        /// </param>
        /// <param name="end">
        /// Unchanged end time in milliseconds.
        /// </param>
        /// <param name="speaker">
        /// Corrected speaker assignment for this word.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerRevisionWord(
            string text,
            int start,
            int end,
            string speaker)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
            this.Speaker = speaker ?? throw new global::System.ArgumentNullException(nameof(speaker));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerRevisionWord" /> class.
        /// </summary>
        public SpeakerRevisionWord()
        {
        }

    }
}