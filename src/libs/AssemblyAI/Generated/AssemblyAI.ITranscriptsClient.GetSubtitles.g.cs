#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptsClient
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// import assemblyai<br/>
        /// from assemblyai.prerecorded.v2 import Transcript<br/>
        /// # `Transcript.get_by_id()` uses the default client, which reads the global settings.<br/>
        /// assemblyai.settings.api_key = os.environ["ASSEMBLYAI_API_KEY"]<br/>
        /// transcript = Transcript.get_by_id("&lt;TRANSCRIPT_ID&gt;")<br/>
        /// srt = transcript.export_subtitles_srt(chars_per_caption=32)<br/>
        /// # vtt = transcript.export_subtitles_vtt(chars_per_caption=32)<br/>
        /// print(srt)
        /// </remarks>
        global::System.Threading.Tasks.Task<string> GetSubtitlesAsync(
            string transcriptId,
            global::AssemblyAI.SubtitleFormat subtitleFormat,
            int? charsPerCaption = default,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// import assemblyai<br/>
        /// from assemblyai.prerecorded.v2 import Transcript<br/>
        /// # `Transcript.get_by_id()` uses the default client, which reads the global settings.<br/>
        /// assemblyai.settings.api_key = os.environ["ASSEMBLYAI_API_KEY"]<br/>
        /// transcript = Transcript.get_by_id("&lt;TRANSCRIPT_ID&gt;")<br/>
        /// srt = transcript.export_subtitles_srt(chars_per_caption=32)<br/>
        /// # vtt = transcript.export_subtitles_vtt(chars_per_caption=32)<br/>
        /// print(srt)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::AssemblyAI.AutoSDKHttpResponse<string>> GetSubtitlesAsResponseAsync(
            string transcriptId,
            global::AssemblyAI.SubtitleFormat subtitleFormat,
            int? charsPerCaption = default,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}