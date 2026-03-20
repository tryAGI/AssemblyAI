#nullable enable

namespace AssemblyAI
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a media file<br/>
        /// Upload a media file to AssemblyAI's servers.<br/>
        /// &lt;Note&gt;To upload a media file to our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// &lt;Warning&gt;Requests to transcribe uploaded files must use an API key from the same project as the key that was used to upload the file. If you use an API key from a different project you will get a `403` error and "Cannot access uploaded file" message.&lt;/Warning&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.UploadedFile> UploadAsync(

            byte[] request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}