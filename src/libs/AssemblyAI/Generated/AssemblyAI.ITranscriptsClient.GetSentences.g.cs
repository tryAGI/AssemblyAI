#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptsClient
    {
        /// <summary>
        /// Get sentences in transcript<br/>
        /// &lt;Note&gt;To retrieve your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Get the transcript split by sentences. The API will attempt to semantically segment the transcript into sentences to create more reader-friendly transcripts.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// import assemblyai<br/>
        /// from assemblyai.prerecorded.v2 import Transcript<br/>
        /// # `Transcript.get_by_id()` uses the default client, which reads the global settings.<br/>
        /// assemblyai.settings.api_key = os.environ["ASSEMBLYAI_API_KEY"]<br/>
        /// transcript = Transcript.get_by_id("&lt;TRANSCRIPT_ID&gt;")<br/>
        /// sentences = transcript.get_sentences()<br/>
        /// print(len(sentences), sentences[0].text)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::AssemblyAI.SentencesResponse> GetSentencesAsync(
            string transcriptId,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get sentences in transcript<br/>
        /// &lt;Note&gt;To retrieve your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Get the transcript split by sentences. The API will attempt to semantically segment the transcript into sentences to create more reader-friendly transcripts.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// import assemblyai<br/>
        /// from assemblyai.prerecorded.v2 import Transcript<br/>
        /// # `Transcript.get_by_id()` uses the default client, which reads the global settings.<br/>
        /// assemblyai.settings.api_key = os.environ["ASSEMBLYAI_API_KEY"]<br/>
        /// transcript = Transcript.get_by_id("&lt;TRANSCRIPT_ID&gt;")<br/>
        /// sentences = transcript.get_sentences()<br/>
        /// print(len(sentences), sentences[0].text)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::AssemblyAI.AutoSDKHttpResponse<global::AssemblyAI.SentencesResponse>> GetSentencesAsResponseAsync(
            string transcriptId,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}