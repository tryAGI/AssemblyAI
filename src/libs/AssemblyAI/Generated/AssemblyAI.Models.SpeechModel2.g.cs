
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The speech model to use for the transcription. See [Model Selection](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model) for available models.
    /// </summary>
    public enum SpeechModel2
    {
        /// <summary>
        /// 
        /// </summary>
        Universal2,
        /// <summary>
        /// 
        /// </summary>
        Universal35Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechModel2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechModel2 value)
        {
            return value switch
            {
                SpeechModel2.Universal2 => "universal-2",
                SpeechModel2.Universal35Pro => "universal-3-5-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechModel2? ToEnum(string value)
        {
            return value switch
            {
                "universal-2" => SpeechModel2.Universal2,
                "universal-3-5-pro" => SpeechModel2.Universal35Pro,
                _ => null,
            };
        }
    }
}