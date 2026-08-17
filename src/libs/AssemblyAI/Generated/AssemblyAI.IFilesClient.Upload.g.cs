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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// from assemblyai.prerecorded.v2 import Transcriber<br/>
        /// transcriber = Transcriber(api_key=os.environ["ASSEMBLYAI_API_KEY"])<br/>
        /// upload_url = transcriber.upload_file("./audio.mp3")<br/>
        /// print(upload_url)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::AssemblyAI.UploadedFile> UploadAsync(

            byte[] request,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a media file<br/>
        /// Upload a media file to AssemblyAI's servers.<br/>
        /// &lt;Note&gt;To upload a media file to our EU server, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// &lt;Warning&gt;Requests to transcribe uploaded files must use an API key from the same project as the key that was used to upload the file. If you use an API key from a different project you will get a `403` error and "Cannot access uploaded file" message.&lt;/Warning&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        /// <remarks>
        /// import os<br/>
        /// from assemblyai.prerecorded.v2 import Transcriber<br/>
        /// transcriber = Transcriber(api_key=os.environ["ASSEMBLYAI_API_KEY"])<br/>
        /// upload_url = transcriber.upload_file("./audio.mp3")<br/>
        /// print(upload_url)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::AssemblyAI.AutoSDKHttpResponse<global::AssemblyAI.UploadedFile>> UploadAsResponseAsync(

            byte[] request,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}