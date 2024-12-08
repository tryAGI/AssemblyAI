
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptListItem
    {
        /// <summary>
        /// The URL to the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// The date and time the transcript was completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Completed { get; set; }

        /// <summary>
        /// The date and time the transcript was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Created { get; set; }

        /// <summary>
        /// Error message of why the transcript failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Error { get; set; }

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
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.TranscriptStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptListItem" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// The URL to the audio file
        /// </param>
        /// <param name="completed">
        /// The date and time the transcript was completed
        /// </param>
        /// <param name="created">
        /// The date and time the transcript was created
        /// </param>
        /// <param name="error">
        /// Error message of why the transcript failed
        /// </param>
        /// <param name="id">
        /// The unique identifier for the transcript
        /// </param>
        /// <param name="resourceUrl">
        /// The URL to retrieve the transcript
        /// </param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptListItem(
            string audioUrl,
            string? completed,
            string created,
            string? error,
            global::System.Guid id,
            string resourceUrl,
            global::AssemblyAI.TranscriptStatus status)
        {
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.Completed = completed ?? throw new global::System.ArgumentNullException(nameof(completed));
            this.Created = created ?? throw new global::System.ArgumentNullException(nameof(created));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Id = id;
            this.ResourceUrl = resourceUrl ?? throw new global::System.ArgumentNullException(nameof(resourceUrl));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptListItem" /> class.
        /// </summary>
        public TranscriptListItem()
        {
        }
    }
}