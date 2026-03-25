
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

            typeof(global::AssemblyAI.JsonConverters.TranscriptBoostParamJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptBoostParamNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SubstitutionPolicyJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SubstitutionPolicyNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.RedactPiiAudioQualityJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.RedactPiiAudioQualityNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.PiiPolicyJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.PiiPolicyNullableJsonConverter),

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

            typeof(global::AssemblyAI.JsonConverters.LemurModelJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurModelNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerTypeJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerTypeNullableJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptWebhookNotificationJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.RedactedAudioNotificationJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.TranscriptParamsJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurStringResponseJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurTaskResponseJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurSummaryResponseJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurActionItemsResponseJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurQuestionAnswerResponseJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurResponseJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurTaskParamsJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurSummaryParamsJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurQuestionAnswerParamsJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.LemurActionItemsParamsJsonConverter),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>),

            typeof(global::AssemblyAI.JsonConverters.AnyOfJsonConverter<global::AssemblyAI.TranscriptLanguageCode?, string>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.SubstitutionPolicy?, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.AutoHighlightsResult2, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.ContentSafetyLabelsResult, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TopicDetectionModelResult, object>),

            typeof(global::AssemblyAI.JsonConverters.AnyOfJsonConverter<global::AssemblyAI.TranscriptLanguageCode?, string>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.RedactPiiAudioQuality?, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranslationResponse, global::AssemblyAI.SpeakerIdentificationResponse, global::AssemblyAI.CustomFormattingResponse>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranscriptRemoveAudioTags?, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::AssemblyAI.JsonConverters.AnyOfJsonConverter<global::AssemblyAI.LemurModel?, string>),

            typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::AssemblyAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptWebhookNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptReadyNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.RedactedAudioNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptReadyStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.RedactedAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.RedactedAudioStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SubtitleFormat))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptLanguageCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptLanguageCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsLanguageDetectionOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsRedactPiiAudioOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.RedactPiiAudioQuality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.PiiPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.SubstitutionPolicy?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SubstitutionPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstanding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranslationRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.CustomFormattingRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SummaryModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SummaryType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptParamsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptBoostParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Transcript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.AutoHighlightsResult2, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.AutoHighlightsResult2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.Chapter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Chapter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.ContentSafetyLabelsResult, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ContentSafetyLabelsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.Entity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Entity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TopicDetectionModelResult, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TopicDetectionModelResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptLanguageDetectionOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptRedactPiiAudioOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.RedactPiiAudioQuality?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.SentimentAnalysisResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SentimentAnalysisResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptSpeechUnderstanding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TranslationResponse, global::AssemblyAI.SpeakerIdentificationResponse, global::AssemblyAI.CustomFormattingResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranslationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.CustomFormattingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptRemoveAudioTags?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptRemoveAudioTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptTranslatedTexts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.AudioIntelligenceModelStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TopicDetectionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabelResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ContentSafetyLabelResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::AssemblyAI.SeverityScoreSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SeverityScoreSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.EntityType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Sentiment))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.ListTranscriptParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranscriptList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.UploadedFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.CreateRealtimeTemporaryTokenParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.RealtimeTemporaryTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.PurgeLemurRequestDataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurBaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurStringResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurStringResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurActionItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurQuestionAnswerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurQuestionAnswerResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.LemurQuestionAnswer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurQuestionAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurBaseParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.AnyOf<global::AssemblyAI.LemurModel?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurTaskParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurTaskParamsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurSummaryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurSummaryParamsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurQuestionAnswerParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurQuestionAnswerParamsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.LemurQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurActionItemsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.LemurActionItemsParamsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranslationRequestBodyTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.CustomFormattingRequestBodyCustomFormatting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.TranslationResponseTranslation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.SpeakerIdentificationResponseSpeakerIdentification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.CustomFormattingResponseCustomFormatting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.WordSearchMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TranscriptCustomSpelling>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.TranscriptLanguageCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.PiiPolicy>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.LemurQuestionAnswer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.LemurQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}