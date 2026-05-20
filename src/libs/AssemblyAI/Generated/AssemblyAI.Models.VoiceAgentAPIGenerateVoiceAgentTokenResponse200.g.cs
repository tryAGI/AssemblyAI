
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceAgentAPIGenerateVoiceAgentTokenResponse200
    {
        /// <summary>
        /// The temporary authentication token. Pass as the `token` query parameter when opening the WebSocket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// The token redemption window in seconds — the time the client has to use this token to open a WebSocket before it expires unused. This is not the session duration; see `max_session_duration_seconds` for that.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceAgentAPIGenerateVoiceAgentTokenResponse200" /> class.
        /// </summary>
        /// <param name="token">
        /// The temporary authentication token. Pass as the `token` query parameter when opening the WebSocket.
        /// </param>
        /// <param name="expiresInSeconds">
        /// The token redemption window in seconds — the time the client has to use this token to open a WebSocket before it expires unused. This is not the session duration; see `max_session_duration_seconds` for that.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceAgentAPIGenerateVoiceAgentTokenResponse200(
            string token,
            int expiresInSeconds)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresInSeconds = expiresInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceAgentAPIGenerateVoiceAgentTokenResponse200" /> class.
        /// </summary>
        public VoiceAgentAPIGenerateVoiceAgentTokenResponse200()
        {
        }

    }
}