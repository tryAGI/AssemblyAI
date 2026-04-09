
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The main request body for the chat completions endpoint.
    /// </summary>
    public sealed partial class LLMGatewayRequest
    {
        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.Message>? Messages { get; set; }

        /// <summary>
        /// A simple string prompt. The API will automatically convert this into a user message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The ID of the model to use for this request. See [LLM Gateway Overview](https://www.assemblyai.com/docs/llm-gateway/overview#available-models) for available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate in the completion. Default is 1000.<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Controls randomness. Lower values produce more deterministic results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// When true, responses are streamed as server-sent events (SSE). Supported on OpenAI models only.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// A list of tools the model may call.
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
        /// Specifies the format of the model's response. Use this to constrain the model to output valid JSON matching a schema. Supported by OpenAI (GPT-4.1, GPT-5.x), Gemini, and Claude models. Not supported by gpt-oss models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::AssemblyAI.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGatewayRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The ID of the model to use for this request. See [LLM Gateway Overview](https://www.assemblyai.com/docs/llm-gateway/overview#available-models) for available models.
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="prompt">
        /// A simple string prompt. The API will automatically convert this into a user message.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. Default is 1000.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="temperature">
        /// Controls randomness. Lower values produce more deterministic results.
        /// </param>
        /// <param name="stream">
        /// When true, responses are streamed as server-sent events (SSE). Supported on OpenAI models only.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) function is called by the model.
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format of the model's response. Use this to constrain the model to output valid JSON matching a schema. Supported by OpenAI (GPT-4.1, GPT-5.x), Gemini, and Claude models. Not supported by gpt-oss models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMGatewayRequest(
            string model,
            global::System.Collections.Generic.IList<global::AssemblyAI.Message>? messages,
            string? prompt,
            int? maxTokens,
            double? temperature,
            bool? stream,
            global::System.Collections.Generic.IList<global::AssemblyAI.Tool>? tools,
            global::AssemblyAI.ToolChoice? toolChoice,
            global::AssemblyAI.ResponseFormat? responseFormat)
        {
            this.Messages = messages;
            this.Prompt = prompt;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.Stream = stream;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGatewayRequest" /> class.
        /// </summary>
        public LLMGatewayRequest()
        {
        }
    }
}