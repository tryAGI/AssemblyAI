
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A fallback model configuration. Each object must include a `model` and can optionally override any field from the original request. Fields not specified in the fallback inherit the values from the original request. See [Specify fallback models](https://www.assemblyai.com/docs/llm-gateway/fallback) for more details.
    /// </summary>
    public sealed partial class FallbackObject
    {
        /// <summary>
        /// The fallback model to use. See [LLM Gateway Overview](https://www.assemblyai.com/docs/llm-gateway/overview#available-models) for available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Override the messages for the fallback request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.Message>? Messages { get; set; }

        /// <summary>
        /// Override the maximum number of tokens to generate in the fallback completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Override the temperature for the fallback request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackObject" /> class.
        /// </summary>
        /// <param name="model">
        /// The fallback model to use. See [LLM Gateway Overview](https://www.assemblyai.com/docs/llm-gateway/overview#available-models) for available models.
        /// </param>
        /// <param name="messages">
        /// Override the messages for the fallback request.
        /// </param>
        /// <param name="maxTokens">
        /// Override the maximum number of tokens to generate in the fallback completion.
        /// </param>
        /// <param name="temperature">
        /// Override the temperature for the fallback request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackObject(
            string model,
            global::System.Collections.Generic.IList<global::AssemblyAI.Message>? messages,
            int? maxTokens,
            double? temperature)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackObject" /> class.
        /// </summary>
        public FallbackObject()
        {
        }
    }
}