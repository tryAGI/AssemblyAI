#nullable enable

namespace AssemblyAI
{
    public partial interface ISubpackageVoiceAgentApiClient
    {
        /// <summary>
        /// Generate temporary Voice Agent token<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// Generate a temporary authentication token for the Voice Agent API. Use this to<br/>
        /// connect browser or other client-side applications to the Voice Agent API without<br/>
        /// exposing your permanent API key. See<br/>
        /// [Browser integration](https://www.assemblyai.com/docs/voice-agents/voice-agent-api/browser-integration)<br/>
        /// for the full flow.<br/>
        /// Each token is one-time use and can only be used for a single session. All usage<br/>
        /// is attributed to the API key that generated the token.
        /// </summary>
        /// <param name="expiresInSeconds"></param>
        /// <param name="maxSessionDurationSeconds">
        /// Default Value: 10800
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.VoiceAgentAPIGenerateVoiceAgentTokenResponse200> GenerateVoiceAgentTokenAsync(
            int expiresInSeconds,
            int? maxSessionDurationSeconds = default,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}