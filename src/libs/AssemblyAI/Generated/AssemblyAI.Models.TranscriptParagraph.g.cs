
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptParagraph
    {
        /// <summary>
        /// The confidence score for the transcript of this paragraph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The ending time, in milliseconds, of the paragraph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, of the paragraph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The transcript of the paragraph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// An array of words in the paragraph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptParagraph" /> class.
        /// </summary>
        /// <param name="confidence">
        /// The confidence score for the transcript of this paragraph
        /// </param>
        /// <param name="end">
        /// The ending time, in milliseconds, of the paragraph
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, of the paragraph
        /// </param>
        /// <param name="text">
        /// The transcript of the paragraph
        /// </param>
        /// <param name="words">
        /// An array of words in the paragraph
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptParagraph(
            double confidence,
            int end,
            int start,
            string text,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord> words)
        {
            this.Confidence = confidence;
            this.End = end;
            this.Start = start;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptParagraph" /> class.
        /// </summary>
        public TranscriptParagraph()
        {
        }
    }
}