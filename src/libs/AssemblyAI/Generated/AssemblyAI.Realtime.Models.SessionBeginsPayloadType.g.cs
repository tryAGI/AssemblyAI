
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Message type identifier.
    /// </summary>
    public enum SessionBeginsPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        Begin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionBeginsPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionBeginsPayloadType value)
        {
            return value switch
            {
                SessionBeginsPayloadType.Begin => "Begin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionBeginsPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "Begin" => SessionBeginsPayloadType.Begin,
                _ => null,
            };
        }
    }
}