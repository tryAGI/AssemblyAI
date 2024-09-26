#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Get transcript<br/>
        /// Get the transcript resource. The transcript is ready when the "status" is "completed".
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Transcript> GetTranscriptAsync(
            string transcriptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}