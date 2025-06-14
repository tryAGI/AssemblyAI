#nullable enable

namespace AssemblyAI
{
    public partial interface ILeMURClient
    {
        /// <summary>
        /// Ask questions using LeMUR<br/>
        /// &lt;Note&gt;To use our EU server with LeMUR, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Question &amp; Answer allows you to ask free-form questions about a single transcript or a group of transcripts.<br/>
        /// The questions can be any whose answers you find useful, such as judging whether a caller is likely to become a customer or whether all items on a meeting's agenda were covered.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.LemurQuestionAnswerResponse> LemurQuestionAnswerAsync(
            global::AssemblyAI.LemurQuestionAnswerParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Ask questions using LeMUR<br/>
        /// &lt;Note&gt;To use our EU server with LeMUR, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Question &amp; Answer allows you to ask free-form questions about a single transcript or a group of transcripts.<br/>
        /// The questions can be any whose answers you find useful, such as judging whether a caller is likely to become a customer or whether all items on a meeting's agenda were covered.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.LemurQuestionAnswerResponse> LemurQuestionAnswerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}