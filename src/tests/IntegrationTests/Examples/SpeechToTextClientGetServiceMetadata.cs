/*
order: 40
title: Speech To Text Client Get Service Metadata
slug: speech-to-text-client-get-service-metadata
*/

using Microsoft.Extensions.AI;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextClient_GetService_Metadata()
    {
        using var client = new AssemblyAIClient("dummy-key");
        ISpeechToTextClient speechClient = client;

        //// Retrieve metadata about the speech-to-text provider.
        var metadata = speechClient.GetService<SpeechToTextClientMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("assemblyai");
        metadata.ProviderUri.Should().NotBeNull();
    }
}
