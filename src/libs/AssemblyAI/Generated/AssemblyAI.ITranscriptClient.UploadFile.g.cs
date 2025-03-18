#nullable enable

namespace AssemblyAI
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Upload a media file<br/>
        /// &lt;Note&gt;To upload a media file to our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// Upload a media file to AssemblyAI's servers.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.UploadedFile> UploadFileAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}