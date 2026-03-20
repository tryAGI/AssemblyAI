
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Server event confirming session termination with statistics.
    /// </summary>
    public sealed partial class TerminationPayload
    {
        /// <summary>
        /// Message type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.TerminationPayloadTypeJsonConverter))]
        public global::AssemblyAI.Realtime.TerminationPayloadType Type { get; set; }

        /// <summary>
        /// Duration of audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioDurationSeconds { get; set; }

        /// <summary>
        /// Duration of session in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_duration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SessionDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TerminationPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier.
        /// </param>
        /// <param name="audioDurationSeconds">
        /// Duration of audio in seconds.
        /// </param>
        /// <param name="sessionDurationSeconds">
        /// Duration of session in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TerminationPayload(
            int audioDurationSeconds,
            int sessionDurationSeconds,
            global::AssemblyAI.Realtime.TerminationPayloadType type)
        {
            this.AudioDurationSeconds = audioDurationSeconds;
            this.SessionDurationSeconds = sessionDurationSeconds;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TerminationPayload" /> class.
        /// </summary>
        public TerminationPayload()
        {
        }
    }
}