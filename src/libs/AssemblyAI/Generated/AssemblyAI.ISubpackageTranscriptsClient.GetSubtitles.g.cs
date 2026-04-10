#nullable enable

namespace AssemblyAI
{
    public partial interface ISubpackageTranscriptsClient
    {
        /// <summary>
        /// Get subtitles for transcript<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// &lt;Note&gt;To retrieve your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Export your transcript in SRT or VTT format to use with a video player for subtitles and closed captions.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="subtitleFormat">
        /// Format of the subtitles
        /// </param>
        /// <param name="charsPerCaption"></param>
        /// <param name="authorization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSubtitlesAsync(
            string transcriptId,
            global::AssemblyAI.SubtitleFormat subtitleFormat,
            string authorization,
            int? charsPerCaption = default,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}