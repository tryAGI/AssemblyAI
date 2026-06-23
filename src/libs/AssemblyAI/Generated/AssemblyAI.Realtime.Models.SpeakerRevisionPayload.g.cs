
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Server event containing corrected speaker labels after termination.
    /// </summary>
    public sealed partial class SpeakerRevisionPayload
    {
        /// <summary>
        /// Message type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.SpeakerRevisionPayloadTypeJsonConverter))]
        public global::AssemblyAI.Realtime.SpeakerRevisionPayloadType Type { get; set; }

        /// <summary>
        /// Turns whose speaker labels changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revisions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.Realtime.SpeakerRevision> Revisions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerRevisionPayload" /> class.
        /// </summary>
        /// <param name="revisions">
        /// Turns whose speaker labels changed.
        /// </param>
        /// <param name="type">
        /// Message type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerRevisionPayload(
            global::System.Collections.Generic.IList<global::AssemblyAI.Realtime.SpeakerRevision> revisions,
            global::AssemblyAI.Realtime.SpeakerRevisionPayloadType type)
        {
            this.Type = type;
            this.Revisions = revisions ?? throw new global::System.ArgumentNullException(nameof(revisions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerRevisionPayload" /> class.
        /// </summary>
        public SpeakerRevisionPayload()
        {
        }

    }
}