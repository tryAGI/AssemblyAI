
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Example: {"id":"9ea68fd3-f953-42c1-9742-976c447fb463","resource_url":"https://api.assemblyai.com/v2/transcript/9ea68fd3-f953-42c1-9742-976c447fb463","status":"completed","created":"2023-11-02T21:49:25.586965","completed":"2023-11-02T21:49:25.586965","audio_url":"https://assembly.ai/wildfires.mp3","error":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}
    /// </summary>
    public sealed partial class TranscriptListItem
    {
        /// <summary>
        /// The unique identifier for the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The URL to retrieve the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceUrl { get; set; }

        /// <summary>
        /// The status of the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.TranscriptStatus Status { get; set; }

        /// <summary>
        /// The date and time the transcript was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Created { get; set; }

        /// <summary>
        /// The date and time the transcript was completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Completed { get; set; }

        /// <summary>
        /// The URL to the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// Error message of why the transcript failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptListItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the transcript
        /// </param>
        /// <param name="resourceUrl">
        /// The URL to retrieve the transcript
        /// </param>
        /// <param name="status">
        /// The status of the transcript
        /// </param>
        /// <param name="created">
        /// The date and time the transcript was created
        /// </param>
        /// <param name="completed">
        /// The date and time the transcript was completed
        /// </param>
        /// <param name="audioUrl">
        /// The URL to the audio file
        /// </param>
        /// <param name="error">
        /// Error message of why the transcript failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptListItem(
            global::System.Guid id,
            string resourceUrl,
            global::AssemblyAI.TranscriptStatus status,
            string created,
            string? completed,
            string audioUrl,
            string? error)
        {
            this.Id = id;
            this.ResourceUrl = resourceUrl ?? throw new global::System.ArgumentNullException(nameof(resourceUrl));
            this.Status = status;
            this.Created = created ?? throw new global::System.ArgumentNullException(nameof(created));
            this.Completed = completed ?? throw new global::System.ArgumentNullException(nameof(completed));
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptListItem" /> class.
        /// </summary>
        public TranscriptListItem()
        {
        }
    }
}