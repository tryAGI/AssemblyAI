#nullable enable

namespace AssemblyAI
{
    public partial interface IAssemblyAIClient
    {
        /// <summary>
        /// Process speech understanding<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// &lt;Note&gt;To use our EU server for LLM Gateway, replace `llm-gateway.assemblyai.com` with `llm-gateway.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Perform various speech understanding tasks like [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting).
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.CreateSpeechUnderstandingResponse200> CreateSpeechUnderstandingAsync(
            string authorization,

            global::AssemblyAI.UnderstandingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Process speech understanding<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// &lt;Note&gt;To use our EU server for LLM Gateway, replace `llm-gateway.assemblyai.com` with `llm-gateway.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Perform various speech understanding tasks like [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting).
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="transcriptId">
        /// The ID of the transcript to process.
        /// </param>
        /// <param name="speechUnderstanding">
        /// The speech understanding task to perform. Supports [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). Click into the request object below to see the available options.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.CreateSpeechUnderstandingResponse200> CreateSpeechUnderstandingAsync(
            string authorization,
            string transcriptId,
            global::AssemblyAI.UnderstandingRequestSpeechUnderstanding speechUnderstanding,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}