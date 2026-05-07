namespace AssemblyAI;

public partial class SubpackageFilesClient
{
    /// <summary>
    /// Uploads a media file using the client's configured authorization.
    /// </summary>
    public Task<UploadedFile> UploadAsync(
        byte[] request,
        CancellationToken cancellationToken = default) =>
        UploadAsync(
            authorization: Authorizations.GetAuthorizationValue(),
            request: request,
            cancellationToken: cancellationToken);
}
