
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Server-emitted validation, authentication or quota error. Typically delivered immediately before the WebSocket is closed by the server.
    /// </summary>
    public sealed partial class ErrorPayload
    {
        /// <summary>
        /// Message type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.ErrorPayloadTypeJsonConverter))]
        public global::AssemblyAI.Realtime.ErrorPayloadType Type { get; set; }

        /// <summary>
        /// AssemblyAI numeric error code (e.g. 3006 for invalid input, 4003 for unauthorized).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErrorCode { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorPayload" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// AssemblyAI numeric error code (e.g. 3006 for invalid input, 4003 for unauthorized).
        /// </param>
        /// <param name="error">
        /// Human-readable error message.
        /// </param>
        /// <param name="type">
        /// Message type identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorPayload(
            int errorCode,
            string error,
            global::AssemblyAI.Realtime.ErrorPayloadType type)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorPayload" /> class.
        /// </summary>
        public ErrorPayload()
        {
        }

    }
}