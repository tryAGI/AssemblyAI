
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The options for PII-redacted audio, if redact_pii_audio is enabled.<br/>
    /// See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more information.
    /// </summary>
    public sealed partial class TranscriptRedactPiiAudioOptions
    {
        /// <summary>
        /// By default, audio redaction provides redacted audio URLs only when speech is detected. However, if your use-case specifically requires redacted audio files even for silent audio files without any dialogue, you can opt to receive these URLs by setting this parameter to `true`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_redacted_no_speech_audio")]
        public bool? ReturnRedactedNoSpeechAudio { get; set; }

        /// <summary>
        /// Specify the method used to redact audio. By default, redacted audio uses a beep sound. Set to `silence` to replace PII with silence instead of a beep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_audio_redaction_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethodJsonConverter))]
        public global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod? OverrideAudioRedactionMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptRedactPiiAudioOptions" /> class.
        /// </summary>
        /// <param name="returnRedactedNoSpeechAudio">
        /// By default, audio redaction provides redacted audio URLs only when speech is detected. However, if your use-case specifically requires redacted audio files even for silent audio files without any dialogue, you can opt to receive these URLs by setting this parameter to `true`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="overrideAudioRedactionMethod">
        /// Specify the method used to redact audio. By default, redacted audio uses a beep sound. Set to `silence` to replace PII with silence instead of a beep.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptRedactPiiAudioOptions(
            bool? returnRedactedNoSpeechAudio,
            global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod? overrideAudioRedactionMethod)
        {
            this.ReturnRedactedNoSpeechAudio = returnRedactedNoSpeechAudio;
            this.OverrideAudioRedactionMethod = overrideAudioRedactionMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptRedactPiiAudioOptions" /> class.
        /// </summary>
        public TranscriptRedactPiiAudioOptions()
        {
        }
    }
}