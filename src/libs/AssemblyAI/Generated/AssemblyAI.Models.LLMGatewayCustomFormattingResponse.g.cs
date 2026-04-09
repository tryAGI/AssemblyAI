
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMGatewayCustomFormattingResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_understanding")]
        public global::AssemblyAI.LlmGatewayCustomFormattingResponseSpeechUnderstanding? SpeechUnderstanding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewayCustomFormattingResponseUtterancesItems>? Utterances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGatewayCustomFormattingResponse" /> class.
        /// </summary>
        /// <param name="speechUnderstanding"></param>
        /// <param name="utterances"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMGatewayCustomFormattingResponse(
            global::AssemblyAI.LlmGatewayCustomFormattingResponseSpeechUnderstanding? speechUnderstanding,
            global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewayCustomFormattingResponseUtterancesItems>? utterances)
        {
            this.SpeechUnderstanding = speechUnderstanding;
            this.Utterances = utterances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGatewayCustomFormattingResponse" /> class.
        /// </summary>
        public LLMGatewayCustomFormattingResponse()
        {
        }
    }
}