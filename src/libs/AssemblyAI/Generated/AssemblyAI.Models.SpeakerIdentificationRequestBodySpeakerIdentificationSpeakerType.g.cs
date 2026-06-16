
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Type of speaker identification. See [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification) for details on each type.
    /// </summary>
    public enum SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType
    {
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Role,
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
                SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType.Name => "name",
                SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType.Role => "role",
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
                "name" => SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType.Name,
                "role" => SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType.Role,
                _ => null,
            };
        }
    }
}