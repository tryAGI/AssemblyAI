
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
        public global::AssemblyAI.TranscriptReadyNotification? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptReadyStatus? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.RedactedAudioNotification? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.RedactedAudioResponse? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.RedactedAudioStatus? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SubtitleFormat? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.WordSearchResponse? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.WordSearchMatch>? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.WordSearchMatch? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Timestamp? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParams? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptCustomSpelling? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<string, object>? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptLanguageCode? Type24 { get; set; }
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
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstanding? Type38 { get; set; }
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
        public global::AssemblyAI.SummarizationRequestBody? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ActionItemsRequestBody? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummaryModel? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummaryType? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags? Type47 { get; set; }
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
        public global::AssemblyAI.TranslationResponse? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationResponse? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingResponse? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummarizationResponse? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ActionItemsResponse? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptRemoveAudioTags?, object>? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptRemoveAudioTags? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptTranslatedTexts? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AudioIntelligenceModelStatus? Type82 { get; set; }
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
        public global::System.Collections.Generic.Dictionary<string, double>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabelResult>? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabelResult? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::AssemblyAI.SeverityScoreSummary>? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SeverityScoreSummary? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.EntityType? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.Sentiment? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResultLabel>? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TopicDetectionResultLabel? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabel? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabel>? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.AutoHighlightResult>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.AutoHighlightResult? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Timestamp>? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptSentence? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SentencesResponse? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptSentence>? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptParagraph? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ParagraphsResponse? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptParagraph>? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.PageDetails? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranscriptListItem? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type107 { get; set; }
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
        public global::AssemblyAI.Error? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationRequestBodyTranslation? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentification? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingRequestBodyCustomFormatting? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummarizationRequestBodySummarization? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummarizationRequestBodySummarizationSummaryType? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummarizationRequestBodySummarizationEffort? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ActionItemsRequestBodyActionItems? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ActionItemsRequestBodyActionItemsEffort? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.TranslationResponseTranslation? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationResponseSpeakerIdentification? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.CustomFormattingResponseCustomFormatting? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.SummarizationResponseSummarization? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::AssemblyAI.ActionItemsResponseActionItems? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type129 { get; set; }

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
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptWord>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Chapter>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Entity>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.SentimentAnalysisResult>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptUtterance>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TopicDetectionResult>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.ContentSafetyLabelResult>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TopicDetectionResultLabel>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.ContentSafetyLabel>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.AutoHighlightResult>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Timestamp>? ListType18 { get; set; }
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
        public global::System.Collections.Generic.List<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType23 { get; set; }
    }
}