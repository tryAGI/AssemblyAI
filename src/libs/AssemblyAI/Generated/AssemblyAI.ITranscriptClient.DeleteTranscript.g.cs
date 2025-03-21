#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Delete transcript<br/>
        /// &lt;Note&gt;To delete your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Remove the data from the transcript and mark it as deleted.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Transcript> DeleteTranscriptAsync(
            string transcriptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}