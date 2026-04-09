
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolChoiceOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceOneOf1Type value)
        {
            return value switch
            {
                ToolChoiceOneOf1Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolChoiceOneOf1Type.Function,
                _ => null,
            };
        }
    }
}