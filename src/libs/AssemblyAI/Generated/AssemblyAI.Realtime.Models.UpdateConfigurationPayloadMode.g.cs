
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Latency and accuracy preset.
    /// </summary>
    public enum UpdateConfigurationPayloadMode
    {
        /// <summary>
        /// 
        /// </summary>
        Balanced,
        /// <summary>
        /// 
        /// </summary>
        MaxAccuracy,
        /// <summary>
        /// 
        /// </summary>
        MinLatency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConfigurationPayloadModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConfigurationPayloadMode value)
        {
            return value switch
            {
                UpdateConfigurationPayloadMode.Balanced => "balanced",
                UpdateConfigurationPayloadMode.MaxAccuracy => "max_accuracy",
                UpdateConfigurationPayloadMode.MinLatency => "min_latency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConfigurationPayloadMode? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => UpdateConfigurationPayloadMode.Balanced,
                "max_accuracy" => UpdateConfigurationPayloadMode.MaxAccuracy,
                "min_latency" => UpdateConfigurationPayloadMode.MinLatency,
                _ => null,
            };
        }
    }
}