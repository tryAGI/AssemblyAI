
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMGatewayTranslationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_understanding")]
        public global::AssemblyAI.LlmGatewayTranslationResponseSpeechUnderstanding? SpeechUnderstanding { get; set; }

        /// <summary>
        /// Translated text keyed by language code (e.g., `{"es": "Texto traducido"}`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translated_texts")]
        public global::System.Collections.Generic.Dictionary<string, string>? TranslatedTexts { get; set; }

        /// <summary>
        /// Array of utterances with translations (when `match_original_utterance` is true)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewayTranslationResponseUtterancesItems>? Utterances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewayTranslationResponseWordsItems>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGatewayTranslationResponse" /> class.
        /// </summary>
        /// <param name="speechUnderstanding"></param>
        /// <param name="translatedTexts">
        /// Translated text keyed by language code (e.g., `{"es": "Texto traducido"}`)
        /// </param>
        /// <param name="utterances">
        /// Array of utterances with translations (when `match_original_utterance` is true)
        /// </param>
        /// <param name="words"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMGatewayTranslationResponse(
            global::AssemblyAI.LlmGatewayTranslationResponseSpeechUnderstanding? speechUnderstanding,
            global::System.Collections.Generic.Dictionary<string, string>? translatedTexts,
            global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewayTranslationResponseUtterancesItems>? utterances,
            global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewayTranslationResponseWordsItems>? words)
        {
            this.SpeechUnderstanding = speechUnderstanding;
            this.TranslatedTexts = translatedTexts;
            this.Utterances = utterances;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGatewayTranslationResponse" /> class.
        /// </summary>
        public LLMGatewayTranslationResponse()
        {
        }
    }
}