
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Enable domain-specific transcription models to improve accuracy for specialized terminology. Set to `"medical-v1"` to enable [Medical Mode](https://www.assemblyai.com/docs/pre-recorded-audio/medical-mode) for improved accuracy of medical terms such as medications, procedures, conditions, and dosages.<br/>
    /// Supported languages: English (`en`), Spanish (`es`), German (`de`), French (`fr`). If `medical-v1` is used with an unsupported language, the parameter is ignored and a warning is returned.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum TranscriptOptionalParamsDomain
    {
        /// <summary>
        /// //www.assemblyai.com/docs/pre-recorded-audio/medical-mode) for improved accuracy of medical terms such as medications, procedures, conditions, and dosages.
        /// </summary>
        MedicalV1,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptOptionalParamsDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptOptionalParamsDomain value)
        {
            return value switch
            {
                TranscriptOptionalParamsDomain.MedicalV1 => "medical-v1",
                TranscriptOptionalParamsDomain.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptOptionalParamsDomain? ToEnum(string value)
        {
            return value switch
            {
                "medical-v1" => TranscriptOptionalParamsDomain.MedicalV1,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => TranscriptOptionalParamsDomain.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}