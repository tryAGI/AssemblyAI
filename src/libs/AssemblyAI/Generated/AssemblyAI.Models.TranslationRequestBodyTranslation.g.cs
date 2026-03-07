
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationRequestBodyTranslation
    {
        /// <summary>
        /// List of target language codes (e.g., `["es", "de"]`). See [Translation](https://www.assemblyai.com/docs/speech-understanding/translation) for supported languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TargetLanguages { get; set; }

        /// <summary>
        /// Use formal language style. See [Translation](https://www.assemblyai.com/docs/speech-understanding/translation) for more details.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formal")]
        public bool? Formal { get; set; }

        /// <summary>
        /// When enabled with Speaker Labels, returns translated text in the utterances array. Each utterance will include a `translated_texts` key containing translations for each target language.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_original_utterance")]
        public bool? MatchOriginalUtterance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationRequestBodyTranslation" /> class.
        /// </summary>
        /// <param name="targetLanguages">
        /// List of target language codes (e.g., `["es", "de"]`). See [Translation](https://www.assemblyai.com/docs/speech-understanding/translation) for supported languages.
        /// </param>
        /// <param name="formal">
        /// Use formal language style. See [Translation](https://www.assemblyai.com/docs/speech-understanding/translation) for more details.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="matchOriginalUtterance">
        /// When enabled with Speaker Labels, returns translated text in the utterances array. Each utterance will include a `translated_texts` key containing translations for each target language.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationRequestBodyTranslation(
            global::System.Collections.Generic.IList<string> targetLanguages,
            bool? formal,
            bool? matchOriginalUtterance)
        {
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.Formal = formal;
            this.MatchOriginalUtterance = matchOriginalUtterance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationRequestBodyTranslation" /> class.
        /// </summary>
        public TranslationRequestBodyTranslation()
        {
        }
    }
}