
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
        public global::System.Guid? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptReadyStatus? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.RedactedAudioNotification? Type4 { get; set; }
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
        public global::AssemblyAI.RedactPiiAudioQuality? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.PiiPolicy? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.SubstitutionPolicy?, object>? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SubstitutionPolicy? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstanding? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranslationRequestBody, global::AssemblyAI.SpeakerIdentificationRequestBody, global::AssemblyAI.CustomFormattingRequestBody>? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationRequestBody? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationRequestBodyTranslation? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBody? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentification? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingRequestBody? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingRequestBodyCustomFormatting? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummaryModel? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummaryType? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<string, object>? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptParams? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptParamsVariant1? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptBoostParam? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptUtterance? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptWord? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptStatus? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Transcript? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.AutoHighlightsResult2, object>? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AutoHighlightsResult2? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AudioIntelligenceModelStatus? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.AutoHighlightResult>? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AutoHighlightResult? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Timestamp>? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Chapter>? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Chapter? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.ContentSafetyLabelsResult, object>? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabelsResult? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabelResult>? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabelResult? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabel>? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabel? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::AssemblyAI.SeverityScoreSummary>? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SeverityScoreSummary? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Entity>? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Entity? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.EntityType? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TopicDetectionModelResult, object>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TopicDetectionModelResult? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResult>? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TopicDetectionResult? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResultLabel>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TopicDetectionResultLabel? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptLanguageDetectionOptions? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.RedactPiiAudioQuality?, object>? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.SentimentAnalysisResult>? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SentimentAnalysisResult? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Sentiment? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptSpeechUnderstanding? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranslationResponse, global::AssemblyAI.SpeakerIdentificationResponse, global::AssemblyAI.CustomFormattingResponse>? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationResponse? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationResponseTranslation? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationResponse? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationResponseSpeakerIdentification? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingResponse? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingResponseCustomFormatting? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptRemoveAudioTags?, object>? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptRemoveAudioTags? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptTranslatedTexts? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptSentence? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SentencesResponse? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptSentence>? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptParagraph? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ParagraphsResponse? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptParagraph>? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.PageDetails? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ListTranscriptParams? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptListItem? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptList? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptListItem>? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.UploadedFile? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CreateRealtimeTemporaryTokenParams? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.RealtimeTemporaryTokenResponse? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.PurgeLemurRequestDataResponse? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurBaseResponse? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurUsage? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurStringResponse? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurStringResponseVariant1? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurTaskResponse? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurSummaryResponse? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurActionItemsResponse? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestionAnswerResponse? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestionAnswerResponseVariant2? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.LemurQuestionAnswer>? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestionAnswer? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurResponse? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurBaseParams? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AnyOf<global::AssemblyAI.LemurModel?, string>? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurModel? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurTaskParams? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurTaskParamsVariant1? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurSummaryParams? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurSummaryParamsVariant2? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestionAnswerParams? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestionAnswerParamsVariant2? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.LemurQuestion>? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurQuestion? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurActionItemsParams? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.LemurActionItemsParamsVariant2? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Error? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type147 { get; set; }

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
        public global::System.Collections.Generic.List<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptWord>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.AutoHighlightResult>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Timestamp>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Chapter>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.ContentSafetyLabelResult>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.ContentSafetyLabel>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Entity>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TopicDetectionResult>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TopicDetectionResultLabel>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.SentimentAnalysisResult>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptUtterance>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptSentence>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptParagraph>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptListItem>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.LemurQuestionAnswer>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.LemurQuestion>? ListType24 { get; set; }
    }
}