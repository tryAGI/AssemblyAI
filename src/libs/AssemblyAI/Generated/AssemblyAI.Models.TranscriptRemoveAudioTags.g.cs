
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Universal-3 Pro generates rich transcripts that can include inline annotations such as audio event markers and speaker cues. Set to `"all"` to remove all inline annotations, or `"speaker"` to remove only speaker cues while keeping other annotations.<br/>
    /// Note: This parameter is only supported for the Universal-3 Pro model.
    /// </summary>
    public enum TranscriptRemoveAudioTags
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
    public static class TranscriptRemoveAudioTagsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptRemoveAudioTags value)
        {
            return value switch
            {
                TranscriptRemoveAudioTags.All => "all",
                TranscriptRemoveAudioTags.Speaker => "speaker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptRemoveAudioTags? ToEnum(string value)
        {
            return value switch
            {
                "all" => TranscriptRemoveAudioTags.All,
                "speaker" => TranscriptRemoveAudioTags.Speaker,
                _ => null,
            };
        }
    }
}