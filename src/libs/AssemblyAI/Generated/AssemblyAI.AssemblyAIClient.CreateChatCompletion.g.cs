
#nullable enable

namespace AssemblyAI
{
    public partial class AssemblyAIClient
    {

        private static readonly global::AssemblyAI.AutoSDKServer[] s_CreateChatCompletionServers = new global::AssemblyAI.AutoSDKServer[]
        {            new global::AssemblyAI.AutoSDKServer(
                id: "https-api-assemblyai-com",
                name: "api.assemblyai.com",
                url: "https://api.assemblyai.com/",
                description: ""),
            new global::AssemblyAI.AutoSDKServer(
                id: "https-llm-gateway-assemblyai-com-v1",
                name: "llm-gateway.assemblyai.com v1",
                url: "https://llm-gateway.assemblyai.com/v1",
                description: ""),
            new global::AssemblyAI.AutoSDKServer(
                id: "https-streaming-assemblyai-com",
                name: "streaming.assemblyai.com",
                url: "https://streaming.assemblyai.com/",
                description: ""),
            new global::AssemblyAI.AutoSDKServer(
                id: "https-agents-assemblyai-com",
                name: "agents.assemblyai.com",
                url: "https://agents.assemblyai.com/",
                description: ""),
        };
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AssemblyAI.Response> CreateChatCompletionAsync(
            string authorization,

            global::AssemblyAI.LLMGatewayRequest request,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionArguments(
                httpClient: HttpClient,
                authorization: ref authorization,
                request: request);

            using var __timeoutCancellationTokenSource = global::AssemblyAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::AssemblyAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::AssemblyAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::AssemblyAI.PathBuilder(
                                path: "/chat/completions",
                                baseUri: ResolveBaseUri(
                                servers: s_CreateChatCompletionServers,
                                defaultBaseUrl: "https://api.assemblyai.com/"));
                            var __path = __pathBuilder.ToString();
                __path = global::AssemblyAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
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
                global::AssemblyAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateChatCompletionRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    authorization: authorization!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::AssemblyAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::AssemblyAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletion",
                                methodName: "CreateChatCompletionAsync",
                                pathTemplate: "\"/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::AssemblyAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AssemblyAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletion",
                                methodName: "CreateChatCompletionAsync",
                                pathTemplate: "\"/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::AssemblyAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::AssemblyAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::AssemblyAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AssemblyAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletion",
                                methodName: "CreateChatCompletionAsync",
                                pathTemplate: "\"/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::AssemblyAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateChatCompletionResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::AssemblyAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::AssemblyAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletion",
                                methodName: "CreateChatCompletionAsync",
                                pathTemplate: "\"/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::AssemblyAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AssemblyAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateChatCompletion",
                                methodName: "CreateChatCompletionAsync",
                                pathTemplate: "\"/chat/completions\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
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
                                        __effectiveCancellationToken
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
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
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
        /// <param name="fallbacks">
        /// An array of fallback objects. Each object must include a `model` and can optionally override any field from the original request. If the primary model fails, the LLM Gateway tries each fallback in order until one succeeds. See [Specify fallback models](https://www.assemblyai.com/docs/llm-gateway/fallback) for more details.
        /// </param>
        /// <param name="fallbackConfig">
        /// Configuration for fallback behavior, including retry and depth settings. See [Specify fallback models](https://www.assemblyai.com/docs/llm-gateway/fallback) for more details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
            global::System.Collections.Generic.IList<global::AssemblyAI.FallbackObject>? fallbacks = default,
            global::AssemblyAI.FallbackConfig? fallbackConfig = default,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
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
                Fallbacks = fallbacks,
                FallbackConfig = fallbackConfig,
            };

            return await CreateChatCompletionAsync(
                authorization: authorization,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}