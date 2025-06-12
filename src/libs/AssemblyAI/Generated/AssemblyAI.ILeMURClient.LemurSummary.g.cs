#nullable enable

namespace AssemblyAI
{
    public partial interface ILeMURClient
    {
        /// <summary>
        /// Summarize a transcript using LeMUR<br/>
        /// &lt;Note&gt;To use our EU server with LeMUR, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Custom Summary allows you to distill a piece of audio into a few impactful sentences.<br/>
        /// You can give the model context to obtain more targeted results while outputting the results in a variety of formats described in human language.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.LemurSummaryResponse> LemurSummaryAsync(
            global::AssemblyAI.LemurSummaryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Summarize a transcript using LeMUR<br/>
        /// &lt;Note&gt;To use our EU server with LeMUR, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Custom Summary allows you to distill a piece of audio into a few impactful sentences.<br/>
        /// You can give the model context to obtain more targeted results while outputting the results in a variety of formats described in human language.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.LemurSummaryResponse> LemurSummaryAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}