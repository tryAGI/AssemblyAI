
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The notification when the transcript status is completed or error.
    /// </summary>
    public sealed partial class TranscriptReadyNotification
    {
        /// <summary>
        /// The status of the transcript. Either completed or error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptReadyStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.TranscriptReadyStatus Status { get; set; }

        /// <summary>
        /// The ID of the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TranscriptId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptReadyNotification" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the transcript. Either completed or error.
        /// </param>
        /// <param name="transcriptId">
        /// The ID of the transcript
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptReadyNotification(
            global::AssemblyAI.TranscriptReadyStatus status,
            global::System.Guid transcriptId)
        {
            this.Status = status;
            this.TranscriptId = transcriptId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptReadyNotification" /> class.
        /// </summary>
        public TranscriptReadyNotification()
        {
        }
    }
}