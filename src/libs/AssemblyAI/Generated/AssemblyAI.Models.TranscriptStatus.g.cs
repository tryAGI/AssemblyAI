
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The status of your transcript. Possible values are queued, processing, completed, or error.
    /// </summary>
    public enum TranscriptStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptStatus value)
        {
            return value switch
            {
                TranscriptStatus.Completed => "completed",
                TranscriptStatus.Error => "error",
                TranscriptStatus.Processing => "processing",
                TranscriptStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TranscriptStatus.Completed,
                "error" => TranscriptStatus.Error,
                "processing" => TranscriptStatus.Processing,
                "queued" => TranscriptStatus.Queued,
                _ => null,
            };
        }
    }
}