
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Message type identifier.
    /// </summary>
    public enum TurnPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        Turn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurnPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurnPayloadType value)
        {
            return value switch
            {
                TurnPayloadType.Turn => "Turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurnPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "Turn" => TurnPayloadType.Turn,
                _ => null,
            };
        }
    }
}