#nullable enable

namespace AssemblyAI
{
    public partial interface ISubpackageStreamingApiClient
    {
        /// <summary>
        /// Generate temporary streaming token<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// Generates a temporary authentication token for use with streaming services. See [Authenticate with a temporary token](https://www.assemblyai.com/docs/streaming/authenticate-with-a-temporary-token) for more details.
        /// </summary>
        /// <param name="expiresInSeconds"></param>
        /// <param name="maxSessionDurationSeconds">
        /// Default Value: 10800
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.StreamingAPIGenerateStreamingTokenResponse200> GenerateStreamingTokenAsync(
            int expiresInSeconds,
            int? maxSessionDurationSeconds = default,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate temporary streaming token<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// Generates a temporary authentication token for use with streaming services. See [Authenticate with a temporary token](https://www.assemblyai.com/docs/streaming/authenticate-with-a-temporary-token) for more details.
        /// </summary>
        /// <param name="expiresInSeconds"></param>
        /// <param name="maxSessionDurationSeconds">
        /// Default Value: 10800
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.AutoSDKHttpResponse<global::AssemblyAI.StreamingAPIGenerateStreamingTokenResponse200>> GenerateStreamingTokenAsResponseAsync(
            int expiresInSeconds,
            int? maxSessionDurationSeconds = default,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}