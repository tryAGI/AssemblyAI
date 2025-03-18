#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// List transcripts<br/>
        /// &lt;Note&gt;To retrieve your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Retrieve a list of transcripts you created. <br/>
        /// Transcripts are sorted from newest to oldest and can be retrieved for the last 90 days of usage. The previous URL always points to a page with older transcripts.<br/>
        /// If you need to retrieve transcripts from more than 90 days ago please reach out to our Support team at support@assemblyai.com.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="createdOn"></param>
        /// <param name="beforeId"></param>
        /// <param name="afterId"></param>
        /// <param name="throttledOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.TranscriptList> ListTranscriptsAsync(
            int? limit = default,
            global::AssemblyAI.TranscriptStatus? status = default,
            global::System.DateTime? createdOn = default,
            global::System.Guid? beforeId = default,
            global::System.Guid? afterId = default,
            bool? throttledOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}