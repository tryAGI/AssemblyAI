namespace AssemblyAI;

public partial class SubpackageTranscriptsClient
{
    /// <summary>
    /// Creates a transcript using the client's configured authorization.
    /// </summary>
    public Task<Transcript> SubmitAsync(
        TranscriptParams request,
        CancellationToken cancellationToken = default) =>
        SubmitAsync(Authorizations.GetAuthorizationValue(), request, cancellationToken);

    /// <summary>
    /// Retrieves a transcript using the client's configured authorization.
    /// </summary>
    public Task<Transcript> GetAsync(
        string transcriptId,
        CancellationToken cancellationToken = default) =>
        GetAsync(transcriptId, Authorizations.GetAuthorizationValue(), cancellationToken);
}
