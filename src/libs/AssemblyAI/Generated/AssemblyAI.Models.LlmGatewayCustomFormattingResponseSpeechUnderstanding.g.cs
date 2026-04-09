
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmGatewayCustomFormattingResponseSpeechUnderstanding
    {
        /// <summary>
        /// Request body for [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::AssemblyAI.CustomFormattingRequestBody? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::AssemblyAI.LlmGatewayCustomFormattingResponseSpeechUnderstandingResponse? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayCustomFormattingResponseSpeechUnderstanding" /> class.
        /// </summary>
        /// <param name="request">
        /// Request body for [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting).
        /// </param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmGatewayCustomFormattingResponseSpeechUnderstanding(
            global::AssemblyAI.CustomFormattingRequestBody? request,
            global::AssemblyAI.LlmGatewayCustomFormattingResponseSpeechUnderstandingResponse? response)
        {
            this.Request = request;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayCustomFormattingResponseSpeechUnderstanding" /> class.
        /// </summary>
        public LlmGatewayCustomFormattingResponseSpeechUnderstanding()
        {
        }
    }
}