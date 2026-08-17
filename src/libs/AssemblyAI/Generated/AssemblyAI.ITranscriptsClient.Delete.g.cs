#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptsClient
    {
        /// <summary>
        /// Delete transcript<br/>
        /// &lt;Note&gt;To delete your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Remove the data from the transcript and mark it as deleted.<br/>
        /// &lt;Warning&gt;Files uploaded via the `/upload` endpoint are immediately deleted alongside the transcript when you make a DELETE request, ensuring your data is removed from our systems right away.&lt;/Warning&gt;
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// import assemblyai<br/>
        /// from assemblyai.prerecorded.v2 import Transcript<br/>
        /// # `Transcript.delete_by_id()` uses the default client, which reads the global settings.<br/>
        /// assemblyai.settings.api_key = os.environ["ASSEMBLYAI_API_KEY"]<br/>
        /// transcript = Transcript.delete_by_id("&lt;TRANSCRIPT_ID&gt;")<br/>
        /// print(transcript.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Transcript> DeleteAsync(
            string transcriptId,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete transcript<br/>
        /// &lt;Note&gt;To delete your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Remove the data from the transcript and mark it as deleted.<br/>
        /// &lt;Warning&gt;Files uploaded via the `/upload` endpoint are immediately deleted alongside the transcript when you make a DELETE request, ensuring your data is removed from our systems right away.&lt;/Warning&gt;
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// import assemblyai<br/>
        /// from assemblyai.prerecorded.v2 import Transcript<br/>
        /// # `Transcript.delete_by_id()` uses the default client, which reads the global settings.<br/>
        /// assemblyai.settings.api_key = os.environ["ASSEMBLYAI_API_KEY"]<br/>
        /// transcript = Transcript.delete_by_id("&lt;TRANSCRIPT_ID&gt;")<br/>
        /// print(transcript.status)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::AssemblyAI.AutoSDKHttpResponse<global::AssemblyAI.Transcript>> DeleteAsResponseAsync(
            string transcriptId,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}