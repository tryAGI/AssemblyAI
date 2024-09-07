namespace AssemblyAI;

/// <summary>
/// 
/// </summary>
public static class TranscriptExtensions
{
    /// <summary>
    /// Ensures that the transcript status is completed.
    /// </summary>
    /// <param name="transcript"></param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public static void EnsureStatusCompleted(this Transcript transcript)
    {
        transcript = transcript ?? throw new ArgumentNullException(nameof(transcript));
        if (transcript.Status != TranscriptStatus.Completed)
        {
            throw new InvalidOperationException($"Transcript status is not completed: {transcript.Status}");
        }
    }
}