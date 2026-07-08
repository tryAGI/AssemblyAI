
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Request body for [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarization).
    /// </summary>
    public sealed partial class SummarizationRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.SummarizationRequestBodySummarization Summarization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationRequestBody" /> class.
        /// </summary>
        /// <param name="summarization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizationRequestBody(
            global::AssemblyAI.SummarizationRequestBodySummarization summarization)
        {
            this.Summarization = summarization ?? throw new global::System.ArgumentNullException(nameof(summarization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizationRequestBody" /> class.
        /// </summary>
        public SummarizationRequestBody()
        {
        }

    }
}