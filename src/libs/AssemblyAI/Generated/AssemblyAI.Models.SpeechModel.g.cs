
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The speech model to use for the transcription.
    /// </summary>
    public enum SpeechModel
    {
        /// <summary>
        /// 
        /// </summary>
        Best,
        /// <summary>
        /// 
        /// </summary>
        Slam1,
        /// <summary>
        /// 
        /// </summary>
        Universal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechModel value)
        {
            return value switch
            {
                SpeechModel.Best => "best",
                SpeechModel.Slam1 => "slam-1",
                SpeechModel.Universal => "universal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechModel? ToEnum(string value)
        {
            return value switch
            {
                "best" => SpeechModel.Best,
                "slam-1" => SpeechModel.Slam1,
                "universal" => SpeechModel.Universal,
                _ => null,
            };
        }
    }
}