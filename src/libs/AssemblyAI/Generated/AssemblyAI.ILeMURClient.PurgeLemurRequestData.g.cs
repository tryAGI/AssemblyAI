#nullable enable

namespace AssemblyAI
{
    public partial interface ILeMURClient
    {
        /// <summary>
        /// Purge LeMUR request data<br/>
        /// Delete the data for a previously submitted LeMUR request.<br/>
        /// The LLM response data, as well as any context provided in the original request will be removed.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.PurgeLemurRequestDataResponse> PurgeLemurRequestDataAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}