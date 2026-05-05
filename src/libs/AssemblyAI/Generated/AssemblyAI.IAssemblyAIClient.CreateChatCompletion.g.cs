#nullable enable

namespace AssemblyAI
{
    public partial interface IAssemblyAIClient
    {
        /// <summary>
        /// Create a chat completion<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// &lt;Note&gt;To use our EU server for LLM Gateway, replace `llm-gateway.assemblyai.com` with `llm-gateway.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Generates a response from a model given a prompt or a series of messages.
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Response> CreateChatCompletionAsync(
            string authorization,

            global::AssemblyAI.LLMGatewayRequest request,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// &lt;Note&gt;To use our EU server for LLM Gateway, replace `llm-gateway.assemblyai.com` with `llm-gateway.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Generates a response from a model given a prompt or a series of messages.
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.AutoSDKHttpResponse<global::AssemblyAI.Response>> CreateChatCompletionAsResponseAsync(
            string authorization,

            global::AssemblyAI.LLMGatewayRequest request,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// &lt;Note&gt;To use our EU server for LLM Gateway, replace `llm-gateway.assemblyai.com` with `llm-gateway.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Generates a response from a model given a prompt or a series of messages.
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="prompt">
        /// A simple string prompt. The API will automatically convert this into a user message.
        /// </param>
        /// <param name="model">
        /// The ID of the model to use for this request. See [LLM Gateway Overview](https://www.assemblyai.com/docs/llm-gateway/overview#available-models) for available models.
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
        /// <param name="fallbacks">
        /// An array of fallback objects. Each object must include a `model` and can optionally override any field from the original request. If the primary model fails, the LLM Gateway tries each fallback in order until one succeeds. See [Specify fallback models](https://www.assemblyai.com/docs/llm-gateway/fallback) for more details.
        /// </param>
        /// <param name="fallbackConfig">
        /// Configuration for fallback behavior, including retry and depth settings. See [Specify fallback models](https://www.assemblyai.com/docs/llm-gateway/fallback) for more details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Response> CreateChatCompletionAsync(
            string authorization,
            string model,
            global::System.Collections.Generic.IList<global::AssemblyAI.Message>? messages = default,
            string? prompt = default,
            int? maxTokens = default,
            double? temperature = default,
            bool? stream = default,
            global::System.Collections.Generic.IList<global::AssemblyAI.Tool>? tools = default,
            global::AssemblyAI.ToolChoice? toolChoice = default,
            global::AssemblyAI.ResponseFormat? responseFormat = default,
            global::System.Collections.Generic.IList<global::AssemblyAI.FallbackObject>? fallbacks = default,
            global::AssemblyAI.FallbackConfig? fallbackConfig = default,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}