
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmGatewayTranslationResponseSpeechUnderstandingResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        public global::AssemblyAI.LlmGatewayTranslationResponseSpeechUnderstandingResponseTranslation? Translation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayTranslationResponseSpeechUnderstandingResponse" /> class.
        /// </summary>
        /// <param name="translation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmGatewayTranslationResponseSpeechUnderstandingResponse(
            global::AssemblyAI.LlmGatewayTranslationResponseSpeechUnderstandingResponseTranslation? translation)
        {
            this.Translation = translation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayTranslationResponseSpeechUnderstandingResponse" /> class.
        /// </summary>
        public LlmGatewayTranslationResponseSpeechUnderstandingResponse()
        {
        }
    }
}