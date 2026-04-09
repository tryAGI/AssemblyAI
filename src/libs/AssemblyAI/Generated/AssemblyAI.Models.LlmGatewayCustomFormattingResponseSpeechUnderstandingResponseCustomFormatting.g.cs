
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmGatewayCustomFormattingResponseSpeechUnderstandingResponseCustomFormatting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Mapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted_text")]
        public string? FormattedText { get; set; }

        /// <summary>
        /// Array of formatted utterances. Only included when utterances exist and formatting was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted_utterances")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewayCustomFormattingResponseSpeechUnderstandingResponseCustomFormattingFormattedUtterancesItems>? FormattedUtterances { get; set; }

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
        /// Initializes a new instance of the <see cref="LlmGatewayCustomFormattingResponseSpeechUnderstandingResponseCustomFormatting" /> class.
        /// </summary>
        /// <param name="mapping"></param>
        /// <param name="status"></param>
        /// <param name="formattedText"></param>
        /// <param name="formattedUtterances">
        /// Array of formatted utterances. Only included when utterances exist and formatting was applied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmGatewayCustomFormattingResponseSpeechUnderstandingResponseCustomFormatting(
            global::System.Collections.Generic.Dictionary<string, string> mapping,
            string status,
            string? formattedText,
            global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewayCustomFormattingResponseSpeechUnderstandingResponseCustomFormattingFormattedUtterancesItems>? formattedUtterances)
        {
            this.Mapping = mapping ?? throw new global::System.ArgumentNullException(nameof(mapping));
            this.FormattedText = formattedText;
            this.FormattedUtterances = formattedUtterances;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayCustomFormattingResponseSpeechUnderstandingResponseCustomFormatting" /> class.
        /// </summary>
        public LlmGatewayCustomFormattingResponseSpeechUnderstandingResponseCustomFormatting()
        {
        }
    }
}