
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Message type identifier.
    /// </summary>
    public enum ForceEndpointPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ForceEndpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ForceEndpointPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ForceEndpointPayloadType value)
        {
            return value switch
            {
                ForceEndpointPayloadType.ForceEndpoint => "ForceEndpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ForceEndpointPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "ForceEndpoint" => ForceEndpointPayloadType.ForceEndpoint,
                _ => null,
            };
        }
    }
}