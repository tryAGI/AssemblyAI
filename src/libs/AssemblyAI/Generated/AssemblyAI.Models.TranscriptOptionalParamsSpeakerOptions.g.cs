
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Specify options for [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization#set-a-range-of-possible-speakers). Use this to set a range of possible speakers.
    /// </summary>
    public sealed partial class TranscriptOptionalParamsSpeakerOptions
    {
        /// <summary>
        /// The minimum number of speakers expected in the audio file. See [Set a range of possible speakers](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization#set-a-range-of-possible-speakers) for more details.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_speakers_expected")]
        public int? MinSpeakersExpected { get; set; }

        /// <summary>
        /// &lt;Warning&gt;Setting this parameter too high may hurt model accuracy&lt;/Warning&gt;<br/>
        /// The maximum number of speakers expected in the audio file. See [Set a range of possible speakers](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization#set-a-range-of-possible-speakers) for more details.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_speakers_expected")]
        public int? MaxSpeakersExpected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParamsSpeakerOptions" /> class.
        /// </summary>
        /// <param name="minSpeakersExpected">
        /// The minimum number of speakers expected in the audio file. See [Set a range of possible speakers](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization#set-a-range-of-possible-speakers) for more details.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxSpeakersExpected">
        /// &lt;Warning&gt;Setting this parameter too high may hurt model accuracy&lt;/Warning&gt;<br/>
        /// The maximum number of speakers expected in the audio file. See [Set a range of possible speakers](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization#set-a-range-of-possible-speakers) for more details.<br/>
        /// Default Value: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptOptionalParamsSpeakerOptions(
            int? minSpeakersExpected,
            int? maxSpeakersExpected)
        {
            this.MinSpeakersExpected = minSpeakersExpected;
            this.MaxSpeakersExpected = maxSpeakersExpected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParamsSpeakerOptions" /> class.
        /// </summary>
        public TranscriptOptionalParamsSpeakerOptions()
        {
        }
    }
}