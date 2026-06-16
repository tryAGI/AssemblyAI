using System.Diagnostics.CodeAnalysis;

namespace AssemblyAI;

public readonly partial struct TranscriptParams
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
    /// <param name="optionalParams"></param>
    /// <returns></returns>
    public static TranscriptParams FromUrl(
        [SuppressMessage("Design", "CA1054:URI-like parameters should not be strings")]
        string url,
        TranscriptOptionalParams? optionalParams = null)
    {
        ArgumentNullException.ThrowIfNull(url);

        optionalParams ??= new TranscriptOptionalParams();
        optionalParams.SpeechModels ??= [];

        return new TranscriptParams(
            new TranscriptParamsVariant1(url),
            optionalParams);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <param name="optionalParams"></param>
    /// <returns></returns>
    public static TranscriptParams FromUri(Uri uri, TranscriptOptionalParams? optionalParams = null)
    {
        ArgumentNullException.ThrowIfNull(uri);

        return FromUrl(uri.ToString(), optionalParams);
    }
}
