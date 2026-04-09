namespace AssemblyAI;

public sealed partial class AssemblyAIClient
{
    /// <summary>
    /// Creates a client that sends the provided API key in the <c>Authorization</c> header.
    /// </summary>
    public AssemblyAIClient(
        string apiKey,
        HttpClient? httpClient = null,
        Uri? baseUri = null,
        bool disposeHttpClient = true)
        : this(
            httpClient: httpClient,
            baseUri: baseUri,
            authorizations:
            [
                new EndPointAuthorization
                {
                    Type = "ApiKey",
                    Location = "Header",
                    Name = "Authorization",
                    Value = apiKey ?? throw new ArgumentNullException(nameof(apiKey)),
                },
            ],
            disposeHttpClient: disposeHttpClient)
    {
    }
}
