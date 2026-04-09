
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Speech understanding tasks like [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). See the task-specific docs for available options and configuration.
    /// </summary>
    public sealed partial class TranscriptSpeechUnderstanding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptSpeechUnderstandingRequestJsonConverter))]
        public global::AssemblyAI.TranscriptSpeechUnderstandingRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptSpeechUnderstandingResponseJsonConverter))]
        public global::AssemblyAI.TranscriptSpeechUnderstandingResponse? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptSpeechUnderstanding" /> class.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptSpeechUnderstanding(
            global::AssemblyAI.TranscriptSpeechUnderstandingRequest? request,
            global::AssemblyAI.TranscriptSpeechUnderstandingResponse? response)
        {
            this.Request = request;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptSpeechUnderstanding" /> class.
        /// </summary>
        public TranscriptSpeechUnderstanding()
        {
        }
    }
}