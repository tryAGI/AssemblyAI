
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The usage numbers for the LeMUR request
    /// </summary>
    public sealed partial class LemurUsage
    {
        /// <summary>
        /// The number of input tokens used by the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// The number of output tokens generated by the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of input tokens used by the model
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens generated by the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LemurUsage(
            int inputTokens,
            int outputTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurUsage" /> class.
        /// </summary>
        public LemurUsage()
        {
        }
    }
}