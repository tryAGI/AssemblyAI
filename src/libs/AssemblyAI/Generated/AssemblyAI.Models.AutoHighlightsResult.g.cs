
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// An array of results for the Key Phrases model, if it is enabled.<br/>
    /// See [Key phrases](https://www.assemblyai.com/docs/models/key-phrases) for more information.
    /// </summary>
    public sealed partial class AutoHighlightsResult
    {
        /// <summary>
        /// A temporally-sequential array of Key Phrases
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.AutoHighlightResult> Results { get; set; }

        /// <summary>
        /// Either success, or unavailable in the rare case that the model failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.AudioIntelligenceModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.AudioIntelligenceModelStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHighlightsResult" /> class.
        /// </summary>
        /// <param name="results">
        /// A temporally-sequential array of Key Phrases
        /// </param>
        /// <param name="status">
        /// Either success, or unavailable in the rare case that the model failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoHighlightsResult(
            global::System.Collections.Generic.IList<global::AssemblyAI.AutoHighlightResult> results,
            global::AssemblyAI.AudioIntelligenceModelStatus status)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHighlightsResult" /> class.
        /// </summary>
        public AutoHighlightsResult()
        {
        }
    }
}