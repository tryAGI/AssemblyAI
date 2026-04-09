
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Remove [audio event tags](https://www.assemblyai.com/docs/pre-recorded-audio/universal-3-pro#audio-event-tags) from the transcript text. Set to `"all"` to remove all audio tags.<br/>
    /// Note: This parameter is only supported for the Universal-3 Pro model.
    /// </summary>
    public enum TranscriptOptionalParamsRemoveAudioTags
    {
        /// <summary>
        /// //www.assemblyai.com/docs/pre-recorded-audio/universal-3-pro#audio-event-tags) from the transcript text. Set to `"all"` to remove all audio tags.
        /// </summary>
        All,
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
                _ => null,
            };
        }
    }
}