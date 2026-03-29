
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
        AnthropicClaude35Haiku20241022,
        /// <summary>
        /// Claude 3.5 Sonnet is Anthropic's most intelligent model to date, outperforming Claude 3 Opus on a wide range of evaluations, with the speed and cost of Claude 3 Sonnet.
        /// </summary>
        AnthropicClaude3_5_Sonnet,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaude37Sonnet20250219,
        /// <summary>
        /// Claude 3 Haiku is the fastest model that can execute lightweight actions.
        /// </summary>
        AnthropicClaude3_Haiku,
        /// <summary>
        /// Claude 3 Opus is good at handling complex analysis, longer tasks with many steps, and higher-order math and coding tasks.
        /// </summary>
        AnthropicClaude3_Opus,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaudeOpus420250514,
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaudeSonnet420250514,
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
                LemurModel.AnthropicClaude35Haiku20241022 => "anthropic/claude-3-5-haiku-20241022",
                LemurModel.AnthropicClaude3_5_Sonnet => "anthropic/claude-3-5-sonnet",
                LemurModel.AnthropicClaude37Sonnet20250219 => "anthropic/claude-3-7-sonnet-20250219",
                LemurModel.AnthropicClaude3_Haiku => "anthropic/claude-3-haiku",
                LemurModel.AnthropicClaude3_Opus => "anthropic/claude-3-opus",
                LemurModel.AnthropicClaudeOpus420250514 => "anthropic/claude-opus-4-20250514",
                LemurModel.AnthropicClaudeSonnet420250514 => "anthropic/claude-sonnet-4-20250514",
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
                "anthropic/claude-3-5-haiku-20241022" => LemurModel.AnthropicClaude35Haiku20241022,
                "anthropic/claude-3-5-sonnet" => LemurModel.AnthropicClaude3_5_Sonnet,
                "anthropic/claude-3-7-sonnet-20250219" => LemurModel.AnthropicClaude37Sonnet20250219,
                "anthropic/claude-3-haiku" => LemurModel.AnthropicClaude3_Haiku,
                "anthropic/claude-3-opus" => LemurModel.AnthropicClaude3_Opus,
                "anthropic/claude-opus-4-20250514" => LemurModel.AnthropicClaudeOpus420250514,
                "anthropic/claude-sonnet-4-20250514" => LemurModel.AnthropicClaudeSonnet420250514,
                _ => null,
            };
        }
    }
}