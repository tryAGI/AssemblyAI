
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmGatewayTranslationResponseUtterancesItems
    {
        /// <summary>
        /// Translations keyed by language code (e.g., `{"es": "Texto traducido", "de": "Übersetzter Text"}`). Only present when `match_original_utterance` is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translated_texts")]
        public global::System.Collections.Generic.Dictionary<string, string>? TranslatedTexts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayTranslationResponseUtterancesItems" /> class.
        /// </summary>
        /// <param name="translatedTexts">
        /// Translations keyed by language code (e.g., `{"es": "Texto traducido", "de": "Übersetzter Text"}`). Only present when `match_original_utterance` is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmGatewayTranslationResponseUtterancesItems(
            global::System.Collections.Generic.Dictionary<string, string>? translatedTexts)
        {
            this.TranslatedTexts = translatedTexts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewayTranslationResponseUtterancesItems" /> class.
        /// </summary>
        public LlmGatewayTranslationResponseUtterancesItems()
        {
        }
    }
}