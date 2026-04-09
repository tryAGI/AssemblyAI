
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolChoice0
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoice0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoice0 value)
        {
            return value switch
            {
                ToolChoice0.Auto => "auto",
                ToolChoice0.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoice0? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ToolChoice0.Auto,
                "none" => ToolChoice0.None,
                _ => null,
            };
        }
    }
}