
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmGatewayCustomFormattingResponseSpeechUnderstandingResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_formatting")]
        public global::AssemblyAI.LlmGatewayCustomFormattingResponseSpeechUnderstandingResponseCustomFormatting? CustomFormatting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayCustomFormattingResponseSpeechUnderstandingResponse" /> class.
        /// </summary>
        /// <param name="customFormatting"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmGatewayCustomFormattingResponseSpeechUnderstandingResponse(
            global::AssemblyAI.LlmGatewayCustomFormattingResponseSpeechUnderstandingResponseCustomFormatting? customFormatting)
        {
            this.CustomFormatting = customFormatting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayCustomFormattingResponseSpeechUnderstandingResponse" /> class.
        /// </summary>
        public LlmGatewayCustomFormattingResponseSpeechUnderstandingResponse()
        {
        }
    }
}