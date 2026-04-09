#nullable enable

namespace AssemblyAI
{
    public partial interface ISubpackageTranscriptsClient
    {
        /// <summary>
        /// Search words in transcript<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// &lt;Note&gt;To search through a transcription created on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Search through the transcript for keywords. You can search for individual words, numbers, or phrases containing up to five words or numbers.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="words"></param>
        /// <param name="authorization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.WordSearchResponse> WordSearchAsync(
            string transcriptId,
            global::System.Collections.Generic.IList<string> words,
            string authorization,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}