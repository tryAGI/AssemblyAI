
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Keep-alive ping that resets the server-side `inactivity_timeout` timer. Only needed when `inactivity_timeout` is set and audio is paused without terminating the session.
    /// </summary>
    public sealed partial class KeepAlivePayload
    {
        /// <summary>
        /// Message type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.KeepAlivePayloadTypeJsonConverter))]
        public global::AssemblyAI.Realtime.KeepAlivePayloadType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeepAlivePayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeepAlivePayload(
            global::AssemblyAI.Realtime.KeepAlivePayloadType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeepAlivePayload" /> class.
        /// </summary>
        public KeepAlivePayload()
        {
        }
    }
}