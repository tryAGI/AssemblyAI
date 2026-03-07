
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Translated text keyed by language code. See [Translation](https://www.assemblyai.com/docs/speech-understanding/translation) for more details.
    /// </summary>
    public sealed partial class TranscriptTranslatedTexts
    {
        /// <summary>
        /// Translated text for this language code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTranslatedTexts" /> class.
        /// </summary>
        /// <param name="languageCode">
        /// Translated text for this language code
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptTranslatedTexts(
            string? languageCode)
        {
            this.LanguageCode = languageCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTranslatedTexts" /> class.
        /// </summary>
        public TranscriptTranslatedTexts()
        {
        }
    }
}