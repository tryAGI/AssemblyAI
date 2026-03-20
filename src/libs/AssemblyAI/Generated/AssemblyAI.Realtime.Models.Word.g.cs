
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Word-level transcription detail.
    /// </summary>
    public sealed partial class Word
    {
        /// <summary>
        /// The transcribed word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Start time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// End time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// Confidence score (0.0 to 1.0).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Whether the word is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_is_final")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WordIsFinal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Word" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcribed word.
        /// </param>
        /// <param name="start">
        /// Start time in milliseconds.
        /// </param>
        /// <param name="end">
        /// End time in milliseconds.
        /// </param>
        /// <param name="confidence">
        /// Confidence score (0.0 to 1.0).
        /// </param>
        /// <param name="wordIsFinal">
        /// Whether the word is finalized.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Word(
            string text,
            int start,
            int end,
            double confidence,
            bool wordIsFinal)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.WordIsFinal = wordIsFinal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Word" /> class.
        /// </summary>
        public Word()
        {
        }
    }
}