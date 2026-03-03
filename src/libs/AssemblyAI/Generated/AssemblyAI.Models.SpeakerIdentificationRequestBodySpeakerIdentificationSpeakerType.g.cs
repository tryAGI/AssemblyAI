
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Type of speaker identification
    /// </summary>
    public enum SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType
    {
        /// <summary>
        /// 
        /// </summary>
        Role,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType value)
        {
            return value switch
            {
                SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType.Role => "role",
                SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType? ToEnum(string value)
        {
            return value switch
            {
                "role" => SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType.Role,
                "name" => SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType.Name,
                _ => null,
            };
        }
    }
}