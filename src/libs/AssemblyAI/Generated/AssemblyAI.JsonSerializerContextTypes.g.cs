
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptWebhookNotification? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptReadyNotification? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.RedactedAudioNotification? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptReadyStatus? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.RedactedAudioResponse? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.RedactedAudioStatus? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SubtitleFormat? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.WordSearchResponse? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.WordSearchMatch>? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.WordSearchMatch? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Timestamp? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParams? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptCustomSpelling? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptLanguageCode? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptLanguageCode>? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsLanguageDetectionOptions? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsRedactPiiAudioOptions? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsRedactPiiAudioOptionsOverrideAudioRedactionMethod? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.RedactPiiAudioQuality? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.PiiPolicy? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.SubstitutionPolicy?, object>? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SubstitutionPolicy? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstanding? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody>? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationRequestBody? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBody? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingRequestBody? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummaryModel? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummaryType? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<string, object>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptParams? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptParamsVariant1? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptBoostParam? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptUtterance? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptWord? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptStatus? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Transcript? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.AutoHighlightsResult2, object>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AutoHighlightsResult2? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Chapter>? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Chapter? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.ContentSafetyLabelsResult, object>? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabelsResult? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Entity>? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Entity? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TopicDetectionModelResult, object>? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TopicDetectionModelResult? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptLanguageDetectionOptions? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptRedactPiiAudioOptions? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.RedactPiiAudioQuality?, object>? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.SentimentAnalysisResult>? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SentimentAnalysisResult? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptSpeechUnderstanding? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranslationResponse, global::AssemblyAI.SpeakerIdentificationResponse, global::AssemblyAI.CustomFormattingResponse>? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationResponse? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationResponse? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingResponse? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptRemoveAudioTags?, object>? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptRemoveAudioTags? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptTranslatedTexts? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AudioIntelligenceModelStatus? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResult>? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TopicDetectionResult? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabelResult>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabelResult? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::AssemblyAI.SeverityScoreSummary>? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SeverityScoreSummary? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.EntityType? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Sentiment? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResultLabel>? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TopicDetectionResultLabel? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabel? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabel>? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.AutoHighlightResult>? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AutoHighlightResult? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Timestamp>? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptSentence? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SentencesResponse? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptSentence>? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptParagraph? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ParagraphsResponse? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptParagraph>? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.PageDetails? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ListTranscriptParams? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptListItem? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptList? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptListItem>? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.UploadedFile? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CreateRealtimeTemporaryTokenParams? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.RealtimeTemporaryTokenResponse? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.PurgeLemurRequestDataResponse? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurBaseResponse? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurUsage? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurStringResponse? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurStringResponseVariant1? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurTaskResponse? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurSummaryResponse? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurActionItemsResponse? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestionAnswerResponse? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestionAnswerResponseVariant2? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.LemurQuestionAnswer>? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestionAnswer? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurResponse? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurBaseParams? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AnyOf<global::AssemblyAI.LemurModel?, string>? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurModel? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurTaskParams? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurTaskParamsVariant1? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurSummaryParams? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurSummaryParamsVariant2? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestionAnswerParams? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestionAnswerParamsVariant2? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.LemurQuestion>? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestion? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurActionItemsParams? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurActionItemsParamsVariant2? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Error? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationRequestBodyTranslation? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentification? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingRequestBodyCustomFormatting? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationResponseTranslation? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationResponseSpeakerIdentification? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingResponseCustomFormatting? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type150 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.WordSearchMatch>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptCustomSpelling>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptLanguageCode>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.PiiPolicy>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptWord>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Chapter>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Entity>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.SentimentAnalysisResult>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptUtterance>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TopicDetectionResult>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.ContentSafetyLabelResult>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TopicDetectionResultLabel>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.ContentSafetyLabel>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.AutoHighlightResult>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Timestamp>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptSentence>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptParagraph>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptListItem>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.LemurQuestionAnswer>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.LemurQuestion>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>? ListType24 { get; set; }
    }
}