
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The type of post-processing to apply. Currently `json-repair` is supported.
    /// </summary>
    public enum PostProcessingStepType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonRepair,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostProcessingStepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostProcessingStepType value)
        {
            return value switch
            {
                PostProcessingStepType.JsonRepair => "json-repair",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostProcessingStepType? ToEnum(string value)
        {
            return value switch
            {
                "json-repair" => PostProcessingStepType.JsonRepair,
                _ => null,
            };
        }
    }
}