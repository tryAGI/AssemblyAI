
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The parameters for creating a transcript<br/>
    /// Example: {"speech_model":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","language_code":"en_us","language_detection":true,"language_confidence_threshold":0.7,"punctuate":true,"format_text":true,"multichannel":true,"webhook_url":"https://your-webhook-url.tld/path","webhook_auth_header_name":"webhook-secret","webhook_auth_header_value":"webhook-secret-value","auto_highlights":true,"audio_start_from":10,"audio_end_at":280,"filter_profanity":true,"redact_pii":true,"redact_pii_audio":true,"redact_pii_audio_quality":"mp3","redact_pii_policies":["us_social_security_number","credit_card_number"],"redact_pii_sub":"hash","speaker_labels":true,"speakers_expected":2,"content_safety":true,"iab_categories":true,"custom_spelling":[],"disfluencies":false,"sentiment_analysis":true,"auto_chapters":true,"entity_detection":true,"speech_threshold":0.5,"summarization":true,"summary_model":"informative","summary_type":"bullets","custom_topics":true,"topics":[],"remove_audio_tags":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","speech_understanding":{"request":{"translation":{"target_languages":["es","de"],"formal":true,"match_original_utterance":true}}}}
    /// </summary>
    public sealed partial class TranscriptOptionalParams
    {
        /// <summary>
        /// The point in time, in milliseconds, to stop transcribing in your media file. See [Set the start and end of the transcript](https://www.assemblyai.com/docs/pre-recorded-audio/set-the-start-and-end-of-the-transcript) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_at")]
        public int? AudioEndAt { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, to begin transcribing in your media file. See [Set the start and end of the transcript](https://www.assemblyai.com/docs/pre-recorded-audio/set-the-start-and-end-of-the-transcript) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_from")]
        public int? AudioStartFrom { get; set; }

        /// <summary>
        /// Enable [Auto Chapters](https://www.assemblyai.com/docs/speech-understanding/auto-chapters), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_chapters")]
        public bool? AutoChapters { get; set; }

        /// <summary>
        /// Enable [Key Phrases](https://www.assemblyai.com/docs/speech-understanding/key-phrases), either true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_highlights")]
        public bool? AutoHighlights { get; set; }

        /// <summary>
        /// Enable [Content Moderation](https://www.assemblyai.com/docs/content-moderation), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety")]
        public bool? ContentSafety { get; set; }

        /// <summary>
        /// The confidence threshold for the [Content Moderation](https://www.assemblyai.com/docs/content-moderation) model. Values must be between 25 and 100.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety_confidence")]
        public int? ContentSafetyConfidence { get; set; }

        /// <summary>
        /// Customize how words are spelled and formatted using to and from values. See [Custom Spelling](https://www.assemblyai.com/docs/pre-recorded-audio/custom-spelling) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_spelling")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? CustomSpelling { get; set; }

        /// <summary>
        /// Transcribe [Filler Words](https://www.assemblyai.com/docs/pre-recorded-audio/filler-words), like "umm", in your media file; can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disfluencies")]
        public bool? Disfluencies { get; set; }

        /// <summary>
        /// Enable [Entity Detection](https://www.assemblyai.com/docs/speech-understanding/entity-detection), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_detection")]
        public bool? EntityDetection { get; set; }

        /// <summary>
        /// Filter profanity from the transcribed text, can be true or false. See [Profanity Filtering](https://www.assemblyai.com/docs/profanity-filtering) for more details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_profanity")]
        public bool? FilterProfanity { get; set; }

        /// <summary>
        /// Enable [Text Formatting](https://www.assemblyai.com/docs/pre-recorded-audio), can be true or false<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_text")]
        public bool? FormatText { get; set; }

        /// <summary>
        /// Enable [Topic Detection](https://www.assemblyai.com/docs/speech-understanding/topic-detection), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iab_categories")]
        public bool? IabCategories { get; set; }

        /// <summary>
        /// Improve accuracy with up to 200 (for Universal-2) or 1000 (for Universal-3-Pro) domain-specific words or phrases (maximum 6 words per phrase). See [Keyterms Prompting](https://www.assemblyai.com/docs/pre-recorded-audio/keyterms-prompting) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms_prompt")]
        public global::System.Collections.Generic.IList<string>? KeytermsPrompt { get; set; }

        /// <summary>
        /// The language of your audio file. Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/pre-recorded-audio/supported-languages).<br/>
        /// The default value is 'en_us'.<br/>
        /// Default Value: en_us
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>? LanguageCode { get; set; }

        /// <summary>
        /// The language codes of your audio file. Used for [Code switching](/docs/speech-to-text/pre-recorded-audio/code-switching)<br/>
        /// One of the values specified must be `en`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_codes")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptLanguageCode>? LanguageCodes { get; set; }

        /// <summary>
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// Defaults to 0. See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence_threshold")]
        public float? LanguageConfidenceThreshold { get; set; }

        /// <summary>
        /// Enable [Automatic language detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection), either true or false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public bool? LanguageDetection { get; set; }

        /// <summary>
        /// Specify options for [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection_options")]
        public global::AssemblyAI.TranscriptOptionalParamsLanguageDetectionOptions? LanguageDetectionOptions { get; set; }

        /// <summary>
        /// Enable [Multichannel](https://www.assemblyai.com/docs/pre-recorded-audio/multichannel) transcription, can be true or false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multichannel")]
        public bool? Multichannel { get; set; }

        /// <summary>
        /// Provide natural language prompting of up to 1,500 words of contextual information to the model. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for best practices.<br/>
        /// Note: This parameter is only supported for the Universal-3-Pro model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Enable [Automatic Punctuation](https://www.assemblyai.com/docs/pre-recorded-audio), can be true or false<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuate")]
        public bool? Punctuate { get; set; }

        /// <summary>
        /// Redact PII from the transcribed text using the Redact PII model, can be true or false. See [PII Redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii")]
        public bool? RedactPii { get; set; }

        /// <summary>
        /// Generate a copy of the original media file with spoken PII "beeped" out, can be true or false. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio")]
        public bool? RedactPiiAudio { get; set; }

        /// <summary>
        /// Specify options for [PII redacted audio](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio_options")]
        public global::AssemblyAI.TranscriptOptionalParamsRedactPiiAudioOptions? RedactPiiAudioOptions { get; set; }

        /// <summary>
        /// Controls the filetype of the audio created by redact_pii_audio. Currently supports mp3 (default) and wav. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more details.<br/>
        /// Default Value: mp3<br/>
        /// Example: mp3
        /// </summary>
        /// <example>mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.RedactPiiAudioQualityJsonConverter))]
        public global::AssemblyAI.RedactPiiAudioQuality? RedactPiiAudioQuality { get; set; }

        /// <summary>
        /// The list of PII Redaction policies to enable. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_policies")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? RedactPiiPolicies { get; set; }

        /// <summary>
        /// The replacement logic for detected PII, can be `entity_type` or `hash`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: hash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_sub")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.SubstitutionPolicy?, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.SubstitutionPolicy?, object>? RedactPiiSub { get; set; }

        /// <summary>
        /// Enable [Sentiment Analysis](https://www.assemblyai.com/docs/speech-understanding/sentiment-analysis), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public bool? SentimentAnalysis { get; set; }

        /// <summary>
        /// Enable [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_labels")]
        public bool? SpeakerLabels { get; set; }

        /// <summary>
        /// Specify options for [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization#set-a-range-of-possible-speakers). Use this to set a range of possible speakers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_options")]
        public global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions? SpeakerOptions { get; set; }

        /// <summary>
        /// Tells the speaker label model how many speakers it should attempt to identify. See [Set number of speakers expected](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization#set-number-of-speakers-expected) for more details.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers_expected")]
        public int? SpeakersExpected { get; set; }

        /// <summary>
        /// List multiple speech models in priority order, allowing our system to automatically route your audio to the best available option. See [Model Selection](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model) for available models and routing behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SpeechModels { get; set; }

        /// <summary>
        /// Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive. See [Speech Threshold](https://www.assemblyai.com/docs/speech-threshold) for more details.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_threshold")]
        public float? SpeechThreshold { get; set; }

        /// <summary>
        /// Enable speech understanding tasks like [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). See the task-specific docs for available options and configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_understanding")]
        public global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstanding? SpeechUnderstanding { get; set; }

        /// <summary>
        /// Enable [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarization), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        public bool? Summarization { get; set; }

        /// <summary>
        /// The model to summarize the transcript. See [Summary models](https://www.assemblyai.com/docs/speech-understanding/summarization#summary-models) for available models and when to use each.<br/>
        /// Default Value: informative
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SummaryModelJsonConverter))]
        public global::AssemblyAI.SummaryModel? SummaryModel { get; set; }

        /// <summary>
        /// The type of summary. See [Summary types](https://www.assemblyai.com/docs/speech-understanding/summarization#summary-types) for descriptions of the available summary types.<br/>
        /// Default Value: bullets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SummaryTypeJsonConverter))]
        public global::AssemblyAI.SummaryType? SummaryType { get; set; }

        /// <summary>
        /// Remove [audio event tags](https://www.assemblyai.com/docs/pre-recorded-audio/universal-3-pro#audio-event-tags) from the transcript text. Set to `"all"` to remove all audio tags.<br/>
        /// Note: This parameter is only supported for the Universal-3-Pro model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_audio_tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>? RemoveAudioTags { get; set; }

        /// <summary>
        /// Control the amount of randomness injected into the model's response. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for more details.<br/>
        /// Note: This parameter can only be used with the Universal-3-Pro model.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The header name to be sent with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_name")]
        public string? WebhookAuthHeaderName { get; set; }

        /// <summary>
        /// The header value to send back with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests for added security<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_value")]
        public string? WebhookAuthHeaderValue { get; set; }

        /// <summary>
        /// The URL to which we send [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// This parameter does not currently have any functionality attached to it.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_topics")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? CustomTopics { get; set; }

        /// <summary>
        /// This parameter has been replaced with the `speech_models` parameter, learn more about the `speech_models` parameter [here](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::AssemblyAI.OneOf<string, object>? SpeechModel { get; set; }

        /// <summary>
        /// This parameter does not currently have any functionality attached to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParams" /> class.
        /// </summary>
        /// <param name="audioEndAt">
        /// The point in time, in milliseconds, to stop transcribing in your media file. See [Set the start and end of the transcript](https://www.assemblyai.com/docs/pre-recorded-audio/set-the-start-and-end-of-the-transcript) for more details.
        /// </param>
        /// <param name="audioStartFrom">
        /// The point in time, in milliseconds, to begin transcribing in your media file. See [Set the start and end of the transcript](https://www.assemblyai.com/docs/pre-recorded-audio/set-the-start-and-end-of-the-transcript) for more details.
        /// </param>
        /// <param name="autoChapters">
        /// Enable [Auto Chapters](https://www.assemblyai.com/docs/speech-understanding/auto-chapters), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoHighlights">
        /// Enable [Key Phrases](https://www.assemblyai.com/docs/speech-understanding/key-phrases), either true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="contentSafety">
        /// Enable [Content Moderation](https://www.assemblyai.com/docs/content-moderation), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="contentSafetyConfidence">
        /// The confidence threshold for the [Content Moderation](https://www.assemblyai.com/docs/content-moderation) model. Values must be between 25 and 100.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="customSpelling">
        /// Customize how words are spelled and formatted using to and from values. See [Custom Spelling](https://www.assemblyai.com/docs/pre-recorded-audio/custom-spelling) for more details.
        /// </param>
        /// <param name="disfluencies">
        /// Transcribe [Filler Words](https://www.assemblyai.com/docs/pre-recorded-audio/filler-words), like "umm", in your media file; can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="entityDetection">
        /// Enable [Entity Detection](https://www.assemblyai.com/docs/speech-understanding/entity-detection), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filterProfanity">
        /// Filter profanity from the transcribed text, can be true or false. See [Profanity Filtering](https://www.assemblyai.com/docs/profanity-filtering) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="formatText">
        /// Enable [Text Formatting](https://www.assemblyai.com/docs/pre-recorded-audio), can be true or false<br/>
        /// Default Value: true
        /// </param>
        /// <param name="iabCategories">
        /// Enable [Topic Detection](https://www.assemblyai.com/docs/speech-understanding/topic-detection), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keytermsPrompt">
        /// Improve accuracy with up to 200 (for Universal-2) or 1000 (for Universal-3-Pro) domain-specific words or phrases (maximum 6 words per phrase). See [Keyterms Prompting](https://www.assemblyai.com/docs/pre-recorded-audio/keyterms-prompting) for more details.
        /// </param>
        /// <param name="languageCode">
        /// The language of your audio file. Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/pre-recorded-audio/supported-languages).<br/>
        /// The default value is 'en_us'.<br/>
        /// Default Value: en_us
        /// </param>
        /// <param name="languageCodes">
        /// The language codes of your audio file. Used for [Code switching](/docs/speech-to-text/pre-recorded-audio/code-switching)<br/>
        /// One of the values specified must be `en`.
        /// </param>
        /// <param name="languageConfidenceThreshold">
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// Defaults to 0. See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="languageDetection">
        /// Enable [Automatic language detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection), either true or false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="languageDetectionOptions">
        /// Specify options for [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection).
        /// </param>
        /// <param name="multichannel">
        /// Enable [Multichannel](https://www.assemblyai.com/docs/pre-recorded-audio/multichannel) transcription, can be true or false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// Provide natural language prompting of up to 1,500 words of contextual information to the model. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for best practices.<br/>
        /// Note: This parameter is only supported for the Universal-3-Pro model.
        /// </param>
        /// <param name="punctuate">
        /// Enable [Automatic Punctuation](https://www.assemblyai.com/docs/pre-recorded-audio), can be true or false<br/>
        /// Default Value: true
        /// </param>
        /// <param name="redactPii">
        /// Redact PII from the transcribed text using the Redact PII model, can be true or false. See [PII Redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="redactPiiAudio">
        /// Generate a copy of the original media file with spoken PII "beeped" out, can be true or false. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="redactPiiAudioOptions">
        /// Specify options for [PII redacted audio](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) files.
        /// </param>
        /// <param name="redactPiiAudioQuality">
        /// Controls the filetype of the audio created by redact_pii_audio. Currently supports mp3 (default) and wav. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more details.<br/>
        /// Default Value: mp3<br/>
        /// Example: mp3
        /// </param>
        /// <param name="redactPiiPolicies">
        /// The list of PII Redaction policies to enable. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.
        /// </param>
        /// <param name="redactPiiSub">
        /// The replacement logic for detected PII, can be `entity_type` or `hash`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: hash
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Enable [Sentiment Analysis](https://www.assemblyai.com/docs/speech-understanding/sentiment-analysis), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speakerLabels">
        /// Enable [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speakerOptions">
        /// Specify options for [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization#set-a-range-of-possible-speakers). Use this to set a range of possible speakers.
        /// </param>
        /// <param name="speakersExpected">
        /// Tells the speaker label model how many speakers it should attempt to identify. See [Set number of speakers expected](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization#set-number-of-speakers-expected) for more details.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="speechModels">
        /// List multiple speech models in priority order, allowing our system to automatically route your audio to the best available option. See [Model Selection](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model) for available models and routing behavior.
        /// </param>
        /// <param name="speechThreshold">
        /// Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive. See [Speech Threshold](https://www.assemblyai.com/docs/speech-threshold) for more details.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="speechUnderstanding">
        /// Enable speech understanding tasks like [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). See the task-specific docs for available options and configuration.
        /// </param>
        /// <param name="summarization">
        /// Enable [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarization), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summaryModel">
        /// The model to summarize the transcript. See [Summary models](https://www.assemblyai.com/docs/speech-understanding/summarization#summary-models) for available models and when to use each.<br/>
        /// Default Value: informative
        /// </param>
        /// <param name="summaryType">
        /// The type of summary. See [Summary types](https://www.assemblyai.com/docs/speech-understanding/summarization#summary-types) for descriptions of the available summary types.<br/>
        /// Default Value: bullets
        /// </param>
        /// <param name="removeAudioTags">
        /// Remove [audio event tags](https://www.assemblyai.com/docs/pre-recorded-audio/universal-3-pro#audio-event-tags) from the transcript text. Set to `"all"` to remove all audio tags.<br/>
        /// Note: This parameter is only supported for the Universal-3-Pro model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="temperature">
        /// Control the amount of randomness injected into the model's response. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for more details.<br/>
        /// Note: This parameter can only be used with the Universal-3-Pro model.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="webhookAuthHeaderName">
        /// The header name to be sent with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="webhookAuthHeaderValue">
        /// The header value to send back with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests for added security<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which we send [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptOptionalParams(
            global::System.Collections.Generic.IList<string> speechModels,
            int? audioEndAt,
            int? audioStartFrom,
            bool? autoChapters,
            bool? autoHighlights,
            bool? contentSafety,
            int? contentSafetyConfidence,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? customSpelling,
            bool? disfluencies,
            bool? entityDetection,
            bool? filterProfanity,
            bool? formatText,
            bool? iabCategories,
            global::System.Collections.Generic.IList<string>? keytermsPrompt,
            global::AssemblyAI.OneOf<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>? languageCode,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptLanguageCode>? languageCodes,
            float? languageConfidenceThreshold,
            bool? languageDetection,
            global::AssemblyAI.TranscriptOptionalParamsLanguageDetectionOptions? languageDetectionOptions,
            bool? multichannel,
            string? prompt,
            bool? punctuate,
            bool? redactPii,
            bool? redactPiiAudio,
            global::AssemblyAI.TranscriptOptionalParamsRedactPiiAudioOptions? redactPiiAudioOptions,
            global::AssemblyAI.RedactPiiAudioQuality? redactPiiAudioQuality,
            global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? redactPiiPolicies,
            global::AssemblyAI.OneOf<global::AssemblyAI.SubstitutionPolicy?, object>? redactPiiSub,
            bool? sentimentAnalysis,
            bool? speakerLabels,
            global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions? speakerOptions,
            int? speakersExpected,
            float? speechThreshold,
            global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstanding? speechUnderstanding,
            bool? summarization,
            global::AssemblyAI.SummaryModel? summaryModel,
            global::AssemblyAI.SummaryType? summaryType,
            global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>? removeAudioTags,
            double? temperature,
            string? webhookAuthHeaderName,
            string? webhookAuthHeaderValue,
            string? webhookUrl)
        {
            this.SpeechModels = speechModels ?? throw new global::System.ArgumentNullException(nameof(speechModels));
            this.AudioEndAt = audioEndAt;
            this.AudioStartFrom = audioStartFrom;
            this.AutoChapters = autoChapters;
            this.AutoHighlights = autoHighlights;
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
            this.LanguageCodes = languageCodes;
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
            this.SentimentAnalysis = sentimentAnalysis;
            this.SpeakerLabels = speakerLabels;
            this.SpeakerOptions = speakerOptions;
            this.SpeakersExpected = speakersExpected;
            this.SpeechThreshold = speechThreshold;
            this.SpeechUnderstanding = speechUnderstanding;
            this.Summarization = summarization;
            this.SummaryModel = summaryModel;
            this.SummaryType = summaryType;
            this.RemoveAudioTags = removeAudioTags;
            this.Temperature = temperature;
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