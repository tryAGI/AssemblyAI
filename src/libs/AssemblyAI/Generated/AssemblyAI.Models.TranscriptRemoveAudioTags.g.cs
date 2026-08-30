
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Universal-3.5 Pro generates rich transcripts that can include inline annotations such as audio event markers and speaker cues. Set to `"all"` to remove all inline annotations, or `"speaker"` to remove only speaker cues while keeping other annotations. By default, all inline annotations are removed.<br/>
    /// Note: This parameter is only supported for the Universal-3.5 Pro model.
    /// </summary>
    public sealed partial class TranscriptRemoveAudioTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}