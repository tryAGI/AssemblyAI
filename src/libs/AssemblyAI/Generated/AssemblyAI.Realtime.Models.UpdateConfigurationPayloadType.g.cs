
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Message type identifier.
    /// </summary>
    public enum UpdateConfigurationPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        UpdateConfiguration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConfigurationPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConfigurationPayloadType value)
        {
            return value switch
            {
                UpdateConfigurationPayloadType.UpdateConfiguration => "UpdateConfiguration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConfigurationPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "UpdateConfiguration" => UpdateConfigurationPayloadType.UpdateConfiguration,
                _ => null,
            };
        }
    }
}