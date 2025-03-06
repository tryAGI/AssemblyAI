#nullable enable

namespace AssemblyAI
{
    public partial interface ILeMURClient
    {
        /// <summary>
        /// Retrieve LeMUR response<br/>
        /// &lt;Warning&gt;LeMUR is currently not available on the EU endpoint.&lt;/Warning&gt;<br/>
        /// Retrieve a LeMUR response that was previously generated.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.LemurResponse> GetLemurResponseAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}