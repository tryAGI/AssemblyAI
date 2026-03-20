/*
order: 30
title: Speech To Text Client Get Text Async
slug: speech-to-text-client-get-text-async
*/

using Microsoft.Extensions.AI;

namespace AssemblyAI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SpeechToTextClient_GetTextAsync()
    {
        using var client = GetAuthenticatedApi();
        ISpeechToTextClient speechClient = client;

        //// Transcribe audio using the MEAI ISpeechToTextClient interface.
        //// The client uploads the audio stream and polls until transcription is complete.
        using var httpClient = new HttpClient();
        await using var audioStream = await httpClient.GetStreamAsync(
            "https://github.com/AssemblyAI-Community/audio-examples/raw/main/20230607_me_canadian_wildfires.mp3");

        var ms = new MemoryStream();
        await audioStream.CopyToAsync(ms);
        ms.Position = 0;

        var response = await speechClient.GetTextAsync(ms);

        Console.WriteLine($"Text: {response.Text}");

        response.Text.Should().NotBeNullOrEmpty();
        response.RawRepresentation.Should().NotBeNull();
    }
}
