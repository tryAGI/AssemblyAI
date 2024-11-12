#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Transcribe audio<br/>
        /// Create a transcript from a media file that is accessible via a URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Transcript> CreateTranscriptAsync(
            global::AssemblyAI.TranscriptParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Transcribe audio<br/>
        /// Create a transcript from a media file that is accessible via a URL.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Transcript> CreateTranscriptAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}