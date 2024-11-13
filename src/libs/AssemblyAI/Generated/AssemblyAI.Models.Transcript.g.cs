
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A transcript object
    /// </summary>
    public sealed partial class Transcript
    {
        /// <summary>
        /// The unique identifier of your transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The URL of the media that was transcribed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.TranscriptStatus Status { get; set; }

        /// <summary>
        /// The language of your audio file.<br/>
        /// Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/concepts/supported-languages).<br/>
        /// The default value is 'en_us'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.AnyOfJsonConverter<global::AssemblyAI.TranscriptLanguageCode?, string>))]
        public global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>? LanguageCode { get; set; }

        /// <summary>
        /// Whether [Automatic language detection](https://www.assemblyai.com/docs/models/speech-recognition#automatic-language-detection) is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public bool? LanguageDetection { get; set; }

        /// <summary>
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float? LanguageConfidenceThreshold { get; set; }

        /// <summary>
        /// The confidence score for the detected language, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? LanguageConfidence { get; set; }

        /// <summary>
        /// The speech model used for the transcription. When `null`, the default model is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.SpeechModel2?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.OneOf<global::AssemblyAI.SpeechModel2?, object> SpeechModel { get; set; }

        /// <summary>
        /// The textual transcript of your media file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// An array of temporally-sequential word objects, one for each word in the transcript.<br/>
        /// See [Speech recognition](https://www.assemblyai.com/docs/models/speech-recognition) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>? Words { get; set; }

        /// <summary>
        /// When dual_channel or speaker_labels is enabled, a list of turn-by-turn utterance objects.<br/>
        /// See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>? Utterances { get; set; }

        /// <summary>
        /// The confidence score for the transcript, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The duration of this transcript object's media file, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        public int? AudioDuration { get; set; }

        /// <summary>
        /// Whether Automatic Punctuation is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuate")]
        public bool? Punctuate { get; set; }

        /// <summary>
        /// Whether Text Formatting is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_text")]
        public bool? FormatText { get; set; }

        /// <summary>
        /// Transcribe Filler Words, like "umm", in your media file; can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disfluencies")]
        public bool? Disfluencies { get; set; }

        /// <summary>
        /// Whether [Multichannel transcription](https://www.assemblyai.com/docs/models/speech-recognition#multichannel-transcription) was enabled in the transcription request, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multichannel")]
        public bool? Multichannel { get; set; }

        /// <summary>
        /// The number of audio channels in the audio file. This is only present when multichannel is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_channels")]
        public int? AudioChannels { get; set; }

        /// <summary>
        /// Whether [Dual channel transcription](https://www.assemblyai.com/docs/models/speech-recognition#dual-channel-transcription) was enabled in the transcription request, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dual_channel")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DualChannel { get; set; }

        /// <summary>
        /// The URL to which we send webhook requests.<br/>
        /// We sends two different types of webhook requests.<br/>
        /// One request when a transcript is completed or failed, and one request when the redacted audio is ready if redact_pii_audio is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The status code we received from your server when delivering the transcript completed or failed webhook request, if a webhook URL was provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_status_code")]
        public int? WebhookStatusCode { get; set; }

        /// <summary>
        /// Whether webhook authentication details were provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WebhookAuth { get; set; }

        /// <summary>
        /// The header name to be sent with the transcript completed or failed webhook requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_name")]
        public string? WebhookAuthHeaderName { get; set; }

        /// <summary>
        /// Whether speed boost is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_boost")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SpeedBoost { get; set; }

        /// <summary>
        /// Whether Key Phrases is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_highlights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoHighlights { get; set; }

        /// <summary>
        /// An array of results for the Key Phrases model, if it is enabled.<br/>
        /// See [Key Phrases](https://www.assemblyai.com/docs/models/key-phrases) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_highlights_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.AutoHighlightsResult2, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.AutoHighlightsResult2, object>? AutoHighlightsResult { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, in the file at which the transcription was started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_from")]
        public int? AudioStartFrom { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, in the file at which the transcription was terminated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_at")]
        public int? AudioEndAt { get; set; }

        /// <summary>
        /// The list of custom vocabulary to boost transcription probability for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_boost")]
        public global::System.Collections.Generic.IList<string>? WordBoost { get; set; }

        /// <summary>
        /// The word boost parameter value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boost_param")]
        public string? BoostParam { get; set; }

        /// <summary>
        /// Whether [Profanity Filtering](https://www.assemblyai.com/docs/models/speech-recognition#profanity-filtering) is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_profanity")]
        public bool? FilterProfanity { get; set; }

        /// <summary>
        /// Whether [PII Redaction](https://www.assemblyai.com/docs/models/pii-redaction) is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RedactPii { get; set; }

        /// <summary>
        /// Whether a redacted version of the audio file was generated,<br/>
        /// either true or false. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio")]
        public bool? RedactPiiAudio { get; set; }

        /// <summary>
        /// The audio quality of the PII-redacted audio file, if redact_pii_audio is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.RedactPiiAudioQuality?, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.RedactPiiAudioQuality?, object>? RedactPiiAudioQuality { get; set; }

        /// <summary>
        /// The list of PII Redaction policies that were enabled, if PII Redaction is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_policies")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? RedactPiiPolicies { get; set; }

        /// <summary>
        /// The replacement logic for detected PII, can be "entity_name" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_sub")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SubstitutionPolicyJsonConverter))]
        public global::AssemblyAI.SubstitutionPolicy? RedactPiiSub { get; set; }

        /// <summary>
        /// Whether [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_labels")]
        public bool? SpeakerLabels { get; set; }

        /// <summary>
        /// Tell the speaker label model how many speakers it should attempt to identify, up to 10. See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers_expected")]
        public int? SpeakersExpected { get; set; }

        /// <summary>
        /// Whether [Content Moderation](https://www.assemblyai.com/docs/models/content-moderation) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety")]
        public bool? ContentSafety { get; set; }

        /// <summary>
        /// An array of results for the Content Moderation model, if it is enabled.<br/>
        /// See [Content moderation](https://www.assemblyai.com/docs/models/content-moderation) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety_labels")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.ContentSafetyLabelsResult, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.ContentSafetyLabelsResult, object>? ContentSafetyLabels { get; set; }

        /// <summary>
        /// Whether [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iab_categories")]
        public bool? IabCategories { get; set; }

        /// <summary>
        /// The result of the Topic Detection model, if it is enabled.<br/>
        /// See [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iab_categories_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TopicDetectionModelResult, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.TopicDetectionModelResult, object>? IabCategoriesResult { get; set; }

        /// <summary>
        /// Customize how words are spelled and formatted using to and from values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_spelling")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? CustomSpelling { get; set; }

        /// <summary>
        /// Whether [Auto Chapters](https://www.assemblyai.com/docs/models/auto-chapters) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_chapters")]
        public bool? AutoChapters { get; set; }

        /// <summary>
        /// An array of temporally sequential chapters for the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapters")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.Chapter>? Chapters { get; set; }

        /// <summary>
        /// Whether [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Summarization { get; set; }

        /// <summary>
        /// The type of summary generated, if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_type")]
        public string? SummaryType { get; set; }

        /// <summary>
        /// The Summarization model used to generate the summary,<br/>
        /// if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_model")]
        public string? SummaryModel { get; set; }

        /// <summary>
        /// The generated summary of the media file, if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Whether custom topics is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_topics")]
        public bool? CustomTopics { get; set; }

        /// <summary>
        /// The list of custom topics provided if custom topics is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// Whether [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public bool? SentimentAnalysis { get; set; }

        /// <summary>
        /// An array of results for the Sentiment Analysis model, if it is enabled.<br/>
        /// See [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis_results")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.SentimentAnalysisResult>? SentimentAnalysisResults { get; set; }

        /// <summary>
        /// Whether [Entity Detection](https://www.assemblyai.com/docs/models/entity-detection) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_detection")]
        public bool? EntityDetection { get; set; }

        /// <summary>
        /// An array of results for the Entity Detection model, if it is enabled.<br/>
        /// See [Entity detection](https://www.assemblyai.com/docs/models/entity-detection) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.Entity>? Entities { get; set; }

        /// <summary>
        /// Defaults to null. Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_threshold")]
        public float? SpeechThreshold { get; set; }

        /// <summary>
        /// True while a request is throttled and false when a request is no longer throttled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throttled")]
        public bool? Throttled { get; set; }

        /// <summary>
        /// Error message of why the transcript failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The language model that was used for the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguageModel { get; set; }

        /// <summary>
        /// The acoustic model that was used for the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acoustic_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AcousticModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of your transcript
        /// </param>
        /// <param name="audioUrl">
        /// The URL of the media that was transcribed
        /// </param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="languageCode">
        /// The language of your audio file.<br/>
        /// Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/concepts/supported-languages).<br/>
        /// The default value is 'en_us'.
        /// </param>
        /// <param name="languageDetection">
        /// Whether [Automatic language detection](https://www.assemblyai.com/docs/models/speech-recognition#automatic-language-detection) is enabled, either true or false
        /// </param>
        /// <param name="languageConfidenceThreshold">
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.
        /// </param>
        /// <param name="languageConfidence">
        /// The confidence score for the detected language, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </param>
        /// <param name="speechModel">
        /// The speech model used for the transcription. When `null`, the default model is used.
        /// </param>
        /// <param name="text">
        /// The textual transcript of your media file
        /// </param>
        /// <param name="words">
        /// An array of temporally-sequential word objects, one for each word in the transcript.<br/>
        /// See [Speech recognition](https://www.assemblyai.com/docs/models/speech-recognition) for more information.
        /// </param>
        /// <param name="utterances">
        /// When dual_channel or speaker_labels is enabled, a list of turn-by-turn utterance objects.<br/>
        /// See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more information.
        /// </param>
        /// <param name="confidence">
        /// The confidence score for the transcript, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </param>
        /// <param name="audioDuration">
        /// The duration of this transcript object's media file, in seconds
        /// </param>
        /// <param name="punctuate">
        /// Whether Automatic Punctuation is enabled, either true or false
        /// </param>
        /// <param name="formatText">
        /// Whether Text Formatting is enabled, either true or false
        /// </param>
        /// <param name="disfluencies">
        /// Transcribe Filler Words, like "umm", in your media file; can be true or false
        /// </param>
        /// <param name="multichannel">
        /// Whether [Multichannel transcription](https://www.assemblyai.com/docs/models/speech-recognition#multichannel-transcription) was enabled in the transcription request, either true or false
        /// </param>
        /// <param name="audioChannels">
        /// The number of audio channels in the audio file. This is only present when multichannel is enabled.
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which we send webhook requests.<br/>
        /// We sends two different types of webhook requests.<br/>
        /// One request when a transcript is completed or failed, and one request when the redacted audio is ready if redact_pii_audio is enabled.
        /// </param>
        /// <param name="webhookStatusCode">
        /// The status code we received from your server when delivering the transcript completed or failed webhook request, if a webhook URL was provided
        /// </param>
        /// <param name="webhookAuth">
        /// Whether webhook authentication details were provided
        /// </param>
        /// <param name="webhookAuthHeaderName">
        /// The header name to be sent with the transcript completed or failed webhook requests
        /// </param>
        /// <param name="autoHighlights">
        /// Whether Key Phrases is enabled, either true or false
        /// </param>
        /// <param name="autoHighlightsResult">
        /// An array of results for the Key Phrases model, if it is enabled.<br/>
        /// See [Key Phrases](https://www.assemblyai.com/docs/models/key-phrases) for more information.
        /// </param>
        /// <param name="audioStartFrom">
        /// The point in time, in milliseconds, in the file at which the transcription was started
        /// </param>
        /// <param name="audioEndAt">
        /// The point in time, in milliseconds, in the file at which the transcription was terminated
        /// </param>
        /// <param name="wordBoost">
        /// The list of custom vocabulary to boost transcription probability for
        /// </param>
        /// <param name="boostParam">
        /// The word boost parameter value
        /// </param>
        /// <param name="filterProfanity">
        /// Whether [Profanity Filtering](https://www.assemblyai.com/docs/models/speech-recognition#profanity-filtering) is enabled, either true or false
        /// </param>
        /// <param name="redactPii">
        /// Whether [PII Redaction](https://www.assemblyai.com/docs/models/pii-redaction) is enabled, either true or false
        /// </param>
        /// <param name="redactPiiAudio">
        /// Whether a redacted version of the audio file was generated,<br/>
        /// either true or false. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </param>
        /// <param name="redactPiiAudioQuality">
        /// The audio quality of the PII-redacted audio file, if redact_pii_audio is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </param>
        /// <param name="redactPiiPolicies">
        /// The list of PII Redaction policies that were enabled, if PII Redaction is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </param>
        /// <param name="redactPiiSub">
        /// The replacement logic for detected PII, can be "entity_name" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </param>
        /// <param name="speakerLabels">
        /// Whether [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, can be true or false
        /// </param>
        /// <param name="speakersExpected">
        /// Tell the speaker label model how many speakers it should attempt to identify, up to 10. See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more details.
        /// </param>
        /// <param name="contentSafety">
        /// Whether [Content Moderation](https://www.assemblyai.com/docs/models/content-moderation) is enabled, can be true or false
        /// </param>
        /// <param name="contentSafetyLabels">
        /// An array of results for the Content Moderation model, if it is enabled.<br/>
        /// See [Content moderation](https://www.assemblyai.com/docs/models/content-moderation) for more information.
        /// </param>
        /// <param name="iabCategories">
        /// Whether [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) is enabled, can be true or false
        /// </param>
        /// <param name="iabCategoriesResult">
        /// The result of the Topic Detection model, if it is enabled.<br/>
        /// See [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) for more information.
        /// </param>
        /// <param name="customSpelling">
        /// Customize how words are spelled and formatted using to and from values
        /// </param>
        /// <param name="autoChapters">
        /// Whether [Auto Chapters](https://www.assemblyai.com/docs/models/auto-chapters) is enabled, can be true or false
        /// </param>
        /// <param name="chapters">
        /// An array of temporally sequential chapters for the audio file
        /// </param>
        /// <param name="summarization">
        /// Whether [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled, either true or false
        /// </param>
        /// <param name="summaryType">
        /// The type of summary generated, if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </param>
        /// <param name="summaryModel">
        /// The Summarization model used to generate the summary,<br/>
        /// if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </param>
        /// <param name="summary">
        /// The generated summary of the media file, if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </param>
        /// <param name="customTopics">
        /// Whether custom topics is enabled, either true or false
        /// </param>
        /// <param name="topics">
        /// The list of custom topics provided if custom topics is enabled
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Whether [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis) is enabled, can be true or false
        /// </param>
        /// <param name="sentimentAnalysisResults">
        /// An array of results for the Sentiment Analysis model, if it is enabled.<br/>
        /// See [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis) for more information.
        /// </param>
        /// <param name="entityDetection">
        /// Whether [Entity Detection](https://www.assemblyai.com/docs/models/entity-detection) is enabled, can be true or false
        /// </param>
        /// <param name="entities">
        /// An array of results for the Entity Detection model, if it is enabled.<br/>
        /// See [Entity detection](https://www.assemblyai.com/docs/models/entity-detection) for more information.
        /// </param>
        /// <param name="speechThreshold">
        /// Defaults to null. Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive.
        /// </param>
        /// <param name="throttled">
        /// True while a request is throttled and false when a request is no longer throttled
        /// </param>
        /// <param name="error">
        /// Error message of why the transcript failed
        /// </param>
        /// <param name="languageModel">
        /// The language model that was used for the transcript
        /// </param>
        /// <param name="acousticModel">
        /// The acoustic model that was used for the transcript
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Transcript(
            global::System.Guid id,
            string audioUrl,
            global::AssemblyAI.TranscriptStatus status,
            float? languageConfidenceThreshold,
            double? languageConfidence,
            global::AssemblyAI.OneOf<global::AssemblyAI.SpeechModel2?, object> speechModel,
            bool webhookAuth,
            bool autoHighlights,
            bool redactPii,
            bool summarization,
            string languageModel,
            string acousticModel,
            global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>? languageCode,
            bool? languageDetection,
            string? text,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>? words,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>? utterances,
            double? confidence,
            int? audioDuration,
            bool? punctuate,
            bool? formatText,
            bool? disfluencies,
            bool? multichannel,
            int? audioChannels,
            string? webhookUrl,
            int? webhookStatusCode,
            string? webhookAuthHeaderName,
            global::AssemblyAI.OneOf<global::AssemblyAI.AutoHighlightsResult2, object>? autoHighlightsResult,
            int? audioStartFrom,
            int? audioEndAt,
            global::System.Collections.Generic.IList<string>? wordBoost,
            string? boostParam,
            bool? filterProfanity,
            bool? redactPiiAudio,
            global::AssemblyAI.OneOf<global::AssemblyAI.RedactPiiAudioQuality?, object>? redactPiiAudioQuality,
            global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? redactPiiPolicies,
            global::AssemblyAI.SubstitutionPolicy? redactPiiSub,
            bool? speakerLabels,
            int? speakersExpected,
            bool? contentSafety,
            global::AssemblyAI.OneOf<global::AssemblyAI.ContentSafetyLabelsResult, object>? contentSafetyLabels,
            bool? iabCategories,
            global::AssemblyAI.OneOf<global::AssemblyAI.TopicDetectionModelResult, object>? iabCategoriesResult,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? customSpelling,
            bool? autoChapters,
            global::System.Collections.Generic.IList<global::AssemblyAI.Chapter>? chapters,
            string? summaryType,
            string? summaryModel,
            string? summary,
            bool? customTopics,
            global::System.Collections.Generic.IList<string>? topics,
            bool? sentimentAnalysis,
            global::System.Collections.Generic.IList<global::AssemblyAI.SentimentAnalysisResult>? sentimentAnalysisResults,
            bool? entityDetection,
            global::System.Collections.Generic.IList<global::AssemblyAI.Entity>? entities,
            float? speechThreshold,
            bool? throttled,
            string? error)
        {
            this.Id = id;
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.Status = status;
            this.LanguageConfidenceThreshold = languageConfidenceThreshold;
            this.LanguageConfidence = languageConfidence;
            this.SpeechModel = speechModel;
            this.WebhookAuth = webhookAuth;
            this.AutoHighlights = autoHighlights;
            this.RedactPii = redactPii;
            this.Summarization = summarization;
            this.LanguageModel = languageModel ?? throw new global::System.ArgumentNullException(nameof(languageModel));
            this.AcousticModel = acousticModel ?? throw new global::System.ArgumentNullException(nameof(acousticModel));
            this.LanguageCode = languageCode;
            this.LanguageDetection = languageDetection;
            this.Text = text;
            this.Words = words;
            this.Utterances = utterances;
            this.Confidence = confidence;
            this.AudioDuration = audioDuration;
            this.Punctuate = punctuate;
            this.FormatText = formatText;
            this.Disfluencies = disfluencies;
            this.Multichannel = multichannel;
            this.AudioChannels = audioChannels;
            this.WebhookUrl = webhookUrl;
            this.WebhookStatusCode = webhookStatusCode;
            this.WebhookAuthHeaderName = webhookAuthHeaderName;
            this.AutoHighlightsResult = autoHighlightsResult;
            this.AudioStartFrom = audioStartFrom;
            this.AudioEndAt = audioEndAt;
            this.WordBoost = wordBoost;
            this.BoostParam = boostParam;
            this.FilterProfanity = filterProfanity;
            this.RedactPiiAudio = redactPiiAudio;
            this.RedactPiiAudioQuality = redactPiiAudioQuality;
            this.RedactPiiPolicies = redactPiiPolicies;
            this.RedactPiiSub = redactPiiSub;
            this.SpeakerLabels = speakerLabels;
            this.SpeakersExpected = speakersExpected;
            this.ContentSafety = contentSafety;
            this.ContentSafetyLabels = contentSafetyLabels;
            this.IabCategories = iabCategories;
            this.IabCategoriesResult = iabCategoriesResult;
            this.CustomSpelling = customSpelling;
            this.AutoChapters = autoChapters;
            this.Chapters = chapters;
            this.SummaryType = summaryType;
            this.SummaryModel = summaryModel;
            this.Summary = summary;
            this.CustomTopics = customTopics;
            this.Topics = topics;
            this.SentimentAnalysis = sentimentAnalysis;
            this.SentimentAnalysisResults = sentimentAnalysisResults;
            this.EntityDetection = entityDetection;
            this.Entities = entities;
            this.SpeechThreshold = speechThreshold;
            this.Throttled = throttled;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript" /> class.
        /// </summary>
        public Transcript()
        {
        }
    }
}