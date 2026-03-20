/*
order: 50
title: Speech To Text Client Get Service Self
slug: speech-to-text-client-get-service-self
*/

using Microsoft.Extensions.AI;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextClient_GetService_Self()
    {
        using var client = new AssemblyAIClient("dummy-key");
        ISpeechToTextClient speechClient = client;

        //// Access the underlying AssemblyAIClient from the MEAI interface.
        var self = speechClient.GetService<AssemblyAIClient>();

        self.Should().NotBeNull();
        self.Should().BeSameAs(client);
    }
}
