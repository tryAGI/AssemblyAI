
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserAssistantSystemMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserAssistantSystemMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserAssistantSystemMessageRole value)
        {
            return value switch
            {
                UserAssistantSystemMessageRole.Assistant => "assistant",
                UserAssistantSystemMessageRole.System => "system",
                UserAssistantSystemMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserAssistantSystemMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => UserAssistantSystemMessageRole.Assistant,
                "system" => UserAssistantSystemMessageRole.System,
                "user" => UserAssistantSystemMessageRole.User,
                _ => null,
            };
        }
    }
}