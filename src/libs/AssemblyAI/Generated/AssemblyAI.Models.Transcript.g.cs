
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A transcript object
    /// </summary>
    public sealed partial class Transcript
    {
        /// <summary>
        /// The number of audio channels in the audio file. This is only present when [multichannel](https://www.assemblyai.com/docs/pre-recorded-audio/transcribe-multiple-audio-channels) is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_channels")]
        public int? AudioChannels { get; set; }

        /// <summary>
        /// The duration of this transcript object's media file, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        public int? AudioDuration { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, in the file at which the transcription was terminated. See [Set the start and end of the transcript](https://www.assemblyai.com/docs/pre-recorded-audio/set-the-start-and-end-of-the-transcript) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_at")]
        public int? AudioEndAt { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, in the file at which the transcription was started. See [Set the start and end of the transcript](https://www.assemblyai.com/docs/pre-recorded-audio/set-the-start-and-end-of-the-transcript) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_from")]
        public int? AudioStartFrom { get; set; }

        /// <summary>
        /// The URL of the media that was transcribed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// Whether [Auto Chapters](https://www.assemblyai.com/docs/speech-understanding/create-summarized-chapters) is enabled, can be true or false. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible chapter summaries. See the [updated Auto Chapters page](https://www.assemblyai.com/docs/speech-understanding/create-summarized-chapters) for details.<br/>
        /// Note: This parameter is only supported for the Universal-2 model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_chapters")]
        public bool? AutoChapters { get; set; }

        /// <summary>
        /// Whether [Key Phrases](https://www.assemblyai.com/docs/speech-understanding/identify-highlights) is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_highlights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoHighlights { get; set; }

        /// <summary>
        /// An array of results for the Key Phrases model, if it is enabled.<br/>
        /// See [Key Phrases](https://www.assemblyai.com/docs/speech-understanding/identify-highlights) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_highlights_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.AutoHighlightsResult, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.AutoHighlightsResult, object>? AutoHighlightsResult { get; set; }

        /// <summary>
        /// An array of temporally sequential chapters for the audio file. See [Auto Chapters](https://www.assemblyai.com/docs/speech-understanding/create-summarized-chapters) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapters")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.Chapter>? Chapters { get; set; }

        /// <summary>
        /// The confidence score for the transcript, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Whether [Content Moderation](https://www.assemblyai.com/docs/content-moderation) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety")]
        public bool? ContentSafety { get; set; }

        /// <summary>
        /// An array of results for the Content Moderation model, if it is enabled.<br/>
        /// See [Content moderation](https://www.assemblyai.com/docs/content-moderation) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety_labels")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.ContentSafetyLabelsResult, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.ContentSafetyLabelsResult, object>? ContentSafetyLabels { get; set; }

        /// <summary>
        /// Customize how words are spelled and formatted using to and from values. See [Custom Spelling](https://www.assemblyai.com/docs/pre-recorded-audio/correct-spelling-of-terms) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_spelling")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? CustomSpelling { get; set; }

        /// <summary>
        /// Transcribe [Filler Words](https://www.assemblyai.com/docs/pre-recorded-audio/include-filler-words), like "umm", in your media file; can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disfluencies")]
        public bool? Disfluencies { get; set; }

        /// <summary>
        /// The domain-specific model applied to the transcript. When set to `"medical-v1"`, [Medical Mode](https://www.assemblyai.com/docs/pre-recorded-audio/medical-mode) was used to improve accuracy for medical terminology.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// An array of results for the Entity Detection model, if it is enabled.<br/>
        /// See [Entity detection](https://www.assemblyai.com/docs/speech-understanding/detect-entities-in-transcript) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.Entity>? Entities { get; set; }

        /// <summary>
        /// Whether [Entity Detection](https://www.assemblyai.com/docs/speech-understanding/detect-entities-in-transcript) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_detection")]
        public bool? EntityDetection { get; set; }

        /// <summary>
        /// Error message of why the transcript failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Whether [Profanity Filtering](https://www.assemblyai.com/docs/profanity-filtering) is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_profanity")]
        public bool? FilterProfanity { get; set; }

        /// <summary>
        /// Whether [Text Formatting](https://www.assemblyai.com/docs/pre-recorded-audio) is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_text")]
        public bool? FormatText { get; set; }

        /// <summary>
        /// Whether [Topic Detection](https://www.assemblyai.com/docs/speech-understanding/detect-discussion-topics) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iab_categories")]
        public bool? IabCategories { get; set; }

        /// <summary>
        /// The result of the Topic Detection model, if it is enabled.<br/>
        /// See [Topic Detection](https://www.assemblyai.com/docs/speech-understanding/detect-discussion-topics) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iab_categories_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TopicDetectionModelResult, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.TopicDetectionModelResult, object>? IabCategoriesResult { get; set; }

        /// <summary>
        /// The unique identifier of your transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Improve accuracy with up to 200 (for Universal-2) or 1000 (for Universal-3 Pro) domain-specific words or phrases (maximum 6 words per phrase). See [Keyterms Prompting](https://www.assemblyai.com/docs/pre-recorded-audio/keyterms-prompting) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms_prompt")]
        public global::System.Collections.Generic.IList<string>? KeytermsPrompt { get; set; }

        /// <summary>
        /// The language of your audio file.<br/>
        /// Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/pre-recorded-audio/supported-languages).<br/>
        /// The default value is 'en_us'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptLanguageCodeJsonConverter))]
        public global::AssemblyAI.TranscriptLanguageCode? LanguageCode { get; set; }

        /// <summary>
        /// The language codes of your audio file. Used for [Code switching](/docs/speech-to-text/pre-recorded-audio/code-switching)<br/>
        /// One of the values specified must be `en`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_codes")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptLanguageCode>? LanguageCodes { get; set; }

        /// <summary>
        /// The confidence score for the detected language, between 0.0 (low confidence) and 1.0 (high confidence). See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence")]
        public double? LanguageConfidence { get; set; }

        /// <summary>
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence_threshold")]
        public double? LanguageConfidenceThreshold { get; set; }

        /// <summary>
        /// Whether [Automatic language detection](/docs/pre-recorded-audio/automatic-language-detection) is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public bool? LanguageDetection { get; set; }

        /// <summary>
        /// Specify options for [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection_options")]
        public global::AssemblyAI.TranscriptLanguageDetectionOptions? LanguageDetectionOptions { get; set; }

        /// <summary>
        /// Whether [Multichannel transcription](https://www.assemblyai.com/docs/pre-recorded-audio/transcribe-multiple-audio-channels) was enabled in the transcription request, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multichannel")]
        public bool? Multichannel { get; set; }

        /// <summary>
        /// Provide natural language prompting of up to 1,500 words of contextual information to the model. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for best practices.<br/>
        /// Note: This parameter is only supported for the Universal-3 Pro model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Whether [Automatic Punctuation](https://www.assemblyai.com/docs/pre-recorded-audio) is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuate")]
        public bool? Punctuate { get; set; }

        /// <summary>
        /// Whether [PII Redaction](https://www.assemblyai.com/docs/pii-redaction) is enabled, either true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RedactPii { get; set; }

        /// <summary>
        /// Whether a redacted version of the audio file was generated,<br/>
        /// either true or false. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio")]
        public bool? RedactPiiAudio { get; set; }

        /// <summary>
        /// The options for PII-redacted audio, if redact_pii_audio is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio_options")]
        public global::AssemblyAI.TranscriptRedactPiiAudioOptions? RedactPiiAudioOptions { get; set; }

        /// <summary>
        /// The audio quality of the PII-redacted audio file, if redact_pii_audio is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.RedactPiiAudioQuality?, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.RedactPiiAudioQuality?, object>? RedactPiiAudioQuality { get; set; }

        /// <summary>
        /// The list of PII Redaction policies that were enabled, if PII Redaction is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_policies")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? RedactPiiPolicies { get; set; }

        /// <summary>
        /// The replacement logic for detected PII, can be `entity_type` or `hash`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_sub")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SubstitutionPolicyJsonConverter))]
        public global::AssemblyAI.SubstitutionPolicy? RedactPiiSub { get; set; }

        /// <summary>
        /// Whether the original unredacted transcript was also returned alongside the redacted one. When `true`, the response includes `unredacted_text`, `unredacted_words`, and `unredacted_utterances`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_return_unredacted")]
        public bool? RedactPiiReturnUnredacted { get; set; }

        /// <summary>
        /// Whether [Sentiment Analysis](https://www.assemblyai.com/docs/speech-understanding/analyze-sentiment-of-speech) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public bool? SentimentAnalysis { get; set; }

        /// <summary>
        /// An array of results for the Sentiment Analysis model, if it is enabled.<br/>
        /// See [Sentiment Analysis](https://www.assemblyai.com/docs/speech-understanding/analyze-sentiment-of-speech) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis_results")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.SentimentAnalysisResult>? SentimentAnalysisResults { get; set; }

        /// <summary>
        /// Whether [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers) is enabled, can be true or false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_labels")]
        public bool? SpeakerLabels { get; set; }

        /// <summary>
        /// Tell the speaker label model how many speakers it should attempt to identify. See [Set number of speakers expected](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-number-of-speakers-expected) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers_expected")]
        public int? SpeakersExpected { get; set; }

        /// <summary>
        /// The speech model that was actually used for the transcription. See [Model Selection](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model) for available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_model_used")]
        public string? SpeechModelUsed { get; set; }

        /// <summary>
        /// List multiple speech models in priority order, allowing our system to automatically route your audio to the best available option. See [Model Selection](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model) for available models and routing behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_models")]
        public global::System.Collections.Generic.IList<string>? SpeechModels { get; set; }

        /// <summary>
        /// Defaults to null. Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive. See [Speech Threshold](https://www.assemblyai.com/docs/speech-threshold) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_threshold")]
        public double? SpeechThreshold { get; set; }

        /// <summary>
        /// Speech understanding tasks like [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). See the task-specific docs for available options and configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_understanding")]
        public global::AssemblyAI.TranscriptSpeechUnderstanding? SpeechUnderstanding { get; set; }

        /// <summary>
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.TranscriptStatus Status { get; set; }

        /// <summary>
        /// Whether [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) is enabled, either true or false. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.<br/>
        /// Note: This parameter is only supported for the Universal-2 model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Summarization { get; set; }

        /// <summary>
        /// The generated summary of the media file, if [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) is enabled. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The Summarization model used to generate the summary,<br/>
        /// if [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts#summary-models) is enabled. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_model")]
        public string? SummaryModel { get; set; }

        /// <summary>
        /// The type of summary generated, if [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts#summary-types) is enabled. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_type")]
        public string? SummaryType { get; set; }

        /// <summary>
        /// Whether [audio event tags](https://www.assemblyai.com/docs/pre-recorded-audio/universal-3-pro#audio-event-tags) were removed from the transcript text.<br/>
        /// Note: This parameter is only supported for the Universal-3 Pro model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_audio_tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranscriptRemoveAudioTags?, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptRemoveAudioTags?, object>? RemoveAudioTags { get; set; }

        /// <summary>
        /// The temperature that was used for the model's response. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for more details.<br/>
        /// Note: This parameter can only be used with the Universal-3 Pro model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The textual transcript of your media file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The original textual transcript of your media file before PII redaction was applied. Only returned when `redact_pii_return_unredacted` was set to `true` on the transcription request, otherwise this field is omitted and the `text` field remains fully redacted. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unredacted_text")]
        public string? UnredactedText { get; set; }

        /// <summary>
        /// True while a request is throttled and false when a request is no longer throttled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throttled")]
        public bool? Throttled { get; set; }

        /// <summary>
        /// When multichannel or speaker_labels is enabled, a list of turn-by-turn utterance objects.<br/>
        /// See [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers) and [Multichannel transcription](https://www.assemblyai.com/docs/pre-recorded-audio/transcribe-multiple-audio-channels) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>? Utterances { get; set; }

        /// <summary>
        /// The original turn-by-turn utterance objects before PII redaction was applied. Same shape as `utterances`. Only returned when `redact_pii_return_unredacted` was set to `true` on the transcription request, otherwise this field is omitted and the `utterances` field remains fully redacted. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unredacted_utterances")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>? UnredactedUtterances { get; set; }

        /// <summary>
        /// Whether [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) authentication details were provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WebhookAuth { get; set; }

        /// <summary>
        /// The header name to be sent with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_name")]
        public string? WebhookAuthHeaderName { get; set; }

        /// <summary>
        /// The status code we received from your server when delivering the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) request, if a webhook URL was provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_status_code")]
        public int? WebhookStatusCode { get; set; }

        /// <summary>
        /// The URL to which we send [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// An array of temporally-sequential word objects, one for each word in the transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>? Words { get; set; }

        /// <summary>
        /// The original temporally-sequential word objects before PII redaction was applied. Same shape as `words`. Only returned when `redact_pii_return_unredacted` was set to `true` on the transcription request, otherwise this field is omitted and the `words` field remains fully redacted. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unredacted_words")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>? UnredactedWords { get; set; }

        /// <summary>
        /// This parameter does not currently have any functionality attached to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acoustic_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AcousticModel { get; set; }

        /// <summary>
        /// This parameter does not currently have any functionality attached to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_topics")]
        public bool? CustomTopics { get; set; }

        /// <summary>
        /// This parameter does not currently have any functionality attached to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguageModel { get; set; }

        /// <summary>
        /// This parameter has been replaced with the `speech_models` parameter, learn more about the `speech_models` parameter [here](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.OneOf<string, object> SpeechModel { get; set; }

        /// <summary>
        /// This parameter does not currently have any functionality attached to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_boost")]
        public bool? SpeedBoost { get; set; }

        /// <summary>
        /// This parameter does not currently have any functionality attached to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// Translated text keyed by language code. See [Translation](https://www.assemblyai.com/docs/speech-understanding/translation) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translated_texts")]
        public global::AssemblyAI.TranscriptTranslatedTexts? TranslatedTexts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// The URL of the media that was transcribed
        /// </param>
        /// <param name="autoHighlights">
        /// Whether [Key Phrases](https://www.assemblyai.com/docs/speech-understanding/identify-highlights) is enabled, either true or false
        /// </param>
        /// <param name="id">
        /// The unique identifier of your transcript
        /// </param>
        /// <param name="redactPii">
        /// Whether [PII Redaction](https://www.assemblyai.com/docs/pii-redaction) is enabled, either true or false
        /// </param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="summarization">
        /// Whether [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) is enabled, either true or false. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.<br/>
        /// Note: This parameter is only supported for the Universal-2 model.
        /// </param>
        /// <param name="webhookAuth">
        /// Whether [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) authentication details were provided
        /// </param>
        /// <param name="acousticModel">
        /// This parameter does not currently have any functionality attached to it.
        /// </param>
        /// <param name="languageModel">
        /// This parameter does not currently have any functionality attached to it.
        /// </param>
        /// <param name="speechModel">
        /// This parameter has been replaced with the `speech_models` parameter, learn more about the `speech_models` parameter [here](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model).
        /// </param>
        /// <param name="audioChannels">
        /// The number of audio channels in the audio file. This is only present when [multichannel](https://www.assemblyai.com/docs/pre-recorded-audio/transcribe-multiple-audio-channels) is enabled.
        /// </param>
        /// <param name="audioDuration">
        /// The duration of this transcript object's media file, in seconds
        /// </param>
        /// <param name="audioEndAt">
        /// The point in time, in milliseconds, in the file at which the transcription was terminated. See [Set the start and end of the transcript](https://www.assemblyai.com/docs/pre-recorded-audio/set-the-start-and-end-of-the-transcript) for more details.
        /// </param>
        /// <param name="audioStartFrom">
        /// The point in time, in milliseconds, in the file at which the transcription was started. See [Set the start and end of the transcript](https://www.assemblyai.com/docs/pre-recorded-audio/set-the-start-and-end-of-the-transcript) for more details.
        /// </param>
        /// <param name="autoChapters">
        /// Whether [Auto Chapters](https://www.assemblyai.com/docs/speech-understanding/create-summarized-chapters) is enabled, can be true or false. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible chapter summaries. See the [updated Auto Chapters page](https://www.assemblyai.com/docs/speech-understanding/create-summarized-chapters) for details.<br/>
        /// Note: This parameter is only supported for the Universal-2 model.
        /// </param>
        /// <param name="autoHighlightsResult">
        /// An array of results for the Key Phrases model, if it is enabled.<br/>
        /// See [Key Phrases](https://www.assemblyai.com/docs/speech-understanding/identify-highlights) for more information.
        /// </param>
        /// <param name="chapters">
        /// An array of temporally sequential chapters for the audio file. See [Auto Chapters](https://www.assemblyai.com/docs/speech-understanding/create-summarized-chapters) for more information.
        /// </param>
        /// <param name="confidence">
        /// The confidence score for the transcript, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </param>
        /// <param name="contentSafety">
        /// Whether [Content Moderation](https://www.assemblyai.com/docs/content-moderation) is enabled, can be true or false
        /// </param>
        /// <param name="contentSafetyLabels">
        /// An array of results for the Content Moderation model, if it is enabled.<br/>
        /// See [Content moderation](https://www.assemblyai.com/docs/content-moderation) for more information.
        /// </param>
        /// <param name="customSpelling">
        /// Customize how words are spelled and formatted using to and from values. See [Custom Spelling](https://www.assemblyai.com/docs/pre-recorded-audio/correct-spelling-of-terms) for more details.
        /// </param>
        /// <param name="disfluencies">
        /// Transcribe [Filler Words](https://www.assemblyai.com/docs/pre-recorded-audio/include-filler-words), like "umm", in your media file; can be true or false
        /// </param>
        /// <param name="domain">
        /// The domain-specific model applied to the transcript. When set to `"medical-v1"`, [Medical Mode](https://www.assemblyai.com/docs/pre-recorded-audio/medical-mode) was used to improve accuracy for medical terminology.
        /// </param>
        /// <param name="entities">
        /// An array of results for the Entity Detection model, if it is enabled.<br/>
        /// See [Entity detection](https://www.assemblyai.com/docs/speech-understanding/detect-entities-in-transcript) for more information.
        /// </param>
        /// <param name="entityDetection">
        /// Whether [Entity Detection](https://www.assemblyai.com/docs/speech-understanding/detect-entities-in-transcript) is enabled, can be true or false
        /// </param>
        /// <param name="error">
        /// Error message of why the transcript failed
        /// </param>
        /// <param name="filterProfanity">
        /// Whether [Profanity Filtering](https://www.assemblyai.com/docs/profanity-filtering) is enabled, either true or false
        /// </param>
        /// <param name="formatText">
        /// Whether [Text Formatting](https://www.assemblyai.com/docs/pre-recorded-audio) is enabled, either true or false
        /// </param>
        /// <param name="iabCategories">
        /// Whether [Topic Detection](https://www.assemblyai.com/docs/speech-understanding/detect-discussion-topics) is enabled, can be true or false
        /// </param>
        /// <param name="iabCategoriesResult">
        /// The result of the Topic Detection model, if it is enabled.<br/>
        /// See [Topic Detection](https://www.assemblyai.com/docs/speech-understanding/detect-discussion-topics) for more information.
        /// </param>
        /// <param name="keytermsPrompt">
        /// Improve accuracy with up to 200 (for Universal-2) or 1000 (for Universal-3 Pro) domain-specific words or phrases (maximum 6 words per phrase). See [Keyterms Prompting](https://www.assemblyai.com/docs/pre-recorded-audio/keyterms-prompting) for more details.
        /// </param>
        /// <param name="languageCode">
        /// The language of your audio file.<br/>
        /// Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/pre-recorded-audio/supported-languages).<br/>
        /// The default value is 'en_us'.
        /// </param>
        /// <param name="languageCodes">
        /// The language codes of your audio file. Used for [Code switching](/docs/speech-to-text/pre-recorded-audio/code-switching)<br/>
        /// One of the values specified must be `en`.
        /// </param>
        /// <param name="languageConfidence">
        /// The confidence score for the detected language, between 0.0 (low confidence) and 1.0 (high confidence). See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.
        /// </param>
        /// <param name="languageConfidenceThreshold">
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.
        /// </param>
        /// <param name="languageDetection">
        /// Whether [Automatic language detection](/docs/pre-recorded-audio/automatic-language-detection) is enabled, either true or false
        /// </param>
        /// <param name="languageDetectionOptions">
        /// Specify options for [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection).
        /// </param>
        /// <param name="multichannel">
        /// Whether [Multichannel transcription](https://www.assemblyai.com/docs/pre-recorded-audio/transcribe-multiple-audio-channels) was enabled in the transcription request, either true or false
        /// </param>
        /// <param name="prompt">
        /// Provide natural language prompting of up to 1,500 words of contextual information to the model. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for best practices.<br/>
        /// Note: This parameter is only supported for the Universal-3 Pro model.
        /// </param>
        /// <param name="punctuate">
        /// Whether [Automatic Punctuation](https://www.assemblyai.com/docs/pre-recorded-audio) is enabled, either true or false
        /// </param>
        /// <param name="redactPiiAudio">
        /// Whether a redacted version of the audio file was generated,<br/>
        /// either true or false. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more information.
        /// </param>
        /// <param name="redactPiiAudioOptions">
        /// The options for PII-redacted audio, if redact_pii_audio is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more information.
        /// </param>
        /// <param name="redactPiiAudioQuality">
        /// The audio quality of the PII-redacted audio file, if redact_pii_audio is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more information.
        /// </param>
        /// <param name="redactPiiPolicies">
        /// The list of PII Redaction policies that were enabled, if PII Redaction is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more information.
        /// </param>
        /// <param name="redactPiiSub">
        /// The replacement logic for detected PII, can be `entity_type` or `hash`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.
        /// </param>
        /// <param name="redactPiiReturnUnredacted">
        /// Whether the original unredacted transcript was also returned alongside the redacted one. When `true`, the response includes `unredacted_text`, `unredacted_words`, and `unredacted_utterances`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more information.
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Whether [Sentiment Analysis](https://www.assemblyai.com/docs/speech-understanding/analyze-sentiment-of-speech) is enabled, can be true or false
        /// </param>
        /// <param name="sentimentAnalysisResults">
        /// An array of results for the Sentiment Analysis model, if it is enabled.<br/>
        /// See [Sentiment Analysis](https://www.assemblyai.com/docs/speech-understanding/analyze-sentiment-of-speech) for more information.
        /// </param>
        /// <param name="speakerLabels">
        /// Whether [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers) is enabled, can be true or false
        /// </param>
        /// <param name="speakersExpected">
        /// Tell the speaker label model how many speakers it should attempt to identify. See [Set number of speakers expected](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-number-of-speakers-expected) for more details.
        /// </param>
        /// <param name="speechModelUsed">
        /// The speech model that was actually used for the transcription. See [Model Selection](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model) for available models.
        /// </param>
        /// <param name="speechModels">
        /// List multiple speech models in priority order, allowing our system to automatically route your audio to the best available option. See [Model Selection](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model) for available models and routing behavior.
        /// </param>
        /// <param name="speechThreshold">
        /// Defaults to null. Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive. See [Speech Threshold](https://www.assemblyai.com/docs/speech-threshold) for more details.
        /// </param>
        /// <param name="speechUnderstanding">
        /// Speech understanding tasks like [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). See the task-specific docs for available options and configuration.
        /// </param>
        /// <param name="summary">
        /// The generated summary of the media file, if [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) is enabled. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.
        /// </param>
        /// <param name="summaryModel">
        /// The Summarization model used to generate the summary,<br/>
        /// if [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts#summary-models) is enabled. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.
        /// </param>
        /// <param name="summaryType">
        /// The type of summary generated, if [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts#summary-types) is enabled. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.
        /// </param>
        /// <param name="removeAudioTags">
        /// Whether [audio event tags](https://www.assemblyai.com/docs/pre-recorded-audio/universal-3-pro#audio-event-tags) were removed from the transcript text.<br/>
        /// Note: This parameter is only supported for the Universal-3 Pro model.
        /// </param>
        /// <param name="temperature">
        /// The temperature that was used for the model's response. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for more details.<br/>
        /// Note: This parameter can only be used with the Universal-3 Pro model.
        /// </param>
        /// <param name="text">
        /// The textual transcript of your media file
        /// </param>
        /// <param name="unredactedText">
        /// The original textual transcript of your media file before PII redaction was applied. Only returned when `redact_pii_return_unredacted` was set to `true` on the transcription request, otherwise this field is omitted and the `text` field remains fully redacted. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more information.
        /// </param>
        /// <param name="throttled">
        /// True while a request is throttled and false when a request is no longer throttled
        /// </param>
        /// <param name="utterances">
        /// When multichannel or speaker_labels is enabled, a list of turn-by-turn utterance objects.<br/>
        /// See [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers) and [Multichannel transcription](https://www.assemblyai.com/docs/pre-recorded-audio/transcribe-multiple-audio-channels) for more information.
        /// </param>
        /// <param name="unredactedUtterances">
        /// The original turn-by-turn utterance objects before PII redaction was applied. Same shape as `utterances`. Only returned when `redact_pii_return_unredacted` was set to `true` on the transcription request, otherwise this field is omitted and the `utterances` field remains fully redacted. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more information.
        /// </param>
        /// <param name="webhookAuthHeaderName">
        /// The header name to be sent with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests
        /// </param>
        /// <param name="webhookStatusCode">
        /// The status code we received from your server when delivering the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) request, if a webhook URL was provided
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which we send [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests.
        /// </param>
        /// <param name="words">
        /// An array of temporally-sequential word objects, one for each word in the transcript.
        /// </param>
        /// <param name="unredactedWords">
        /// The original temporally-sequential word objects before PII redaction was applied. Same shape as `words`. Only returned when `redact_pii_return_unredacted` was set to `true` on the transcription request, otherwise this field is omitted and the `words` field remains fully redacted. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more information.
        /// </param>
        /// <param name="customTopics">
        /// This parameter does not currently have any functionality attached to it.
        /// </param>
        /// <param name="speedBoost">
        /// This parameter does not currently have any functionality attached to it.
        /// </param>
        /// <param name="topics">
        /// This parameter does not currently have any functionality attached to it.
        /// </param>
        /// <param name="translatedTexts">
        /// Translated text keyed by language code. See [Translation](https://www.assemblyai.com/docs/speech-understanding/translation) for more details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Transcript(
            string audioUrl,
            bool autoHighlights,
            global::System.Guid id,
            bool redactPii,
            global::AssemblyAI.TranscriptStatus status,
            bool summarization,
            bool webhookAuth,
            string acousticModel,
            string languageModel,
            global::AssemblyAI.OneOf<string, object> speechModel,
            int? audioChannels,
            int? audioDuration,
            int? audioEndAt,
            int? audioStartFrom,
            bool? autoChapters,
            global::AssemblyAI.OneOf<global::AssemblyAI.AutoHighlightsResult, object>? autoHighlightsResult,
            global::System.Collections.Generic.IList<global::AssemblyAI.Chapter>? chapters,
            double? confidence,
            bool? contentSafety,
            global::AssemblyAI.OneOf<global::AssemblyAI.ContentSafetyLabelsResult, object>? contentSafetyLabels,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? customSpelling,
            bool? disfluencies,
            string? domain,
            global::System.Collections.Generic.IList<global::AssemblyAI.Entity>? entities,
            bool? entityDetection,
            string? error,
            bool? filterProfanity,
            bool? formatText,
            bool? iabCategories,
            global::AssemblyAI.OneOf<global::AssemblyAI.TopicDetectionModelResult, object>? iabCategoriesResult,
            global::System.Collections.Generic.IList<string>? keytermsPrompt,
            global::AssemblyAI.TranscriptLanguageCode? languageCode,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptLanguageCode>? languageCodes,
            double? languageConfidence,
            double? languageConfidenceThreshold,
            bool? languageDetection,
            global::AssemblyAI.TranscriptLanguageDetectionOptions? languageDetectionOptions,
            bool? multichannel,
            string? prompt,
            bool? punctuate,
            bool? redactPiiAudio,
            global::AssemblyAI.TranscriptRedactPiiAudioOptions? redactPiiAudioOptions,
            global::AssemblyAI.OneOf<global::AssemblyAI.RedactPiiAudioQuality?, object>? redactPiiAudioQuality,
            global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? redactPiiPolicies,
            global::AssemblyAI.SubstitutionPolicy? redactPiiSub,
            bool? redactPiiReturnUnredacted,
            bool? sentimentAnalysis,
            global::System.Collections.Generic.IList<global::AssemblyAI.SentimentAnalysisResult>? sentimentAnalysisResults,
            bool? speakerLabels,
            int? speakersExpected,
            string? speechModelUsed,
            global::System.Collections.Generic.IList<string>? speechModels,
            double? speechThreshold,
            global::AssemblyAI.TranscriptSpeechUnderstanding? speechUnderstanding,
            string? summary,
            string? summaryModel,
            string? summaryType,
            global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptRemoveAudioTags?, object>? removeAudioTags,
            double? temperature,
            string? text,
            string? unredactedText,
            bool? throttled,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>? utterances,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptUtterance>? unredactedUtterances,
            string? webhookAuthHeaderName,
            int? webhookStatusCode,
            string? webhookUrl,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>? words,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord>? unredactedWords,
            bool? customTopics,
            bool? speedBoost,
            global::System.Collections.Generic.IList<string>? topics,
            global::AssemblyAI.TranscriptTranslatedTexts? translatedTexts)
        {
            this.AudioChannels = audioChannels;
            this.AudioDuration = audioDuration;
            this.AudioEndAt = audioEndAt;
            this.AudioStartFrom = audioStartFrom;
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.AutoChapters = autoChapters;
            this.AutoHighlights = autoHighlights;
            this.AutoHighlightsResult = autoHighlightsResult;
            this.Chapters = chapters;
            this.Confidence = confidence;
            this.ContentSafety = contentSafety;
            this.ContentSafetyLabels = contentSafetyLabels;
            this.CustomSpelling = customSpelling;
            this.Disfluencies = disfluencies;
            this.Domain = domain;
            this.Entities = entities;
            this.EntityDetection = entityDetection;
            this.Error = error;
            this.FilterProfanity = filterProfanity;
            this.FormatText = formatText;
            this.IabCategories = iabCategories;
            this.IabCategoriesResult = iabCategoriesResult;
            this.Id = id;
            this.KeytermsPrompt = keytermsPrompt;
            this.LanguageCode = languageCode;
            this.LanguageCodes = languageCodes;
            this.LanguageConfidence = languageConfidence;
            this.LanguageConfidenceThreshold = languageConfidenceThreshold;
            this.LanguageDetection = languageDetection;
            this.LanguageDetectionOptions = languageDetectionOptions;
            this.Multichannel = multichannel;
            this.Prompt = prompt;
            this.Punctuate = punctuate;
            this.RedactPii = redactPii;
            this.RedactPiiAudio = redactPiiAudio;
            this.RedactPiiAudioOptions = redactPiiAudioOptions;
            this.RedactPiiAudioQuality = redactPiiAudioQuality;
            this.RedactPiiPolicies = redactPiiPolicies;
            this.RedactPiiSub = redactPiiSub;
            this.RedactPiiReturnUnredacted = redactPiiReturnUnredacted;
            this.SentimentAnalysis = sentimentAnalysis;
            this.SentimentAnalysisResults = sentimentAnalysisResults;
            this.SpeakerLabels = speakerLabels;
            this.SpeakersExpected = speakersExpected;
            this.SpeechModelUsed = speechModelUsed;
            this.SpeechModels = speechModels;
            this.SpeechThreshold = speechThreshold;
            this.SpeechUnderstanding = speechUnderstanding;
            this.Status = status;
            this.Summarization = summarization;
            this.Summary = summary;
            this.SummaryModel = summaryModel;
            this.SummaryType = summaryType;
            this.RemoveAudioTags = removeAudioTags;
            this.Temperature = temperature;
            this.Text = text;
            this.UnredactedText = unredactedText;
            this.Throttled = throttled;
            this.Utterances = utterances;
            this.UnredactedUtterances = unredactedUtterances;
            this.WebhookAuth = webhookAuth;
            this.WebhookAuthHeaderName = webhookAuthHeaderName;
            this.WebhookStatusCode = webhookStatusCode;
            this.WebhookUrl = webhookUrl;
            this.Words = words;
            this.UnredactedWords = unredactedWords;
            this.AcousticModel = acousticModel ?? throw new global::System.ArgumentNullException(nameof(acousticModel));
            this.CustomTopics = customTopics;
            this.LanguageModel = languageModel ?? throw new global::System.ArgumentNullException(nameof(languageModel));
            this.SpeechModel = speechModel;
            this.SpeedBoost = speedBoost;
            this.Topics = topics;
            this.TranslatedTexts = translatedTexts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript" /> class.
        /// </summary>
        public Transcript()
        {
        }
    }
}