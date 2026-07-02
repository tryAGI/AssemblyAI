
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizationResponseSummarizationSummarization
    {
        /// <summary>
        /// Array of summaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationResponseSummarizationSummarization" /> class.
        /// </summary>
        /// <param name="summary">
        /// Array of summaries.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizationResponseSummarizationSummarization(
            global::System.Collections.Generic.IList<object> summary,
            string status)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationResponseSummarizationSummarization" /> class.
        /// </summary>
        public SummarizationResponseSummarizationSummarization()
        {
        }

    }
}