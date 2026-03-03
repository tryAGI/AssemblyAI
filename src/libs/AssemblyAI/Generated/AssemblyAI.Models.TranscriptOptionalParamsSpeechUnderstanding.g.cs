
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Enable speech understanding tasks like translation, speaker identification, and custom formatting
    /// </summary>
    public sealed partial class TranscriptOptionalParamsSpeechUnderstanding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.OneOf<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody> Request { get; set; }

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
            global::AssemblyAI.OneOf<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody> request)
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