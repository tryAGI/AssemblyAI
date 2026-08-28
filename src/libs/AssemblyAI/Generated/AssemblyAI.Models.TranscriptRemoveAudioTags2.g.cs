
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    ///
    /// </summary>
    public enum TranscriptRemoveAudioTags2
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
    public static class TranscriptRemoveAudioTags2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptRemoveAudioTags2 value)
        {
            return value switch
            {
                TranscriptRemoveAudioTags2.All => "all",
                TranscriptRemoveAudioTags2.Speaker => "speaker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptRemoveAudioTags2? ToEnum(string value)
        {
            return value switch
            {
                "all" => TranscriptRemoveAudioTags2.All,
                "speaker" => TranscriptRemoveAudioTags2.Speaker,
                _ => null,
            };
        }
    }
}