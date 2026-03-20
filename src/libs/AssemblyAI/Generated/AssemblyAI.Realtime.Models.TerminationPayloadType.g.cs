
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Message type identifier.
    /// </summary>
    public enum TerminationPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        Termination,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerminationPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerminationPayloadType value)
        {
            return value switch
            {
                TerminationPayloadType.Termination => "Termination",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerminationPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "Termination" => TerminationPayloadType.Termination,
                _ => null,
            };
        }
    }
}