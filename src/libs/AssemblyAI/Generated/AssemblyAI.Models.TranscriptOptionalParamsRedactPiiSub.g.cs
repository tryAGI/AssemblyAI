
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The replacement logic for detected PII, can be `entity_name` or `hash`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
    /// Default Value: hash
    /// </summary>
    public sealed partial class TranscriptOptionalParamsRedactPiiSub
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}