
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Specify the method used to redact audio. By default, redacted audio uses a beep sound. Set to `silence` to replace PII with silence instead of a beep.
    /// </summary>
    public enum TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Silence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod value)
        {
            return value switch
            {
                TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod.Silence => "silence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod? ToEnum(string value)
        {
            return value switch
            {
                "silence" => TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod.Silence,
                _ => null,
            };
        }
    }
}