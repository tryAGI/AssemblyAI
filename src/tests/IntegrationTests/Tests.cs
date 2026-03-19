namespace AssemblyAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AssemblyAIClient GetAuthenticatedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ASSEMBLYAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ASSEMBLYAI_API_KEY environment variable is not found.");

        var api = new AssemblyAIClient(apiKey);
        
        return api;
    }
}
