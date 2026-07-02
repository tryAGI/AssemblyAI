
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        public global::AssemblyAI.SummarizationResponseSummarization? Summarization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationResponse" /> class.
        /// </summary>
        /// <param name="summarization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizationResponse(
            global::AssemblyAI.SummarizationResponseSummarization? summarization)
        {
            this.Summarization = summarization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationResponse" /> class.
        /// </summary>
        public SummarizationResponse()
        {
        }

    }
}