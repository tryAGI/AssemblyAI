
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Choice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public global::AssemblyAI.ResponseMessage? Message { get; set; }

        /// <summary>
        /// The reason the model stopped generating tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.FunctionToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Choice" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens.
        /// </param>
        /// <param name="toolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Choice(
            global::AssemblyAI.ResponseMessage? message,
            string? finishReason,
            global::System.Collections.Generic.IList<global::AssemblyAI.FunctionToolCall>? toolCalls)
        {
            this.Message = message;
            this.FinishReason = finishReason;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Choice" /> class.
        /// </summary>
        public Choice()
        {
        }
    }
}