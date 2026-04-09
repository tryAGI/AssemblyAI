
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Translations keyed by language code (e.g., `{"es": "Texto traducido", "de": "Übersetzter Text"}`). Only present when `match_original_utterance` is enabled.
    /// </summary>
    public sealed partial class LlmGatewayTranslationResponseUtterancesItemsTranslatedTexts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}