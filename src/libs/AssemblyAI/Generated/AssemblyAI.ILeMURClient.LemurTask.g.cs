#nullable enable

namespace AssemblyAI
{
    public partial interface ILeMURClient
    {
        /// <summary>
        /// Run a task using LeMUR<br/>
        /// Use the LeMUR task endpoint to input your own LLM prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.LemurTaskResponse> LemurTaskAsync(
            global::AssemblyAI.LemurTaskParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Run a task using LeMUR<br/>
        /// Use the LeMUR task endpoint to input your own LLM prompt.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.LemurTaskResponse> LemurTaskAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}