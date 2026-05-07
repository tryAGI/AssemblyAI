namespace AssemblyAI;

public partial class SubpackageTranscriptsClient
{
    /// <summary>
    /// Creates a transcript using the client's configured authorization.
    /// </summary>
    public Task<Transcript> SubmitAsync(
        TranscriptParams request,
        CancellationToken cancellationToken = default) =>
        SubmitAsync(
            authorization: Authorizations.GetAuthorizationValue(),
            request: request,
            cancellationToken: cancellationToken);

    /// <summary>
    /// Retrieves a transcript using the client's configured authorization.
    /// </summary>
    public Task<Transcript> GetAsync(
        string transcriptId,
        CancellationToken cancellationToken = default) =>
        GetAsync(
            transcriptId: transcriptId,
            authorization: Authorizations.GetAuthorizationValue(),
            cancellationToken: cancellationToken);
}
