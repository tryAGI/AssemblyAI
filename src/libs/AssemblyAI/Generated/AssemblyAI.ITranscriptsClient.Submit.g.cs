#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptsClient
    {
        /// <summary>
        /// Transcribe audio<br/>
        /// &lt;Note&gt;To use our EU server for transcription, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// &lt;Tip&gt;Building a load test or submitting a large batch? [See our guide →](/pre-recorded-audio/guides/bulk-transcription-and-load-tests-at-scale)&lt;/Tip&gt;<br/>
        /// Create a transcript from a media file that is accessible via a URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Transcript> SubmitAsync(

            global::AssemblyAI.TranscriptParams request,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe audio<br/>
        /// &lt;Note&gt;To use our EU server for transcription, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// &lt;Tip&gt;Building a load test or submitting a large batch? [See our guide →](/pre-recorded-audio/guides/bulk-transcription-and-load-tests-at-scale)&lt;/Tip&gt;<br/>
        /// Create a transcript from a media file that is accessible via a URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.AutoSDKHttpResponse<global::AssemblyAI.Transcript>> SubmitAsResponseAsync(

            global::AssemblyAI.TranscriptParams request,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe audio<br/>
        /// &lt;Note&gt;To use our EU server for transcription, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// &lt;Tip&gt;Building a load test or submitting a large batch? [See our guide →](/pre-recorded-audio/guides/bulk-transcription-and-load-tests-at-scale)&lt;/Tip&gt;<br/>
        /// Create a transcript from a media file that is accessible via a URL.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Transcript> SubmitAsync(
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}