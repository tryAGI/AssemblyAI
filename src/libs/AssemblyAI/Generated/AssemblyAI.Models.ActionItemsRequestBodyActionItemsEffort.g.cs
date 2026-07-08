
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionItemsRequestBodyActionItemsEffort
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
    public static class ActionItemsRequestBodyActionItemsEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionItemsRequestBodyActionItemsEffort value)
        {
            return value switch
            {
                ActionItemsRequestBodyActionItemsEffort.Low => "low",
                ActionItemsRequestBodyActionItemsEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionItemsRequestBodyActionItemsEffort? ToEnum(string value)
        {
            return value switch
            {
                "low" => ActionItemsRequestBodyActionItemsEffort.Low,
                "medium" => ActionItemsRequestBodyActionItemsEffort.Medium,
                _ => null,
            };
        }
    }
}