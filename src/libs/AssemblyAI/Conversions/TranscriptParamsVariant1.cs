using System.Diagnostics.CodeAnalysis;

namespace AssemblyAI;

public partial class TranscriptParamsVariant1
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates",
        Justification = "Named alternative is provided.")]
    public static implicit operator TranscriptParamsVariant1(string content)
    {
        return FromUrl(content);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static implicit operator TranscriptParamsVariant1(Uri uri)
    {
        return FromUri(uri);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static TranscriptParamsVariant1 FromUrl(string content)
    {
        return new TranscriptParamsVariant1
            {
                AudioUrl = content,
            };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    public static TranscriptParamsVariant1 FromUri(Uri uri)
    {
        uri = uri ?? throw new ArgumentNullException(nameof(uri));
        
        return FromUrl(uri.ToString());
    }
}