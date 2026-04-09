
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="totalTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            int inputTokens,
            int outputTokens,
            int totalTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}