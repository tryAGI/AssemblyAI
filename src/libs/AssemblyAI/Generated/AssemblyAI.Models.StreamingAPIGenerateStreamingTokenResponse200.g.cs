
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingAPIGenerateStreamingTokenResponse200
    {
        /// <summary>
        /// The temporary authentication token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// The actual expiration time of the token in seconds.
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
        /// Initializes a new instance of the <see cref="StreamingAPIGenerateStreamingTokenResponse200" /> class.
        /// </summary>
        /// <param name="token">
        /// The temporary authentication token
        /// </param>
        /// <param name="expiresInSeconds">
        /// The actual expiration time of the token in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamingAPIGenerateStreamingTokenResponse200(
            string token,
            int expiresInSeconds)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresInSeconds = expiresInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingAPIGenerateStreamingTokenResponse200" /> class.
        /// </summary>
        public StreamingAPIGenerateStreamingTokenResponse200()
        {
        }
    }
}