
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Manually force an endpoint in the transcription.
    /// </summary>
    public sealed partial class ForceEndpointPayload
    {
        /// <summary>
        /// Message type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.ForceEndpointPayloadTypeJsonConverter))]
        public global::AssemblyAI.Realtime.ForceEndpointPayloadType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForceEndpointPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForceEndpointPayload(
            global::AssemblyAI.Realtime.ForceEndpointPayloadType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForceEndpointPayload" /> class.
        /// </summary>
        public ForceEndpointPayload()
        {
        }
    }
}