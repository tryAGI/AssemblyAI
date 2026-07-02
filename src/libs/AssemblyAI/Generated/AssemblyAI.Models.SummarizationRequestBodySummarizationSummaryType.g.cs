
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Type of summary. Bullets returns short bullet point style summaries, paragraph is generally more verbose and detailed.
    /// </summary>
    public enum SummarizationRequestBodySummarizationSummaryType
    {
        /// <summary>
        /// 
        /// </summary>
        Bullets,
        /// <summary>
        /// 
        /// </summary>
        Paragraph,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizationRequestBodySummarizationSummaryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizationRequestBodySummarizationSummaryType value)
        {
            return value switch
            {
                SummarizationRequestBodySummarizationSummaryType.Bullets => "bullets",
                SummarizationRequestBodySummarizationSummaryType.Paragraph => "paragraph",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizationRequestBodySummarizationSummaryType? ToEnum(string value)
        {
            return value switch
            {
                "bullets" => SummarizationRequestBodySummarizationSummaryType.Bullets,
                "paragraph" => SummarizationRequestBodySummarizationSummaryType.Paragraph,
                _ => null,
            };
        }
    }
}