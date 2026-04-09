
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnderstandingRequest
    {
        /// <summary>
        /// The ID of the transcript to process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscriptId { get; set; }

        /// <summary>
        /// The speech understanding task to perform. Supports [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). Click into the request object below to see the available options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_understanding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.UnderstandingRequestSpeechUnderstanding SpeechUnderstanding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnderstandingRequest" /> class.
        /// </summary>
        /// <param name="transcriptId">
        /// The ID of the transcript to process.
        /// </param>
        /// <param name="speechUnderstanding">
        /// The speech understanding task to perform. Supports [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). Click into the request object below to see the available options.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnderstandingRequest(
            string transcriptId,
            global::AssemblyAI.UnderstandingRequestSpeechUnderstanding speechUnderstanding)
        {
            this.TranscriptId = transcriptId ?? throw new global::System.ArgumentNullException(nameof(transcriptId));
            this.SpeechUnderstanding = speechUnderstanding ?? throw new global::System.ArgumentNullException(nameof(speechUnderstanding));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnderstandingRequest" /> class.
        /// </summary>
        public UnderstandingRequest()
        {
        }
    }
}