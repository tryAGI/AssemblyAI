#nullable enable

namespace AssemblyAI
{
    public partial interface ISubpackageTranscriptsClient
    {
        /// <summary>
        /// List transcripts<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// &lt;Note&gt;To retrieve your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Retrieve a list of transcripts you created.<br/>
        /// Transcripts are sorted from newest to oldest and can be retrieved for the last 90 days of usage. The previous URL always points to a page with older transcripts.<br/>
        /// If you need to retrieve transcripts from more than 90 days ago please reach out to our Support team at support@assemblyai.com.<br/>
        /// **Pagination**<br/>
        /// This endpoint returns paginated results. The response includes a `page_details` object with the following properties:<br/>
        /// - `page_details.limit` - Maximum number of transcripts per page.<br/>
        /// - `page_details.result_count` - Total number of transcripts returned on the current page.<br/>
        /// - `page_details.current_url` - URL to the current page.<br/>
        /// - `page_details.prev_url` - URL to the previous page of older transcripts.<br/>
        /// - `page_details.next_url` - URL to the next page of newer transcripts.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="createdOn"></param>
        /// <param name="beforeId"></param>
        /// <param name="afterId"></param>
        /// <param name="throttledOnly">
        /// Default Value: false
        /// </param>
        /// <param name="authorization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.TranscriptList> ListAsync(
            string authorization,
            int? limit = default,
            global::AssemblyAI.TranscriptStatus? status = default,
            global::System.DateTime? createdOn = default,
            global::System.Guid? beforeId = default,
            global::System.Guid? afterId = default,
            bool? throttledOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}