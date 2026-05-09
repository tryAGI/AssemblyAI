
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Message type identifier.
    /// </summary>
    public enum KeepAlivePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        KeepAlive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeepAlivePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeepAlivePayloadType value)
        {
            return value switch
            {
                KeepAlivePayloadType.KeepAlive => "KeepAlive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeepAlivePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "KeepAlive" => KeepAlivePayloadType.KeepAlive,
                _ => null,
            };
        }
    }
}