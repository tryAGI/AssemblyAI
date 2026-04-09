
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Enable speech understanding tasks like [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). See the task-specific docs for available options and configuration.
    /// </summary>
    public sealed partial class TranscriptOptionalParamsSpeechUnderstanding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptOptionalParamsSpeechUnderstandingRequestJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstandingRequest Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParamsSpeechUnderstanding" /> class.
        /// </summary>
        /// <param name="request"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptOptionalParamsSpeechUnderstanding(
            global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstandingRequest request)
        {
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParamsSpeechUnderstanding" /> class.
        /// </summary>
        public TranscriptOptionalParamsSpeechUnderstanding()
        {
        }
    }
}