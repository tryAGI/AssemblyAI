
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SummarizationRequestBodySummarizationEffort
    {
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
    public static class SummarizationRequestBodySummarizationEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizationRequestBodySummarizationEffort value)
        {
            return value switch
            {
                SummarizationRequestBodySummarizationEffort.Low => "low",
                SummarizationRequestBodySummarizationEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizationRequestBodySummarizationEffort? ToEnum(string value)
        {
            return value switch
            {
                "low" => SummarizationRequestBodySummarizationEffort.Low,
                "medium" => SummarizationRequestBodySummarizationEffort.Medium,
                _ => null,
            };
        }
    }
}