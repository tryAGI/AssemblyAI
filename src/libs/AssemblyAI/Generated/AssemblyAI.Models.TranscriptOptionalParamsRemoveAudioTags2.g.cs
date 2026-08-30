
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TranscriptOptionalParamsRemoveAudioTags2
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
    public static class TranscriptOptionalParamsRemoveAudioTags2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptOptionalParamsRemoveAudioTags2 value)
        {
            return value switch
            {
                TranscriptOptionalParamsRemoveAudioTags2.All => "all",
                TranscriptOptionalParamsRemoveAudioTags2.Speaker => "speaker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptOptionalParamsRemoveAudioTags2? ToEnum(string value)
        {
            return value switch
            {
                "all" => TranscriptOptionalParamsRemoveAudioTags2.All,
                "speaker" => TranscriptOptionalParamsRemoveAudioTags2.Speaker,
                _ => null,
            };
        }
    }
}