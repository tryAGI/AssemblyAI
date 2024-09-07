using System.Diagnostics.CodeAnalysis;

namespace AssemblyAI;

public partial struct LemurTaskParams
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="prompt"></param>
    /// <returns></returns>
    [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates",
        Justification = "Named alternative is provided.")]
    public static implicit operator LemurTaskParams(string prompt)
    {
        return FromPrompt(prompt);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="prompt"></param>
    /// <param name="params"></param>
    /// <returns></returns>
    public static LemurTaskParams FromPrompt(
        string prompt,
        LemurBaseParams? @params = null)
    {
        return new LemurTaskParams(
            value1: LemurTaskParamsVariant1.FromPrompt(prompt),
            value2: @params ?? new LemurBaseParams());
    }
}