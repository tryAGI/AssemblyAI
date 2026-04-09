using System.Diagnostics.CodeAnalysis;

namespace AssemblyAI;

public sealed partial class TranscriptParams
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates",
        Justification = "Named alternative is provided.")]
    public static implicit operator TranscriptParams(string content)
    {
        return FromUrl(content);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static implicit operator TranscriptParams(Uri uri)
    {
        return FromUri(uri);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="url"></param>
    /// <param name="params"></param>
    /// <returns></returns>
    public static TranscriptParams FromUrl(
        [SuppressMessage("Design", "CA1054:URI-like parameters should not be strings")]
        string url,
        TranscriptParams? @params = null)
    {
        ArgumentNullException.ThrowIfNull(url);

        TranscriptParams transcriptParams = @params ?? new TranscriptParams
        {
            AudioUrl = url,
            SpeechModels = [],
        };
        transcriptParams.AudioUrl = url;
        transcriptParams.SpeechModels ??= [];

        return transcriptParams;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <param name="params"></param>
    /// <returns></returns>
    public static TranscriptParams FromUri(Uri uri, TranscriptParams? @params = null)
    {
        ArgumentNullException.ThrowIfNull(uri);

        return FromUrl(uri.ToString(), @params);
    }
}
