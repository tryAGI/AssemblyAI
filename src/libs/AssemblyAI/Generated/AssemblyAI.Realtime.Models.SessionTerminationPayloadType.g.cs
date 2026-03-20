
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Message type identifier.
    /// </summary>
    public enum SessionTerminationPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        Terminate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionTerminationPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionTerminationPayloadType value)
        {
            return value switch
            {
                SessionTerminationPayloadType.Terminate => "Terminate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionTerminationPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "Terminate" => SessionTerminationPayloadType.Terminate,
                _ => null,
            };
        }
    }
}