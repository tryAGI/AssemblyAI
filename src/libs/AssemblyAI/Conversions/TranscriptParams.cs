using System.Diagnostics.CodeAnalysis;

namespace AssemblyAI;

public partial struct TranscriptParams
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
        TranscriptOptionalParams? @params = null)
    {
        return new TranscriptParams(
            value1: TranscriptParamsVariant1.FromUrl(url),
            value2: @params ?? new TranscriptOptionalParams());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <param name="params"></param>
    /// <returns></returns>
    public static TranscriptParams FromUri(Uri uri, TranscriptOptionalParams? @params = null)
    {
        uri = uri ?? throw new ArgumentNullException(nameof(uri));
        
        return FromUrl(uri.ToString(), @params);
    }
}