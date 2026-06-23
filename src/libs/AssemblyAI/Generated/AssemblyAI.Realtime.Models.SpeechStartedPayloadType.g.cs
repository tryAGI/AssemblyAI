
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Message type identifier.
    /// </summary>
    public enum SpeechStartedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechStartedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechStartedPayloadType value)
        {
            return value switch
            {
                SpeechStartedPayloadType.SpeechStarted => "SpeechStarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechStartedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "SpeechStarted" => SpeechStartedPayloadType.SpeechStarted,
                _ => null,
            };
        }
    }
}