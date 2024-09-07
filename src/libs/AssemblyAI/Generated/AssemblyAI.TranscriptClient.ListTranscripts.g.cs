
#nullable enable

namespace AssemblyAI
{
    public partial class TranscriptClient
    {
        partial void PrepareListTranscriptsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::AssemblyAI.ListTranscriptParams? limit,
            ref global::AssemblyAI.TranscriptStatus? status,
            global::AssemblyAI.ListTranscriptParams? createdOn,
            global::AssemblyAI.ListTranscriptParams? beforeId,
            global::AssemblyAI.ListTranscriptParams? afterId,
            global::AssemblyAI.ListTranscriptParams? throttledOnly);
        partial void PrepareListTranscriptsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::AssemblyAI.ListTranscriptParams? limit,
            global::AssemblyAI.TranscriptStatus? status,
            global::AssemblyAI.ListTranscriptParams? createdOn,
            global::AssemblyAI.ListTranscriptParams? beforeId,
            global::AssemblyAI.ListTranscriptParams? afterId,
            global::AssemblyAI.ListTranscriptParams? throttledOnly);
        partial void ProcessListTranscriptsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTranscriptsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List transcripts<br/>
        /// Retrieve a list of transcripts you created.<br/>
        /// Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="createdOn"></param>
        /// <param name="beforeId"></param>
        /// <param name="afterId"></param>
        /// <param name="throttledOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AssemblyAI.TranscriptList> ListTranscriptsAsync(
            global::AssemblyAI.ListTranscriptParams? limit = default,
            global::AssemblyAI.TranscriptStatus? status = default,
            global::AssemblyAI.ListTranscriptParams? createdOn = default,
            global::AssemblyAI.ListTranscriptParams? beforeId = default,
            global::AssemblyAI.ListTranscriptParams? afterId = default,
            global::AssemblyAI.ListTranscriptParams? throttledOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListTranscriptsArguments(
                httpClient: _httpClient,
                limit: limit,
                status: ref status,
                createdOn: createdOn,
                beforeId: beforeId,
                afterId: afterId,
                throttledOnly: throttledOnly);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v2/transcript?limit={limit}&status={limit}&created_on={limit}&before_id={limit}&after_id={limit}&throttled_only={limit}&status={(global::System.Uri.EscapeDataString(status?.ToValueString() ?? string.Empty))}&limit={createdOn}&status={createdOn}&created_on={createdOn}&before_id={createdOn}&after_id={createdOn}&throttled_only={createdOn}&limit={beforeId}&status={beforeId}&created_on={beforeId}&before_id={beforeId}&after_id={beforeId}&throttled_only={beforeId}&limit={afterId}&status={afterId}&created_on={afterId}&before_id={afterId}&after_id={afterId}&throttled_only={afterId}&limit={throttledOnly}&status={throttledOnly}&created_on={throttledOnly}&before_id={throttledOnly}&after_id={throttledOnly}&throttled_only={throttledOnly}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListTranscriptsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                limit: limit,
                status: status,
                createdOn: createdOn,
                beforeId: beforeId,
                afterId: afterId,
                throttledOnly: throttledOnly);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListTranscriptsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListTranscriptsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::AssemblyAI.SourceGenerationContext.Default.TranscriptList) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}