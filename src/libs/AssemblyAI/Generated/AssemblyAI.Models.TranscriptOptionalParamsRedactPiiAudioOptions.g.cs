
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Specify options for PII redacted audio files.
    /// </summary>
    public sealed partial class TranscriptOptionalParamsRedactPiiAudioOptions
    {
        /// <summary>
        /// By default, audio redaction provides redacted audio URLs only when speech is detected. However, if your use-case specifically requires redacted audio files even for silent audio files without any dialogue, you can opt to receive these URLs by setting this parameter to `true`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_redacted_no_speech_audio")]
        public bool? ReturnRedactedNoSpeechAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParamsRedactPiiAudioOptions" /> class.
        /// </summary>
        /// <param name="returnRedactedNoSpeechAudio">
        /// By default, audio redaction provides redacted audio URLs only when speech is detected. However, if your use-case specifically requires redacted audio files even for silent audio files without any dialogue, you can opt to receive these URLs by setting this parameter to `true`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptOptionalParamsRedactPiiAudioOptions(
            bool? returnRedactedNoSpeechAudio)
        {
            this.ReturnRedactedNoSpeechAudio = returnRedactedNoSpeechAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParamsRedactPiiAudioOptions" /> class.
        /// </summary>
        public TranscriptOptionalParamsRedactPiiAudioOptions()
        {
        }
    }
}