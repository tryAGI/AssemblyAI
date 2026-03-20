
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Gracefully terminate the streaming session.
    /// </summary>
    public sealed partial class SessionTerminationPayload
    {
        /// <summary>
        /// Message type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.SessionTerminationPayloadTypeJsonConverter))]
        public global::AssemblyAI.Realtime.SessionTerminationPayloadType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTerminationPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionTerminationPayload(
            global::AssemblyAI.Realtime.SessionTerminationPayloadType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTerminationPayload" /> class.
        /// </summary>
        public SessionTerminationPayload()
        {
        }
    }
}