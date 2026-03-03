
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
        public global::AssemblyAI.CustomFormattingRequestBody? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingRequestBodyCustomFormatting? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummaryModel? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummaryType? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<string, object>? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptParams? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptParamsVariant1? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptBoostParam? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptUtterance? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptWord? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptStatus? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Transcript? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.AutoHighlightsResult2, object>? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AutoHighlightsResult2? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AudioIntelligenceModelStatus? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.AutoHighlightResult>? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AutoHighlightResult? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Timestamp>? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Chapter>? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Chapter? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.ContentSafetyLabelsResult, object>? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabelsResult? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabelResult>? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabelResult? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabel>? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabel? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::AssemblyAI.SeverityScoreSummary>? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SeverityScoreSummary? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Entity>? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Entity? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.EntityType? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TopicDetectionModelResult, object>? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TopicDetectionModelResult? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResult>? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TopicDetectionResult? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResultLabel>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TopicDetectionResultLabel? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptLanguageDetectionOptions? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.RedactPiiAudioQuality?, object>? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.SentimentAnalysisResult>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SentimentAnalysisResult? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Sentiment? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptSpeechUnderstanding? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranslationResponse, global::AssemblyAI.SpeakerIdentificationResponse, global::AssemblyAI.CustomFormattingResponse>? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationResponse? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationResponseTranslation? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationResponse? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationResponseSpeakerIdentification? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingResponse? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingResponseCustomFormatting? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptTranslatedTexts? Type97 { get; set; }
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
        public byte[]? Type141 { get; set; }
    }
}