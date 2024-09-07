
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The confidence threshold for the automatically detected language.<br/>
    /// An error will be returned if the language confidence is below this threshold.
    /// </summary>
    public sealed partial class TranscriptLanguageConfidenceThreshold
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}