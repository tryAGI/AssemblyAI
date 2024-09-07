namespace AssemblyAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public AssemblyAIClient GetAuthenticatedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ASSEMBLYAI_API_KEY") ??
            throw new AssertInconclusiveException("ASSEMBLYAI_API_KEY environment variable is not found.");

        var api = new AssemblyAIClient(apiKey);
        
        return api;
    }
}
