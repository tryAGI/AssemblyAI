#nullable enable

namespace AssemblyAI
{
    public partial interface IStreamingClient
    {
        /// <summary>
        /// Create temporary authentication token for Streaming STT<br/>
        /// &lt;Warning&gt;Streaming Speech-to-Text is currently not available on the EU endpoint.&lt;/Warning&gt;<br/>
        /// &lt;Note&gt;Any usage associated with a temporary token will be attributed to the API key that generated it.&lt;/Note&gt;<br/>
        /// Create a temporary authentication token for Streaming Speech-to-Text
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.RealtimeTemporaryTokenResponse> CreateTemporaryTokenAsync(
            global::AssemblyAI.CreateRealtimeTemporaryTokenParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create temporary authentication token for Streaming STT<br/>
        /// &lt;Warning&gt;Streaming Speech-to-Text is currently not available on the EU endpoint.&lt;/Warning&gt;<br/>
        /// &lt;Note&gt;Any usage associated with a temporary token will be attributed to the API key that generated it.&lt;/Note&gt;<br/>
        /// Create a temporary authentication token for Streaming Speech-to-Text
        /// </summary>
        /// <param name="expiresIn">
        /// The amount of time until the token expires in seconds
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.RealtimeTemporaryTokenResponse> CreateTemporaryTokenAsync(
            int expiresIn,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}