#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptsClient
    {
        /// <summary>
        /// Search words in transcript<br/>
        /// &lt;Note&gt;To search through a transcription created on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Search through the transcript for keywords. You can search for individual words, numbers, or phrases containing up to five words or numbers.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="words"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.WordSearchResponse> WordSearchAsync(
            string transcriptId,
            global::System.Collections.Generic.IList<string> words,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search words in transcript<br/>
        /// &lt;Note&gt;To search through a transcription created on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Search through the transcript for keywords. You can search for individual words, numbers, or phrases containing up to five words or numbers.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="words"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.AutoSDKHttpResponse<global::AssemblyAI.WordSearchResponse>> WordSearchAsResponseAsync(
            string transcriptId,
            global::System.Collections.Generic.IList<string> words,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}