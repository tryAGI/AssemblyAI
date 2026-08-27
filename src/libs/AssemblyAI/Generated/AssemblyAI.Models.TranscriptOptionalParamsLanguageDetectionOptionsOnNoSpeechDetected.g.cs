
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Controls what happens when no speech is detected in the audio. With `error` (the default), the transcript fails and the reason is returned in `error`. With `fallback`, the transcript completes with an empty `text`, `language_code` is set to the `fallback_language`, and an explanatory warning is returned in `metadata.warnings`.<br/>
    /// `fallback` requires `fallback_language` to be set to a specific language code; `auto` returns a `400`. See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.<br/>
    /// Default Value: error
    /// </summary>
    public enum TranscriptOptionalParamsLanguageDetectionOptionsOnNoSpeechDetected
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// //www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.
        /// </summary>
        Fallback,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptOptionalParamsLanguageDetectionOptionsOnNoSpeechDetectedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptOptionalParamsLanguageDetectionOptionsOnNoSpeechDetected value)
        {
            return value switch
            {
                TranscriptOptionalParamsLanguageDetectionOptionsOnNoSpeechDetected.Error => "error",
                TranscriptOptionalParamsLanguageDetectionOptionsOnNoSpeechDetected.Fallback => "fallback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptOptionalParamsLanguageDetectionOptionsOnNoSpeechDetected? ToEnum(string value)
        {
            return value switch
            {
                "error" => TranscriptOptionalParamsLanguageDetectionOptionsOnNoSpeechDetected.Error,
                "fallback" => TranscriptOptionalParamsLanguageDetectionOptionsOnNoSpeechDetected.Fallback,
                _ => null,
            };
        }
    }
}