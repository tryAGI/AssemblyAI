
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParagraphsResponse
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
        /// The unique identifier of your transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// An array of paragraphs in the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paragraphs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptParagraph> Paragraphs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphsResponse" /> class.
        /// </summary>
        /// <param name="audioDuration">
        /// The duration of the audio file in seconds
        /// </param>
        /// <param name="confidence">
        /// The confidence score for the transcript
        /// </param>
        /// <param name="id">
        /// The unique identifier of your transcript
        /// </param>
        /// <param name="paragraphs">
        /// An array of paragraphs in the transcript
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParagraphsResponse(
            double audioDuration,
            double confidence,
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptParagraph> paragraphs)
        {
            this.AudioDuration = audioDuration;
            this.Confidence = confidence;
            this.Id = id;
            this.Paragraphs = paragraphs ?? throw new global::System.ArgumentNullException(nameof(paragraphs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphsResponse" /> class.
        /// </summary>
        public ParagraphsResponse()
        {
        }
    }
}