namespace AssemblyAI;

public sealed partial class AssemblyAIClient
{
    /// <summary>
    /// Gets the file-upload API surface using the client's configured authorization.
    /// </summary>
    public SubpackageFilesClient Files => SubpackageFiles;

    /// <summary>
    /// Gets the transcript API surface using the client's configured authorization.
    /// </summary>
    public SubpackageTranscriptsClient Transcripts => SubpackageTranscripts;
}
