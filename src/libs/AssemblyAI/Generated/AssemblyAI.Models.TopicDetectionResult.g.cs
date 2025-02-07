
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The result of the topic detection model
    /// </summary>
    public sealed partial class TopicDetectionResult
    {
        /// <summary>
        /// An array of detected topics in the text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResultLabel>? Labels { get; set; }

        /// <summary>
        /// The text in the transcript in which a detected topic occurs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Timestamp containing a start and end property in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::AssemblyAI.Timestamp? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionResult" /> class.
        /// </summary>
        /// <param name="labels">
        /// An array of detected topics in the text
        /// </param>
        /// <param name="text">
        /// The text in the transcript in which a detected topic occurs
        /// </param>
        /// <param name="timestamp">
        /// Timestamp containing a start and end property in milliseconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicDetectionResult(
            string text,
            global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResultLabel>? labels,
            global::AssemblyAI.Timestamp? timestamp)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Labels = labels;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionResult" /> class.
        /// </summary>
        public TopicDetectionResult()
        {
        }
    }
}