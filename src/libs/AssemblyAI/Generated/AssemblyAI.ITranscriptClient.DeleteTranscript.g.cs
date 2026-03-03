#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Delete transcript<br/>
        /// &lt;Note&gt;To delete your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Remove the data from the transcript and mark it as deleted.<br/>
        /// &lt;Warning&gt;Files uploaded via the `/upload` endpoint are immediately deleted alongside the transcript when you make a DELETE request, ensuring your data is removed from our systems right away.&lt;/Warning&gt;
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Transcript> DeleteTranscriptAsync(
            string transcriptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}