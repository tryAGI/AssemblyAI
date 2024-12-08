
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentencesResponse
    {
        /// <summary>
        /// The duration of the audio file in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioDuration { get; set; }

        /// <summary>
        /// The confidence score for the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The unique identifier for the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// An array of sentences in the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptSentence> Sentences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentencesResponse" /> class.
        /// </summary>
        /// <param name="audioDuration">
        /// The duration of the audio file in seconds
        /// </param>
        /// <param name="confidence">
        /// The confidence score for the transcript
        /// </param>
        /// <param name="id">
        /// The unique identifier for the transcript
        /// </param>
        /// <param name="sentences">
        /// An array of sentences in the transcript
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SentencesResponse(
            double audioDuration,
            double confidence,
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptSentence> sentences)
        {
            this.AudioDuration = audioDuration;
            this.Confidence = confidence;
            this.Id = id;
            this.Sentences = sentences ?? throw new global::System.ArgumentNullException(nameof(sentences));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentencesResponse" /> class.
        /// </summary>
        public SentencesResponse()
        {
        }
    }
}