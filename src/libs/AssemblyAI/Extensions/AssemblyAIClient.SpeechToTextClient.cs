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
        TranscriptParams? transcriptParams = options?.RawRepresentationFactory?.Invoke(this) as TranscriptParams;

        if (transcriptParams?.LanguageCode is null &&
            options?.SpeechLanguage is { Length: > 0 } speechLanguage)
        {
            transcriptParams = TranscriptParams.FromUrl(
                transcriptParams?.AudioUrl ?? string.Empty,
                transcriptParams);
            transcriptParams.LanguageCode =
                TranscriptLanguageCodeExtensions.ToEnum(speechLanguage) ?? (object)speechLanguage;
        }

        if (transcriptParams is not null &&
            (transcriptParams.SpeechModels is null || transcriptParams.SpeechModels.Count == 0) &&
            options?.ModelId is { Length: > 0 } modelId)
        {
            transcriptParams.SpeechModels = [modelId];
        }

        string? audioUrl = transcriptParams?.AudioUrl;
        if (audioUrl is null)
        {
            MemoryStream ms = new();
            await audioSpeechStream.CopyToAsync(ms, 81920, cancellationToken).ConfigureAwait(false);
            byte[] bytes = ms.ToArray();

            UploadedFile upload = await Files.UploadAsync(bytes, cancellationToken).ConfigureAwait(false);
            audioUrl = upload.UploadUrl;
        }

        transcriptParams = TranscriptParams.FromUrl(audioUrl, transcriptParams);
        if (transcriptParams.SpeechModels.Count == 0 &&
            options?.ModelId is { Length: > 0 } uploadedModelId)
        {
            transcriptParams.SpeechModels = [uploadedModelId];
        }

        Transcript transcript = await Transcripts.SubmitAsync(
            transcriptParams,
            cancellationToken).ConfigureAwait(false);

        string id = transcript.Id.ToString();
        while (transcript.Status is TranscriptStatus.Queued or TranscriptStatus.Processing)
        {
            await Task.Delay(500, cancellationToken).ConfigureAwait(false);
            transcript = await Transcripts.GetAsync(id, cancellationToken).ConfigureAwait(false);
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
