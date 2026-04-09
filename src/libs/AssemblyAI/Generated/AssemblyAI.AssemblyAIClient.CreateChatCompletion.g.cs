
#nullable enable

namespace AssemblyAI
{
    public partial class AssemblyAIClient
    {
        partial void PrepareCreateChatCompletionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string authorization,
            global::AssemblyAI.LLMGatewayRequest request);
        partial void PrepareCreateChatCompletionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string authorization,
            global::AssemblyAI.LLMGatewayRequest request);
        partial void ProcessCreateChatCompletionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChatCompletionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AssemblyAI.Response> CreateChatCompletionAsync(
            string authorization,

            global::AssemblyAI.LLMGatewayRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionArguments(
                httpClient: HttpClient,
                authorization: ref authorization,
                request: request);

            var __pathBuilder = new global::AssemblyAI.PathBuilder(
                path: "/chat/completions",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            __httpRequest.Headers.TryAddWithoutValidation("Authorization", authorization.ToString());

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateChatCompletionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                authorization: authorization,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateChatCompletionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateChatCompletionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::AssemblyAI.Response.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::AssemblyAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::AssemblyAI.Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::AssemblyAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AssemblyAI.Response> CreateChatCompletionAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::AssemblyAI.LLMGatewayRequest
            {
                Messages = messages,
                Prompt = prompt,
                Model = model,
                MaxTokens = maxTokens,
                Temperature = temperature,
                Stream = stream,
                Tools = tools,
                ToolChoice = toolChoice,
                ResponseFormat = responseFormat,
            };

            return await CreateChatCompletionAsync(
                authorization: authorization,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}