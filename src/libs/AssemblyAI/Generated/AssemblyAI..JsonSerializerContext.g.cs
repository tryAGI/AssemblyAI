
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
            typeof(global::AssemblyAI.JsonConverters.AudioIntelligenceModelStatusJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.AudioIntelligenceModelStatusNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.EntityTypeJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.EntityTypeNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.ErrorStatusJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.ErrorStatusNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurModelJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurModelNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.TranscriptStatusJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.TranscriptStatusNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.PiiPolicyJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.PiiPolicyNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.RedactPiiAudioQualityJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.RedactPiiAudioQualityNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.RedactedAudioStatusJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.RedactedAudioStatusNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SentimentJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SentimentNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SpeechModelJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SpeechModelNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SubstitutionPolicyJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SubstitutionPolicyNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SubtitleFormatJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SubtitleFormatNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SummaryModelJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SummaryModelNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SummaryTypeJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.SummaryTypeNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.TranscriptLanguageCodeJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.TranscriptLanguageCodeNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.TranscriptBoostParamJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.TranscriptBoostParamNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.TranscriptReadyStatusJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.TranscriptReadyStatusNullableJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurActionItemsParamsJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurActionItemsResponseJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurStringResponseJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurQuestionAnswerParamsJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurQuestionAnswerResponseJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurResponseJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurSummaryParamsJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurSummaryResponseJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurTaskParamsJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.LemurTaskResponseJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.RedactedAudioNotificationJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.TranscriptParamsJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.TranscriptWebhookNotificationJsonConverter),
            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>),
            typeof(global::AssemblyAI.JsonConverters.AnyOfJsonConverter<global::AssemblyAI.LemurModel?, string>),
            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>),
            typeof(global::AssemblyAI.JsonConverters.AnyOfJsonConverter<global::AssemblyAI.TranscriptLanguageCode?, string>),
            typeof(global::AssemblyAI.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}