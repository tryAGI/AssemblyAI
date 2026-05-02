
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Universal-3 Pro generates rich transcripts that can include inline annotations such as audio event markers and speaker cues. Set to `"all"` to remove all inline annotations, or `"speaker"` to remove only speaker cues while keeping other annotations.<br/>
    /// Note: This parameter is only supported for the Universal-3 Pro model.
    /// </summary>
    public enum TranscriptOptionalParamsRemoveAudioTags
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Speaker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptOptionalParamsRemoveAudioTagsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptOptionalParamsRemoveAudioTags value)
        {
            return value switch
            {
                TranscriptOptionalParamsRemoveAudioTags.All => "all",
                TranscriptOptionalParamsRemoveAudioTags.Speaker => "speaker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptOptionalParamsRemoveAudioTags? ToEnum(string value)
        {
            return value switch
            {
                "all" => TranscriptOptionalParamsRemoveAudioTags.All,
                "speaker" => TranscriptOptionalParamsRemoveAudioTags.Speaker,
                _ => null,
            };
        }
    }
}