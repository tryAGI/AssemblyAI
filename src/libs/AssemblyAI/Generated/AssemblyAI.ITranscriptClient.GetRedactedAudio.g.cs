#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Get redacted audio<br/>
        /// &lt;Note&gt;To retrieve the redacted audio on the EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com` in the `GET` request above.&lt;/Note&gt;<br/>
        /// Retrieve the redacted audio object containing the status and URL to the redacted audio.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.RedactedAudioResponse> GetRedactedAudioAsync(
            string transcriptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}