
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Controls reasoning behavior for supported models. Supported on OpenAI-compatible models, Gemini 3+ models, and Anthropic models.
    /// </summary>
    public sealed partial class Reasoning
    {
        /// <summary>
        /// The reasoning effort level. Most models support this parameter. Valid values are `low`, `medium`, and `high`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.ReasoningEffortJsonConverter))]
        public global::AssemblyAI.ReasoningEffort? Effort { get; set; }

        /// <summary>
        /// The maximum number of tokens the model can use for internal reasoning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Reasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// The reasoning effort level. Most models support this parameter. Valid values are `low`, `medium`, and `high`.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens the model can use for internal reasoning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Reasoning(
            global::AssemblyAI.ReasoningEffort? effort,
            int? maxTokens)
        {
            this.Effort = effort;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reasoning" /> class.
        /// </summary>
        public Reasoning()
        {
        }

    }
}