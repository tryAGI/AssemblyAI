
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
            typeof(global::AssemblyAI.JsonConverters.RedactedAudioStatusJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.RedactedAudioStatusNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SubtitleFormatJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SubtitleFormatNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethodJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethodNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptOptionalParamsRemoveAudioTagsJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptOptionalParamsRemoveAudioTagsNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SummaryModelJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SummaryModelNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SummaryTypeJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SummaryTypeNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SubstitutionPolicyJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SubstitutionPolicyNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.RedactPiiAudioQualityJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.RedactPiiAudioQualityNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.PiiPolicyJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.PiiPolicyNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SpeechModel2JsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SpeechModel2NullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptLanguageCodeJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptLanguageCodeNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptStatusJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptStatusNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptReadyStatusJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptReadyStatusNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethodJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethodNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptRemoveAudioTagsJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptRemoveAudioTagsNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.EntityTypeJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.EntityTypeNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SentimentJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SentimentNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.AudioIntelligenceModelStatusJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.AudioIntelligenceModelStatusNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerTypeJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerTypeNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SummarizationRequestBodySummarizationSummaryTypeJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SummarizationRequestBodySummarizationSummaryTypeNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SummarizationRequestBodySummarizationEffortJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SummarizationRequestBodySummarizationEffortNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.ActionItemsRequestBodyActionItemsEffortJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.ActionItemsRequestBodyActionItemsEffortNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.RedactedAudioNotificationJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptParamsJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>),

            typeof(global::AssemblyAI.JsonConverters.AnyOfJsonConverter<global::AssemblyAI.TranscriptLanguageCode?, string>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.SubstitutionPolicy?, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody, global::AssemblyAI.SummarizationRequestBody, global::AssemblyAI.ActionItemsRequestBody>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.SpeechModel2?, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.AutoHighlightsResult2, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.ContentSafetyLabelsResult, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TopicDetectionModelResult, object>),

            typeof(global::AssemblyAI.JsonConverters.AnyOfJsonConverter<global::AssemblyAI.TranscriptLanguageCode?, string>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.RedactPiiAudioQuality?, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody, global::AssemblyAI.SummarizationRequestBody, global::AssemblyAI.ActionItemsRequestBody>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranslationResponse, global::AssemblyAI.SpeakerIdentificationResponse, global::AssemblyAI.CustomFormattingResponse, global::AssemblyAI.SummarizationResponse, global::AssemblyAI.ActionItemsResponse>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranscriptRemoveAudioTags?, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.SpeechModel2?, object>),

            typeof(global::AssemblyAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptReadyNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptReadyStatus), TypeInfoPropertyName = "TranscriptReadyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.RedactedAudioNotification), TypeInfoPropertyName = "RedactedAudioNotification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.RedactedAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.RedactedAudioStatus), TypeInfoPropertyName = "RedactedAudioStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SubtitleFormat), TypeInfoPropertyName = "SubtitleFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.WordSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.WordSearchMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.WordSearchMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Timestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptCustomSpelling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>), TypeInfoPropertyName = "OneOfAnyOfTranscriptLanguageCodeStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>), TypeInfoPropertyName = "AnyOfTranscriptLanguageCodeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptLanguageCode), TypeInfoPropertyName = "TranscriptLanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptLanguageCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsLanguageDetectionOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsRedactPiiAudioOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethod), TypeInfoPropertyName = "TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.RedactPiiAudioQuality), TypeInfoPropertyName = "RedactPiiAudioQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.PiiPolicy), TypeInfoPropertyName = "PiiPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.SubstitutionPolicy?, object>), TypeInfoPropertyName = "OneOfSubstitutionPolicyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SubstitutionPolicy), TypeInfoPropertyName = "SubstitutionPolicy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.SpeechModel2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeechModel2), TypeInfoPropertyName = "SpeechModel22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstanding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody, global::AssemblyAI.SummarizationRequestBody, global::AssemblyAI.ActionItemsRequestBody>), TypeInfoPropertyName = "ActionItemsRequestBody_96ae176b810c4f16")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranslationRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.CustomFormattingRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SummarizationRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ActionItemsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SummaryModel), TypeInfoPropertyName = "SummaryModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SummaryType), TypeInfoPropertyName = "SummaryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>), TypeInfoPropertyName = "OneOfTranscriptOptionalParamsRemoveAudioTagsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags), TypeInfoPropertyName = "TranscriptOptionalParamsRemoveAudioTags2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.SpeechModel2?, object>), TypeInfoPropertyName = "OneOfSpeechModel2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptParams), TypeInfoPropertyName = "TranscriptParams2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptParamsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptStatus), TypeInfoPropertyName = "TranscriptStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Transcript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.AutoHighlightsResult2, object>), TypeInfoPropertyName = "OneOfAutoHighlightsResult2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.AutoHighlightsResult2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Chapter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.ContentSafetyLabelsResult, object>), TypeInfoPropertyName = "OneOfContentSafetyLabelsResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ContentSafetyLabelsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Entity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TopicDetectionModelResult, object>), TypeInfoPropertyName = "OneOfTopicDetectionModelResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TopicDetectionModelResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptLanguageDetectionOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptRedactPiiAudioOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod), TypeInfoPropertyName = "TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.RedactPiiAudioQuality?, object>), TypeInfoPropertyName = "OneOfRedactPiiAudioQualityObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.SentimentAnalysisResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SentimentAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptSpeechUnderstanding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TranslationResponse, global::AssemblyAI.SpeakerIdentificationResponse, global::AssemblyAI.CustomFormattingResponse, global::AssemblyAI.SummarizationResponse, global::AssemblyAI.ActionItemsResponse>), TypeInfoPropertyName = "OneOfTranslationResponseSpeakerIdentificationResponseCustomFormattingResponseSummarizationResponseActionItemsResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranslationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.CustomFormattingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SummarizationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ActionItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptRemoveAudioTags?, object>), TypeInfoPropertyName = "OneOfTranscriptRemoveAudioTagsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptRemoveAudioTags), TypeInfoPropertyName = "TranscriptRemoveAudioTags2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptTranslatedTexts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.AudioIntelligenceModelStatus), TypeInfoPropertyName = "AudioIntelligenceModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TopicDetectionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ContentSafetyLabelResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::AssemblyAI.SeverityScoreSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SeverityScoreSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.EntityType), TypeInfoPropertyName = "EntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Sentiment), TypeInfoPropertyName = "Sentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResultLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TopicDetectionResultLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ContentSafetyLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.AutoHighlightResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.AutoHighlightResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.Timestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptSentence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SentencesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptSentence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptParagraph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ParagraphsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptParagraph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.PageDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.UploadedFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranslationRequestBodyTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType), TypeInfoPropertyName = "SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.CustomFormattingRequestBodyCustomFormatting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SummarizationRequestBodySummarization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SummarizationRequestBodySummarizationSummaryType), TypeInfoPropertyName = "SummarizationRequestBodySummarizationSummaryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SummarizationRequestBodySummarizationEffort), TypeInfoPropertyName = "SummarizationRequestBodySummarizationEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ActionItemsRequestBodyActionItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ActionItemsRequestBodyActionItemsEffort), TypeInfoPropertyName = "ActionItemsRequestBodyActionItemsEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranslationResponseTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationResponseSpeakerIdentification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.CustomFormattingResponseCustomFormatting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SummarizationResponseSummarization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ActionItemsResponseActionItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody, global::AssemblyAI.SummarizationRequestBody, global::AssemblyAI.ActionItemsRequestBody>?), TypeInfoPropertyName = "ActionItemsRequestBody_e21f8d1345e9e808")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TranslationResponse, global::AssemblyAI.SpeakerIdentificationResponse, global::AssemblyAI.CustomFormattingResponse, global::AssemblyAI.SummarizationResponse, global::AssemblyAI.ActionItemsResponse>?), TypeInfoPropertyName = "ActionItemsResponse_fc797e6746b9270c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.WordSearchMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TranscriptCustomSpelling>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TranscriptLanguageCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.PiiPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.SpeechModel2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TranscriptWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.SentimentAnalysisResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TranscriptUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TopicDetectionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.ContentSafetyLabelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TopicDetectionResultLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.ContentSafetyLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.AutoHighlightResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.Timestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TranscriptSentence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TranscriptParagraph>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TranscriptListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}