
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizationRequestBodySummarization
    {
        /// <summary>
        /// Type of summary. Bullets returns short bullet point style summaries, paragraph is generally more verbose and detailed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SummarizationRequestBodySummarizationSummaryTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.SummarizationRequestBodySummarizationSummaryType SummaryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SummarizationRequestBodySummarizationEffortJsonConverter))]
        public global::AssemblyAI.SummarizationRequestBodySummarizationEffort? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationRequestBodySummarization" /> class.
        /// </summary>
        /// <param name="summaryType">
        /// Type of summary. Bullets returns short bullet point style summaries, paragraph is generally more verbose and detailed.
        /// </param>
        /// <param name="effort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizationRequestBodySummarization(
            global::AssemblyAI.SummarizationRequestBodySummarizationSummaryType summaryType,
            global::AssemblyAI.SummarizationRequestBodySummarizationEffort? effort)
        {
            this.SummaryType = summaryType;
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationRequestBodySummarization" /> class.
        /// </summary>
        public SummarizationRequestBodySummarization()
        {
        }

    }
}