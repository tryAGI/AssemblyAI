
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A copy of the original request, excluding `prompt` and `messages`.
    /// </summary>
    public sealed partial class ResponseRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.Tool>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) function is called by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.ToolChoiceJsonConverter))]
        public global::AssemblyAI.ToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="maxTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice">
        /// Controls which (if any) function is called by the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseRequest(
            string? model,
            int? maxTokens,
            double? temperature,
            global::System.Collections.Generic.IList<global::AssemblyAI.Tool>? tools,
            global::AssemblyAI.ToolChoice? toolChoice)
        {
            this.Model = model;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRequest" /> class.
        /// </summary>
        public ResponseRequest()
        {
        }
    }
}