
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Specify options for [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-a-range-of-possible-speakers). Use this to set a range of possible speakers. Requires `speaker_labels` to be `true`, and cannot be used together with `speakers_expected`. When both bounds are set, `min_speakers_expected` must be less than or equal to `max_speakers_expected`.
    /// </summary>
    public sealed partial class TranscriptOptionalParamsSpeakerOptions
    {
        /// <summary>
        /// A hard lower limit on the number of speaker labels — the model won't return fewer speakers than this. See [Set a range of possible speakers](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-a-range-of-possible-speakers) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_speakers_expected")]
        public int? MinSpeakersExpected { get; set; }

        /// <summary>
        /// &lt;Warning&gt;Setting this parameter too high may hurt model accuracy&lt;/Warning&gt;<br/>
        /// A hard upper limit on the number of speaker labels. If more people speak than this value, the additional speakers are merged into existing labels. Setting it higher than the true number of speakers can cause the model to over-split and return more speakers than are actually present. The default depends on audio duration: no limit for 0-2 minutes, 10 for 2-10 minutes, and 30 for 10+ minutes. See [Set a range of possible speakers](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-a-range-of-possible-speakers) for more details.
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
        /// A hard lower limit on the number of speaker labels — the model won't return fewer speakers than this. See [Set a range of possible speakers](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-a-range-of-possible-speakers) for more details.
        /// </param>
        /// <param name="maxSpeakersExpected">
        /// &lt;Warning&gt;Setting this parameter too high may hurt model accuracy&lt;/Warning&gt;<br/>
        /// A hard upper limit on the number of speaker labels. If more people speak than this value, the additional speakers are merged into existing labels. Setting it higher than the true number of speakers can cause the model to over-split and return more speakers than are actually present. The default depends on audio duration: no limit for 0-2 minutes, 10 for 2-10 minutes, and 30 for 10+ minutes. See [Set a range of possible speakers](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-a-range-of-possible-speakers) for more details.
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