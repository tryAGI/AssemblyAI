
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The speech understanding task to perform. Supports [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). Click into the request object below to see the available options.
    /// </summary>
    public sealed partial class UnderstandingRequestSpeechUnderstanding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.UnderstandingRequestSpeechUnderstandingRequestJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.UnderstandingRequestSpeechUnderstandingRequest Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnderstandingRequestSpeechUnderstanding" /> class.
        /// </summary>
        /// <param name="request"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnderstandingRequestSpeechUnderstanding(
            global::AssemblyAI.UnderstandingRequestSpeechUnderstandingRequest request)
        {
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnderstandingRequestSpeechUnderstanding" /> class.
        /// </summary>
        public UnderstandingRequestSpeechUnderstanding()
        {
        }
    }
}