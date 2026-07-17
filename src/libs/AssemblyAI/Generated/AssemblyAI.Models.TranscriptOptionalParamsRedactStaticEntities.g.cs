
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A map of user-defined terms to redact, where each key is a redaction label and each value is a list of exact terms to match (e.g. `{ "INTERNAL_TOOL": ["Bearclaw", "Cubclaw"] }`). Each matching term in the transcript is redacted using the `redact_pii_sub` substitution, on top of standard PII Redaction. Useful for redacting specific, predefined terms (proprietary names, internal codenames) that aren't general PII categories.<br/>
    /// This is a literal find-and-replace (tolerant of casing, surrounding punctuation, and minor spacing/hyphenation), not a model — it does not generalize beyond the terms you provide. Requires `redact_pii` to be `true`, otherwise a 400 error is returned. When `redact_pii_audio` is enabled, matched terms are also redacted in the audio output. You can provide up to 100 labels, each with up to 200 terms of at most 200 characters; a label may contain only letters, numbers, spaces, underscores, and hyphens (max 80 characters). See [Static Entity Redaction](https://www.assemblyai.com/docs/guardrails/redact-pii-from-transcripts#static-entity-redaction) for more details.
    /// </summary>
    public sealed partial class TranscriptOptionalParamsRedactStaticEntities
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}