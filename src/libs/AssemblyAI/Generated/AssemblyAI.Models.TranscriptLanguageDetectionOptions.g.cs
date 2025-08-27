
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Specify options for Automatic Language Detection.
    /// </summary>
    public sealed partial class TranscriptLanguageDetectionOptions
    {
        /// <summary>
        /// List of languages expected in the audio file. Defaults to `["all"]` when unspecified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_languages")]
        public byte[]? ExpectedLanguages { get; set; }

        /// <summary>
        /// If the detected language of the audio file is not in the list of expected languages, the `fallback_language` is used. Specify `["auto"]` to let our model choose the fallback language from `expected_languages` with the highest confidence score.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_language")]
        public string? FallbackLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptLanguageDetectionOptions" /> class.
        /// </summary>
        /// <param name="expectedLanguages">
        /// List of languages expected in the audio file. Defaults to `["all"]` when unspecified.
        /// </param>
        /// <param name="fallbackLanguage">
        /// If the detected language of the audio file is not in the list of expected languages, the `fallback_language` is used. Specify `["auto"]` to let our model choose the fallback language from `expected_languages` with the highest confidence score.<br/>
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptLanguageDetectionOptions(
            byte[]? expectedLanguages,
            string? fallbackLanguage)
        {
            this.ExpectedLanguages = expectedLanguages;
            this.FallbackLanguage = fallbackLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptLanguageDetectionOptions" /> class.
        /// </summary>
        public TranscriptLanguageDetectionOptions()
        {
        }
    }
}