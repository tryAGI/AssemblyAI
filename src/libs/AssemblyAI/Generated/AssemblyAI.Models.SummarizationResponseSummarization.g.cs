
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizationResponseSummarization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        public global::AssemblyAI.SummarizationResponseSummarizationSummarization? Summarization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationResponseSummarization" /> class.
        /// </summary>
        /// <param name="summarization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizationResponseSummarization(
            global::AssemblyAI.SummarizationResponseSummarizationSummarization? summarization)
        {
            this.Summarization = summarization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationResponseSummarization" /> class.
        /// </summary>
        public SummarizationResponseSummarization()
        {
        }

    }
}