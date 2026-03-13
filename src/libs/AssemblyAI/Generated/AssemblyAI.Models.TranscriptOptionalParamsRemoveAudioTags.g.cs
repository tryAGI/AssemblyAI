
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptOptionalParamsRemoveAudioTags
    {
        /// <summary>
        /// 
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