
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Paragraph<br/>
    /// Example: {"text":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts throughout the US. Skylines from Maine to Maryland to Minnesota are gray and smoggy. And in some places, the air quality warnings include the warning to stay inside. We wanted to better understand what\u0027s happening here and why, so we called Peter Decarlo, an associate professor in the Department of Environmental Health and Engineering at Johns Hopkins University. Good morning, professor.","start":250,"end":26950,"confidence":0.73033,"words":[{"text":"Smoke","start":250,"end":650,"confidence":0.73033,"speaker":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},{"text":"from","start":730,"end":1022,"confidence":1,"speaker":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},{"text":"hundreds","start":1076,"end":1466,"confidence":0.99992,"speaker":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},{"text":"of","start":1498,"end":1646,"confidence":1,"speaker":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}]}
    /// </summary>
    public sealed partial class TranscriptParagraph
    {
        /// <summary>
        /// The transcript of the paragraph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, of the paragraph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The ending time, in milliseconds, of the paragraph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The confidence score for the transcript of this paragraph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

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
        /// <param name="text">
        /// The transcript of the paragraph
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, of the paragraph
        /// </param>
        /// <param name="end">
        /// The ending time, in milliseconds, of the paragraph
        /// </param>
        /// <param name="confidence">
        /// The confidence score for the transcript of this paragraph
        /// </param>
        /// <param name="words">
        /// An array of words in the paragraph
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptParagraph(
            string text,
            int start,
            int end,
            double confidence,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord> words)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
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