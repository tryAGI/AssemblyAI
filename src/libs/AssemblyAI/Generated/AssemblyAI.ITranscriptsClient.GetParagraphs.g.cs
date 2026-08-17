#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptsClient
    {
        /// <summary>
        /// Get paragraphs in transcript<br/>
        /// &lt;Note&gt;To retrieve your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Get the transcript split by paragraphs. The API will attempt to semantically segment your transcript into paragraphs to create more reader-friendly transcripts.
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
        /// paragraphs = transcript.get_paragraphs()<br/>
        /// print(len(paragraphs), paragraphs[0].text)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::AssemblyAI.ParagraphsResponse> GetParagraphsAsync(
            string transcriptId,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get paragraphs in transcript<br/>
        /// &lt;Note&gt;To retrieve your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Get the transcript split by paragraphs. The API will attempt to semantically segment your transcript into paragraphs to create more reader-friendly transcripts.
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
        /// paragraphs = transcript.get_paragraphs()<br/>
        /// print(len(paragraphs), paragraphs[0].text)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::AssemblyAI.AutoSDKHttpResponse<global::AssemblyAI.ParagraphsResponse>> GetParagraphsAsResponseAsync(
            string transcriptId,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}