
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Specify options for [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection).
    /// </summary>
    public sealed partial class TranscriptLanguageDetectionOptions
    {
        /// <summary>
        /// List of languages expected in the audio file. Defaults to `["all"]` when unspecified. See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_languages")]
        public global::System.Collections.Generic.IList<string>? ExpectedLanguages { get; set; }

        /// <summary>
        /// If the detected language of the audio file is not in the list of expected languages, the `fallback_language` is used. Specify `["auto"]` to let our model choose the fallback language from `expected_languages` with the highest confidence score. See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_language")]
        public string? FallbackLanguage { get; set; }

        /// <summary>
        /// Whether [code switching](/docs/speech-to-text/pre-recorded-audio/code-switching) should be detected.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_switching")]
        public bool? CodeSwitching { get; set; }

        /// <summary>
        /// The confidence threshold for [code switching](/docs/speech-to-text/pre-recorded-audio/code-switching) detection. If the code switching confidence is below this threshold, the transcript will be processed in the language with the highest `language_detection_confidence` score.<br/>
        /// Default Value: 0.3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_switching_confidence_threshold")]
        public double? CodeSwitchingConfidenceThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptLanguageDetectionOptions" /> class.
        /// </summary>
        /// <param name="expectedLanguages">
        /// List of languages expected in the audio file. Defaults to `["all"]` when unspecified. See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.
        /// </param>
        /// <param name="fallbackLanguage">
        /// If the detected language of the audio file is not in the list of expected languages, the `fallback_language` is used. Specify `["auto"]` to let our model choose the fallback language from `expected_languages` with the highest confidence score. See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="codeSwitching">
        /// Whether [code switching](/docs/speech-to-text/pre-recorded-audio/code-switching) should be detected.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="codeSwitchingConfidenceThreshold">
        /// The confidence threshold for [code switching](/docs/speech-to-text/pre-recorded-audio/code-switching) detection. If the code switching confidence is below this threshold, the transcript will be processed in the language with the highest `language_detection_confidence` score.<br/>
        /// Default Value: 0.3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptLanguageDetectionOptions(
            global::System.Collections.Generic.IList<string>? expectedLanguages,
            string? fallbackLanguage,
            bool? codeSwitching,
            double? codeSwitchingConfidenceThreshold)
        {
            this.ExpectedLanguages = expectedLanguages;
            this.FallbackLanguage = fallbackLanguage;
            this.CodeSwitching = codeSwitching;
            this.CodeSwitchingConfidenceThreshold = codeSwitchingConfidenceThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptLanguageDetectionOptions" /> class.
        /// </summary>
        public TranscriptLanguageDetectionOptions()
        {
        }
    }
}