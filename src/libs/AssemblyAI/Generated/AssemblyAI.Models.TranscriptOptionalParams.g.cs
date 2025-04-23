
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The parameters for creating a transcript
    /// </summary>
    public sealed partial class TranscriptOptionalParams
    {
        /// <summary>
        /// The point in time, in milliseconds, to stop transcribing in your media file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_at")]
        public int? AudioEndAt { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, to begin transcribing in your media file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_from")]
        public int? AudioStartFrom { get; set; }

        /// <summary>
        /// Enable [Auto Chapters](https://www.assemblyai.com/docs/models/auto-chapters), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_chapters")]
        public bool? AutoChapters { get; set; }

        /// <summary>
        /// Enable Key Phrases, either true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_highlights")]
        public bool? AutoHighlights { get; set; }

        /// <summary>
        /// How much to boost specified words
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boost_param")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptBoostParamJsonConverter))]
        public global::AssemblyAI.TranscriptBoostParam? BoostParam { get; set; }

        /// <summary>
        /// Enable [Content Moderation](https://www.assemblyai.com/docs/models/content-moderation), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety")]
        public bool? ContentSafety { get; set; }

        /// <summary>
        /// The confidence threshold for the Content Moderation model. Values must be between 25 and 100.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety_confidence")]
        public int? ContentSafetyConfidence { get; set; }

        /// <summary>
        /// Customize how words are spelled and formatted using to and from values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_spelling")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? CustomSpelling { get; set; }

        /// <summary>
        /// Enable custom topics, either true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_topics")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? CustomTopics { get; set; }

        /// <summary>
        /// Transcribe Filler Words, like "umm", in your media file; can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disfluencies")]
        public bool? Disfluencies { get; set; }

        /// <summary>
        /// Enable [Dual Channel](https://www.assemblyai.com/docs/models/speech-recognition#dual-channel-transcription) transcription, can be true or false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dual_channel")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DualChannel { get; set; }

        /// <summary>
        /// Enable [Entity Detection](https://www.assemblyai.com/docs/models/entity-detection), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_detection")]
        public bool? EntityDetection { get; set; }

        /// <summary>
        /// Filter profanity from the transcribed text, can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_profanity")]
        public bool? FilterProfanity { get; set; }

        /// <summary>
        /// Enable Text Formatting, can be true or false<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_text")]
        public bool? FormatText { get; set; }

        /// <summary>
        /// Enable [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iab_categories")]
        public bool? IabCategories { get; set; }

        /// <summary>
        /// &lt;Warning&gt;`keyterms_prompt` is only supported when the `speech_model` is specified as `slam-1`&lt;/Warning&gt;<br/>
        /// Improve accuracy with up to 1000 domain-specific words or phrases (maximum 6 words per phrase).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms_prompt")]
        public global::System.Collections.Generic.IList<string>? KeytermsPrompt { get; set; }

        /// <summary>
        /// The language of your audio file. Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/concepts/supported-languages).<br/>
        /// The default value is 'en_us'.<br/>
        /// Default Value: en_us
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public object? LanguageCode { get; set; }

        /// <summary>
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// Defaults to 0.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence_threshold")]
        public float? LanguageConfidenceThreshold { get; set; }

        /// <summary>
        /// Enable [Automatic language detection](https://www.assemblyai.com/docs/models/speech-recognition#automatic-language-detection), either true or false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public bool? LanguageDetection { get; set; }

        /// <summary>
        /// Enable [Multichannel](https://www.assemblyai.com/docs/models/speech-recognition#multichannel-transcription) transcription, can be true or false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multichannel")]
        public bool? Multichannel { get; set; }

        /// <summary>
        /// This parameter does not currently have any functionality attached to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Enable Automatic Punctuation, can be true or false<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuate")]
        public bool? Punctuate { get; set; }

        /// <summary>
        /// Redact PII from the transcribed text using the Redact PII model, can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii")]
        public bool? RedactPii { get; set; }

        /// <summary>
        /// Generate a copy of the original media file with spoken PII "beeped" out, can be true or false. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio")]
        public bool? RedactPiiAudio { get; set; }

        /// <summary>
        /// Controls the filetype of the audio created by redact_pii_audio. Currently supports mp3 (default) and wav. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Example: mp3
        /// </summary>
        /// <example>mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.RedactPiiAudioQualityJsonConverter))]
        public global::AssemblyAI.RedactPiiAudioQuality? RedactPiiAudioQuality { get; set; }

        /// <summary>
        /// The list of PII Redaction policies to enable. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_policies")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? RedactPiiPolicies { get; set; }

        /// <summary>
        /// The replacement logic for detected PII, can be "entity_type" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Default Value: hash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_sub")]
        public object? RedactPiiSub { get; set; }

        /// <summary>
        /// Enable [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public bool? SentimentAnalysis { get; set; }

        /// <summary>
        /// Enable [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_labels")]
        public bool? SpeakerLabels { get; set; }

        /// <summary>
        /// Tells the speaker label model how many speakers it should attempt to identify, up to 10. See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers_expected")]
        public int? SpeakersExpected { get; set; }

        /// <summary>
        /// The speech model to use for the transcription. When `null`, the "best" model is used.<br/>
        /// Default Value: best
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_model")]
        public object? SpeechModel { get; set; }

        /// <summary>
        /// Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_threshold")]
        public float? SpeechThreshold { get; set; }

        /// <summary>
        /// Enable [Summarization](https://www.assemblyai.com/docs/models/summarization), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        public bool? Summarization { get; set; }

        /// <summary>
        /// The model to summarize the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SummaryModelJsonConverter))]
        public global::AssemblyAI.SummaryModel? SummaryModel { get; set; }

        /// <summary>
        /// The type of summary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SummaryTypeJsonConverter))]
        public global::AssemblyAI.SummaryType? SummaryType { get; set; }

        /// <summary>
        /// The list of custom topics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// The header name to be sent with the transcript completed or failed webhook requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_name")]
        public string? WebhookAuthHeaderName { get; set; }

        /// <summary>
        /// The header value to send back with the transcript completed or failed webhook requests for added security
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_value")]
        public string? WebhookAuthHeaderValue { get; set; }

        /// <summary>
        /// The URL to which we send webhook requests.<br/>
        /// We sends two different types of webhook requests.<br/>
        /// One request when a transcript is completed or failed, and one request when the redacted audio is ready if redact_pii_audio is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The list of custom vocabulary to boost transcription probability for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_boost")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? WordBoost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParams" /> class.
        /// </summary>
        /// <param name="audioEndAt">
        /// The point in time, in milliseconds, to stop transcribing in your media file
        /// </param>
        /// <param name="audioStartFrom">
        /// The point in time, in milliseconds, to begin transcribing in your media file
        /// </param>
        /// <param name="autoChapters">
        /// Enable [Auto Chapters](https://www.assemblyai.com/docs/models/auto-chapters), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoHighlights">
        /// Enable Key Phrases, either true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="boostParam">
        /// How much to boost specified words
        /// </param>
        /// <param name="contentSafety">
        /// Enable [Content Moderation](https://www.assemblyai.com/docs/models/content-moderation), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="contentSafetyConfidence">
        /// The confidence threshold for the Content Moderation model. Values must be between 25 and 100.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="customSpelling">
        /// Customize how words are spelled and formatted using to and from values
        /// </param>
        /// <param name="disfluencies">
        /// Transcribe Filler Words, like "umm", in your media file; can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="entityDetection">
        /// Enable [Entity Detection](https://www.assemblyai.com/docs/models/entity-detection), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filterProfanity">
        /// Filter profanity from the transcribed text, can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="formatText">
        /// Enable Text Formatting, can be true or false<br/>
        /// Default Value: true
        /// </param>
        /// <param name="iabCategories">
        /// Enable [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keytermsPrompt">
        /// &lt;Warning&gt;`keyterms_prompt` is only supported when the `speech_model` is specified as `slam-1`&lt;/Warning&gt;<br/>
        /// Improve accuracy with up to 1000 domain-specific words or phrases (maximum 6 words per phrase).
        /// </param>
        /// <param name="languageCode">
        /// The language of your audio file. Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/concepts/supported-languages).<br/>
        /// The default value is 'en_us'.<br/>
        /// Default Value: en_us
        /// </param>
        /// <param name="languageConfidenceThreshold">
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// Defaults to 0.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="languageDetection">
        /// Enable [Automatic language detection](https://www.assemblyai.com/docs/models/speech-recognition#automatic-language-detection), either true or false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="multichannel">
        /// Enable [Multichannel](https://www.assemblyai.com/docs/models/speech-recognition#multichannel-transcription) transcription, can be true or false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="punctuate">
        /// Enable Automatic Punctuation, can be true or false<br/>
        /// Default Value: true
        /// </param>
        /// <param name="redactPii">
        /// Redact PII from the transcribed text using the Redact PII model, can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="redactPiiAudio">
        /// Generate a copy of the original media file with spoken PII "beeped" out, can be true or false. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="redactPiiAudioQuality">
        /// Controls the filetype of the audio created by redact_pii_audio. Currently supports mp3 (default) and wav. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Example: mp3
        /// </param>
        /// <param name="redactPiiPolicies">
        /// The list of PII Redaction policies to enable. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </param>
        /// <param name="redactPiiSub">
        /// The replacement logic for detected PII, can be "entity_type" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Default Value: hash
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Enable [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speakerLabels">
        /// Enable [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speakersExpected">
        /// Tells the speaker label model how many speakers it should attempt to identify, up to 10. See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more details.
        /// </param>
        /// <param name="speechModel">
        /// The speech model to use for the transcription. When `null`, the "best" model is used.<br/>
        /// Default Value: best
        /// </param>
        /// <param name="speechThreshold">
        /// Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="summarization">
        /// Enable [Summarization](https://www.assemblyai.com/docs/models/summarization), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summaryModel">
        /// The model to summarize the transcript
        /// </param>
        /// <param name="summaryType">
        /// The type of summary
        /// </param>
        /// <param name="topics">
        /// The list of custom topics
        /// </param>
        /// <param name="webhookAuthHeaderName">
        /// The header name to be sent with the transcript completed or failed webhook requests
        /// </param>
        /// <param name="webhookAuthHeaderValue">
        /// The header value to send back with the transcript completed or failed webhook requests for added security
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which we send webhook requests.<br/>
        /// We sends two different types of webhook requests.<br/>
        /// One request when a transcript is completed or failed, and one request when the redacted audio is ready if redact_pii_audio is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptOptionalParams(
            int? audioEndAt,
            int? audioStartFrom,
            bool? autoChapters,
            bool? autoHighlights,
            global::AssemblyAI.TranscriptBoostParam? boostParam,
            bool? contentSafety,
            int? contentSafetyConfidence,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? customSpelling,
            bool? disfluencies,
            bool? entityDetection,
            bool? filterProfanity,
            bool? formatText,
            bool? iabCategories,
            global::System.Collections.Generic.IList<string>? keytermsPrompt,
            object? languageCode,
            float? languageConfidenceThreshold,
            bool? languageDetection,
            bool? multichannel,
            bool? punctuate,
            bool? redactPii,
            bool? redactPiiAudio,
            global::AssemblyAI.RedactPiiAudioQuality? redactPiiAudioQuality,
            global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? redactPiiPolicies,
            object? redactPiiSub,
            bool? sentimentAnalysis,
            bool? speakerLabels,
            int? speakersExpected,
            object? speechModel,
            float? speechThreshold,
            bool? summarization,
            global::AssemblyAI.SummaryModel? summaryModel,
            global::AssemblyAI.SummaryType? summaryType,
            global::System.Collections.Generic.IList<string>? topics,
            string? webhookAuthHeaderName,
            string? webhookAuthHeaderValue,
            string? webhookUrl)
        {
            this.AudioEndAt = audioEndAt;
            this.AudioStartFrom = audioStartFrom;
            this.AutoChapters = autoChapters;
            this.AutoHighlights = autoHighlights;
            this.BoostParam = boostParam;
            this.ContentSafety = contentSafety;
            this.ContentSafetyConfidence = contentSafetyConfidence;
            this.CustomSpelling = customSpelling;
            this.Disfluencies = disfluencies;
            this.EntityDetection = entityDetection;
            this.FilterProfanity = filterProfanity;
            this.FormatText = formatText;
            this.IabCategories = iabCategories;
            this.KeytermsPrompt = keytermsPrompt;
            this.LanguageCode = languageCode;
            this.LanguageConfidenceThreshold = languageConfidenceThreshold;
            this.LanguageDetection = languageDetection;
            this.Multichannel = multichannel;
            this.Punctuate = punctuate;
            this.RedactPii = redactPii;
            this.RedactPiiAudio = redactPiiAudio;
            this.RedactPiiAudioQuality = redactPiiAudioQuality;
            this.RedactPiiPolicies = redactPiiPolicies;
            this.RedactPiiSub = redactPiiSub;
            this.SentimentAnalysis = sentimentAnalysis;
            this.SpeakerLabels = speakerLabels;
            this.SpeakersExpected = speakersExpected;
            this.SpeechModel = speechModel;
            this.SpeechThreshold = speechThreshold;
            this.Summarization = summarization;
            this.SummaryModel = summaryModel;
            this.SummaryType = summaryType;
            this.Topics = topics;
            this.WebhookAuthHeaderName = webhookAuthHeaderName;
            this.WebhookAuthHeaderValue = webhookAuthHeaderValue;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParams" /> class.
        /// </summary>
        public TranscriptOptionalParams()
        {
        }
    }
}