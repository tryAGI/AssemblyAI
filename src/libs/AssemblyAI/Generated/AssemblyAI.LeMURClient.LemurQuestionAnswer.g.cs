
#nullable enable

namespace AssemblyAI
{
    public partial class LeMURClient
    {
        partial void PrepareLemurQuestionAnswerArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::AssemblyAI.LemurQuestionAnswerParams request);
        partial void PrepareLemurQuestionAnswerRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::AssemblyAI.LemurQuestionAnswerParams request);
        partial void ProcessLemurQuestionAnswerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessLemurQuestionAnswerResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Ask questions using LeMUR<br/>
        /// Question &amp; Answer allows you to ask free-form questions about a single transcript or a group of transcripts.<br/>
        /// The questions can be any whose answers you find useful, such as judging whether a caller is likely to become a customer or whether all items on a meeting's agenda were covered.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AssemblyAI.LemurQuestionAnswerResponse> LemurQuestionAnswerAsync(
            global::AssemblyAI.LemurQuestionAnswerParams request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareLemurQuestionAnswerArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/lemur/v3/generate/question-answer", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::AssemblyAI.SourceGenerationContext.Default.NullableLemurQuestionAnswerParams);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareLemurQuestionAnswerRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessLemurQuestionAnswerResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessLemurQuestionAnswerResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::AssemblyAI.SourceGenerationContext.Default.NullableLemurQuestionAnswerResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Ask questions using LeMUR<br/>
        /// Question &amp; Answer allows you to ask free-form questions about a single transcript or a group of transcripts.<br/>
        /// The questions can be any whose answers you find useful, such as judging whether a caller is likely to become a customer or whether all items on a meeting's agenda were covered.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AssemblyAI.LemurQuestionAnswerResponse> LemurQuestionAnswerAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::AssemblyAI.LemurQuestionAnswerParams
            {
            };

            return await LemurQuestionAnswerAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}