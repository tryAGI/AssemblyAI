
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmGatewayTranslationResponseSpeechUnderstanding
    {
        /// <summary>
        /// Request body for [Translation](https://www.assemblyai.com/docs/speech-understanding/translation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::AssemblyAI.TranslationRequestBody? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::AssemblyAI.LlmGatewayTranslationResponseSpeechUnderstandingResponse? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayTranslationResponseSpeechUnderstanding" /> class.
        /// </summary>
        /// <param name="request">
        /// Request body for [Translation](https://www.assemblyai.com/docs/speech-understanding/translation).
        /// </param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmGatewayTranslationResponseSpeechUnderstanding(
            global::AssemblyAI.TranslationRequestBody? request,
            global::AssemblyAI.LlmGatewayTranslationResponseSpeechUnderstandingResponse? response)
        {
            this.Request = request;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayTranslationResponseSpeechUnderstanding" /> class.
        /// </summary>
        public LlmGatewayTranslationResponseSpeechUnderstanding()
        {
        }
    }
}