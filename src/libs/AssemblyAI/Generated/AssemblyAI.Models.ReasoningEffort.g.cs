
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The reasoning effort level. Most models support this parameter. Valid values are `low`, `medium`, and `high`.
    /// </summary>
    public enum ReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffort value)
        {
            return value switch
            {
                ReasoningEffort.High => "high",
                ReasoningEffort.Low => "low",
                ReasoningEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ReasoningEffort.High,
                "low" => ReasoningEffort.Low,
                "medium" => ReasoningEffort.Medium,
                _ => null,
            };
        }
    }
}