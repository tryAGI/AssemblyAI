
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Specify the method used to redact audio. By default, redacted audio uses a beep sound. Set to `silence` to replace PII with silence instead of a beep.
    /// </summary>
    public enum TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Silence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethod value)
        {
            return value switch
            {
                TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethod.Silence => "silence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethod? ToEnum(string value)
        {
            return value switch
            {
                "silence" => TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethod.Silence,
                _ => null,
            };
        }
    }
}