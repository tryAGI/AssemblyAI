
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptRemoveAudioTags
    {
        /// <summary>
        /// 
        /// </summary>
        All,
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
                _ => null,
            };
        }
    }
}