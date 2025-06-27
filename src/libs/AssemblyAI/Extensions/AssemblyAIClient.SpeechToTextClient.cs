#nullable enable
using Microsoft.Extensions.AI;
using System.Runtime.CompilerServices;

namespace AssemblyAI;

public sealed partial class AssemblyAIClient : ISpeechToTextClient
{
    private SpeechToTextClientMetadata? _metadata;

    object? ISpeechToTextClient.GetService(Type serviceType, object? serviceKey) =>
        serviceType is null ? throw new ArgumentNullException(nameof(serviceType)) :
        serviceKey is not null ? null :
        serviceType == typeof(SpeechToTextClientMetadata) ? (_metadata ??= new("assemblyai", new Uri(DefaultBaseUrl))) :
        serviceType.IsInstanceOfType(this) ? this :
        null;

    /// <inheritdoc />
    async Task<SpeechToTextResponse> ISpeechToTextClient.GetTextAsync(Stream audioSpeechStream, SpeechToTextOptions? options, CancellationToken cancellationToken)
    {
        TranscriptParams? transcriptParams = options?.RawRepresentationFactory?.Invoke(this) is TranscriptParams tmp ? (TranscriptParams?)tmp : null;
        TranscriptOptionalParams optionalParams = transcriptParams?.Value2 ?? new();
        optionalParams.LanguageCode ??= options?.SpeechLanguage;
        optionalParams.SpeechModel ??= options?.ModelId;

        string? audioUrl = transcriptParams?.Value1?.AudioUrl;
        if (audioUrl is null)
        {
            MemoryStream ms = new();
            await audioSpeechStream.CopyToAsync(ms, 81920, cancellationToken).ConfigureAwait(false);
            byte[] bytes = ms.ToArray();

            UploadedFile upload = await Transcript.UploadFileAsync(bytes, cancellationToken).ConfigureAwait(false);
            audioUrl = upload.UploadUrl;
        }

        Transcript transcript = await Transcript.CreateTranscriptAsync(
            TranscriptParams.FromUrl(audioUrl, optionalParams),
            cancellationToken).ConfigureAwait(false);

        string id = transcript.Id.ToString();
        while (transcript.Status is TranscriptStatus.Queued or TranscriptStatus.Processing)
        {
            await Task.Delay(500, cancellationToken).ConfigureAwait(false);
            transcript = await Transcript.GetTranscriptAsync(id, cancellationToken).ConfigureAwait(false);
        }

        if (transcript.Status is TranscriptStatus.Error)
        {
            throw new InvalidOperationException(transcript.Error);
        }

        return new(transcript.Text)
        {
            EndTime = transcript.AudioEndAt is int audioEndAt ? TimeSpan.FromMilliseconds(audioEndAt) : null,
            ModelId = transcript.LanguageModel,
            RawRepresentation = transcript,
            ResponseId = id,
            StartTime = transcript.AudioStartFrom is int audioStartFrom ? TimeSpan.FromMilliseconds(audioStartFrom) : null,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<SpeechToTextResponseUpdate> ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream, SpeechToTextOptions? options, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var response = await ((ISpeechToTextClient)this).GetTextAsync(audioSpeechStream, options, cancellationToken).ConfigureAwait(false);
        foreach (var update in response.ToSpeechToTextResponseUpdates())
        {
            yield return update;
        }
    }
}