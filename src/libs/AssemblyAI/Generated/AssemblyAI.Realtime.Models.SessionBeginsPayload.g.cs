
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Server event indicating the streaming session has started.
    /// </summary>
    public sealed partial class SessionBeginsPayload
    {
        /// <summary>
        /// Message type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.SessionBeginsPayloadTypeJsonConverter))]
        public global::AssemblyAI.Realtime.SessionBeginsPayloadType Type { get; set; }

        /// <summary>
        /// Unique session identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unix timestamp indicating when the session will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset ExpiresAt { get; set; }

        /// <summary>
        /// Configuration actually applied by the server. Check model against the requested speech model because unrecognized query parameters may be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::AssemblyAI.Realtime.SessionConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionBeginsPayload" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique session identifier.
        /// </param>
        /// <param name="expiresAt">
        /// Unix timestamp indicating when the session will expire.
        /// </param>
        /// <param name="type">
        /// Message type identifier.
        /// </param>
        /// <param name="configuration">
        /// Configuration actually applied by the server. Check model against the requested speech model because unrecognized query parameters may be ignored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionBeginsPayload(
            string id,
            global::System.DateTimeOffset expiresAt,
            global::AssemblyAI.Realtime.SessionBeginsPayloadType type,
            global::AssemblyAI.Realtime.SessionConfiguration? configuration)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ExpiresAt = expiresAt;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionBeginsPayload" /> class.
        /// </summary>
        public SessionBeginsPayload()
        {
        }

    }
}