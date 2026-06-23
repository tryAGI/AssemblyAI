
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Message type identifier.
    /// </summary>
    public enum SpeakerRevisionPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeakerRevision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakerRevisionPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakerRevisionPayloadType value)
        {
            return value switch
            {
                SpeakerRevisionPayloadType.SpeakerRevision => "SpeakerRevision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakerRevisionPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "SpeakerRevision" => SpeakerRevisionPayloadType.SpeakerRevision,
                _ => null,
            };
        }
    }
}