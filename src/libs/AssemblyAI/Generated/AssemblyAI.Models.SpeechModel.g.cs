
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Speech model
    /// </summary>
    public enum SpeechModel
    {
        /// <summary>
        ///
        /// </summary>
        AssemblyaiStt37,
        /// <summary>
        ///
        /// </summary>
        Universal2,
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
                SpeechModel.AssemblyaiStt37 => "assemblyai-stt-3-7",
                SpeechModel.Universal2 => "universal-2",
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
                "assemblyai-stt-3-7" => SpeechModel.AssemblyaiStt37,
                "universal-2" => SpeechModel.Universal2,
                _ => null,
            };
        }
    }
}