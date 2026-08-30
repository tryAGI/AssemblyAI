
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The audio quality of the PII-redacted audio file, if redact_pii_audio is enabled.<br/>
    /// See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more information.
    /// </summary>
    public sealed partial class TranscriptRedactPiiAudioQuality
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}