
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
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

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
        public global::AssemblyAI.TranscriptOptionalParamsDomain? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptLanguageCode? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptLanguageCode>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsLanguageDetectionOptions? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsLanguageDetectionOptionsOnNoSpeechDetected? Type28 { get; set; }
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
        public global::AssemblyAI.SubstitutionPolicy? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.SpeechModel>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SpeechModel? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstanding? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranslationRequestBody? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBody? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.CustomFormattingRequestBody? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SummarizationRequestBody? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.ActionItemsRequestBody? Type44 { get; set; }
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
        public global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags2? Type47 { get; set; }
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
        public global::AssemblyAI.AutoHighlightsResult? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Chapter>? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Chapter? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.ContentSafetyLabelsResult? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Entity>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Entity? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TopicDetectionModelResult? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptLanguageDetectionOptions? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptLanguageDetectionOptionsOnNoSpeechDetected? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptMetadata? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptMetadataWarning>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptMetadataWarning? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptRedactPiiAudioOptions? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod? Type69 { get; set; }
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
        public global::AssemblyAI.TranscriptRemoveAudioTags2? Type78 { get; set; }
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
        public global::AssemblyAI.TranscriptListItem? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranscriptList? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptListItem>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.UploadedFile? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Error? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranslationRequestBodyTranslation? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentification? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.CustomFormattingRequestBodyCustomFormatting? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SummarizationRequestBodySummarization? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SummarizationRequestBodySummarizationSummaryType? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SummarizationRequestBodySummarizationEffort? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.ActionItemsRequestBodyActionItems? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.ActionItemsRequestBodyActionItemsEffort? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.TranslationResponseTranslation? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SpeakerIdentificationResponseSpeakerIdentification? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.CustomFormattingResponseCustomFormatting? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.SummarizationResponseSummarization? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.ActionItemsResponseActionItems? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type128 { get; set; }

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
        public global::System.Collections.Generic.List<global::AssemblyAI.SpeechModel>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptWord>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Chapter>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Entity>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptMetadataWarning>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.SentimentAnalysisResult>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptUtterance>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TopicDetectionResult>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.ContentSafetyLabelResult>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TopicDetectionResultLabel>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.ContentSafetyLabel>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.AutoHighlightResult>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Timestamp>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptSentence>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptParagraph>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.TranscriptListItem>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType25 { get; set; }
    }
}