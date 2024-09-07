
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::OpenApiGenerator.JsonConverters.TranscriptReadyStatusJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TranscriptReadyStatusNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RedactedAudioStatusJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RedactedAudioStatusNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SubtitleFormatJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SubtitleFormatNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TranscriptLanguageCodeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TranscriptLanguageCodeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SpeechModel2JsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SpeechModel2NullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TranscriptBoostParamJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TranscriptBoostParamNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RedactPiiAudioQualityJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RedactPiiAudioQualityNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.PiiPolicyJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.PiiPolicyNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SubstitutionPolicyJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SubstitutionPolicyNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SummaryModelJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SummaryModelNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SummaryTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SummaryTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TranscriptStatusJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TranscriptStatusNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AudioIntelligenceModelStatusJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.AudioIntelligenceModelStatusNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SentimentJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.SentimentNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.EntityTypeJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.EntityTypeNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurModelJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurModelNullableJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.TranscriptWebhookNotificationJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.RedactedAudioNotificationJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2),
            typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::OpenApiGenerator.JsonConverters.TranscriptParamsJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurStringResponseJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurTaskResponseJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurSummaryResponseJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurActionItemsResponseJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurQuestionAnswerResponseJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurResponseJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurTaskParamsJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurSummaryParamsJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurQuestionAnswerParamsJsonConverter),
            typeof(global::OpenApiGenerator.JsonConverters.LemurActionItemsParamsJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}