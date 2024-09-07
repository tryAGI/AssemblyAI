using System.Diagnostics.CodeAnalysis;

namespace AssemblyAI;

public partial class LemurTaskParamsVariant1
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="prompt"></param>
    /// <returns></returns>
    [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates",
        Justification = "Named alternative is provided.")]
    public static implicit operator LemurTaskParamsVariant1(string prompt)
    {
        return FromPrompt(prompt);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="prompt"></param>
    /// <returns></returns>
    public static LemurTaskParamsVariant1 FromPrompt(string prompt)
    {
        return new LemurTaskParamsVariant1
            {
                Prompt = prompt,
            };
    }
}