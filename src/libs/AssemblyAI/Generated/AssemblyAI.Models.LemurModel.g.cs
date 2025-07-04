
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The model that is used for the final prompt after compression is performed.
    /// </summary>
    public enum LemurModel
    {
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaudeSonnet420250514,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaudeOpus420250514,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude37Sonnet20250219,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude35Sonnet,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude35Haiku20241022,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude3Opus,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude3Haiku,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude3Sonnet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LemurModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LemurModel value)
        {
            return value switch
            {
                LemurModel.AnthropicClaudeSonnet420250514 => "anthropic/claude-sonnet-4-20250514",
                LemurModel.AnthropicClaudeOpus420250514 => "anthropic/claude-opus-4-20250514",
                LemurModel.AnthropicClaude37Sonnet20250219 => "anthropic/claude-3-7-sonnet-20250219",
                LemurModel.AnthropicClaude35Sonnet => "anthropic/claude-3-5-sonnet",
                LemurModel.AnthropicClaude35Haiku20241022 => "anthropic/claude-3-5-haiku-20241022",
                LemurModel.AnthropicClaude3Opus => "anthropic/claude-3-opus",
                LemurModel.AnthropicClaude3Haiku => "anthropic/claude-3-haiku",
                LemurModel.AnthropicClaude3Sonnet => "anthropic/claude-3-sonnet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LemurModel? ToEnum(string value)
        {
            return value switch
            {
                "anthropic/claude-sonnet-4-20250514" => LemurModel.AnthropicClaudeSonnet420250514,
                "anthropic/claude-opus-4-20250514" => LemurModel.AnthropicClaudeOpus420250514,
                "anthropic/claude-3-7-sonnet-20250219" => LemurModel.AnthropicClaude37Sonnet20250219,
                "anthropic/claude-3-5-sonnet" => LemurModel.AnthropicClaude35Sonnet,
                "anthropic/claude-3-5-haiku-20241022" => LemurModel.AnthropicClaude35Haiku20241022,
                "anthropic/claude-3-opus" => LemurModel.AnthropicClaude3Opus,
                "anthropic/claude-3-haiku" => LemurModel.AnthropicClaude3Haiku,
                "anthropic/claude-3-sonnet" => LemurModel.AnthropicClaude3Sonnet,
                _ => null,
            };
        }
    }
}