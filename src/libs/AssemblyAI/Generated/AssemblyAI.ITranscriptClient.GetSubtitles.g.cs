#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Get subtitles for transcript<br/>
        /// &lt;Note&gt;To retrieve your transcriptions on our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Export your transcript in SRT or VTT format to use with a video player for subtitles and closed captions.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="subtitleFormat">
        /// Format of the subtitles
        /// </param>
        /// <param name="charsPerCaption"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSubtitlesAsync(
            string transcriptId,
            global::AssemblyAI.SubtitleFormat subtitleFormat,
            int? charsPerCaption = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}