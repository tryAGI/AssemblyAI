#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Get sentences in transcript<br/>
        /// &lt;Note&gt;To retrieve your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Get the transcript split by sentences. The API will attempt to semantically segment the transcript into sentences to create more reader-friendly transcripts.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.SentencesResponse> GetTranscriptSentencesAsync(
            string transcriptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}