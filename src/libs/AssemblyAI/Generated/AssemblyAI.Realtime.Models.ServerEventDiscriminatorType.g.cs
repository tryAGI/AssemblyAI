
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Begin,
        /// <summary>
        /// 
        /// </summary>
        Termination,
        /// <summary>
        /// 
        /// </summary>
        Turn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.Begin => "Begin",
                ServerEventDiscriminatorType.Termination => "Termination",
                ServerEventDiscriminatorType.Turn => "Turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "Begin" => ServerEventDiscriminatorType.Begin,
                "Termination" => ServerEventDiscriminatorType.Termination,
                "Turn" => ServerEventDiscriminatorType.Turn,
                _ => null,
            };
        }
    }
}