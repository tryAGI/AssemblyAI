#nullable enable

namespace AssemblyAI
{
    public partial interface ILeMURClient
    {
        /// <summary>
        /// Retrieve LeMUR response<br/>
        /// Retrieve a LeMUR response that was previously generated.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.LemurResponse> GetLemurResponseAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}