
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Example: {"redacted_audio_url":"https://s3.us-west-2.amazonaws.com/api.assembly.ai.usw2/redacted-audio/785efd9e-0e20-45e1-967b-3db17770ed9f.wav?AWSAccessKeyId=aws-access-key0id\u0026Signature=signature\u0026x-amz-security-token=security-token\u0026Expires=1698966551","status":"redacted_audio_ready"}
    /// </summary>
    public sealed partial class RedactedAudioResponse
    {
        /// <summary>
        /// The status of the redacted audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.RedactedAudioStatusJsonConverter))]
        public global::AssemblyAI.RedactedAudioStatus Status { get; set; }

        /// <summary>
        /// The URL of the redacted audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedactedAudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedAudioResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the redacted audio
        /// </param>
        /// <param name="redactedAudioUrl">
        /// The URL of the redacted audio file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedactedAudioResponse(
            string redactedAudioUrl,
            global::AssemblyAI.RedactedAudioStatus status)
        {
            this.RedactedAudioUrl = redactedAudioUrl ?? throw new global::System.ArgumentNullException(nameof(redactedAudioUrl));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedAudioResponse" /> class.
        /// </summary>
        public RedactedAudioResponse()
        {
        }
    }
}