
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Request body for [Translation](https://www.assemblyai.com/docs/speech-understanding/translation).
    /// </summary>
    public sealed partial class TranslationRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.TranslationRequestBodyTranslation Translation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationRequestBody" /> class.
        /// </summary>
        /// <param name="translation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationRequestBody(
            global::AssemblyAI.TranslationRequestBodyTranslation translation)
        {
            this.Translation = translation ?? throw new global::System.ArgumentNullException(nameof(translation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationRequestBody" /> class.
        /// </summary>
        public TranslationRequestBody()
        {
        }
    }
}