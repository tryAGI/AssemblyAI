
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The parameters for creating a transcript<br/>
    /// Example: {"speech_model":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","language_detection":true,"language_confidence_threshold":0.7,"punctuate":true,"format_text":true,"multichannel":true,"webhook_url":"https://your-webhook-url.tld/path","webhook_auth_header_name":"webhook-secret","webhook_auth_header_value":"webhook-secret-value","auto_highlights":true,"audio_start_from":10,"audio_end_at":280,"filter_profanity":true,"redact_pii":true,"redact_pii_audio":true,"redact_pii_audio_quality":"mp3","redact_pii_policies":["us_social_security_number","credit_card_number"],"redact_pii_sub":"hash","speaker_labels":true,"speakers_expected":2,"content_safety":true,"iab_categories":true,"custom_spelling":[],"disfluencies":false,"sentiment_analysis":true,"auto_chapters":false,"entity_detection":true,"speech_threshold":0.5,"summarization":false,"summary_model":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","summary_type":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","custom_topics":true,"topics":[],"remove_audio_tags":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","domain":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","speech_understanding":{"request":{"translation":{"target_languages":["es","de"],"formal":true,"match_original_utterance":true}}}}
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
        /// Enable [Auto Chapters](https://www.assemblyai.com/docs/speech-understanding/auto-chapters), can be true or false. Requires `punctuate` to be `true`, and cannot be enabled together with `summarization`. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/quickstart) instead for more flexible chapter summaries. See the [updated Auto Chapters page](https://www.assemblyai.com/docs/speech-understanding/auto-chapters) for details.<br/>
        /// Note: This parameter is only supported for the Universal-2 model.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_chapters")]
        [global::System.Obsolete("This property marked as deprecated.")]
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
        /// The confidence threshold for the [Content Moderation](https://www.assemblyai.com/docs/content-moderation) model. Values must be between 25 and 100. Requires `content_safety` to be enabled; otherwise it's ignored.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety_confidence")]
        public int? ContentSafetyConfidence { get; set; }

        /// <summary>
        /// Customize how words are spelled and formatted using to and from values. Each `to` value must be a single word, and each `from` phrase can contain at most 5 words. See [Custom Spelling](https://www.assemblyai.com/docs/pre-recorded-audio/correct-spelling-of-terms) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_spelling")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? CustomSpelling { get; set; }

        /// <summary>
        /// Transcribe [Filler Words](https://www.assemblyai.com/docs/pre-recorded-audio/include-filler-words), like "umm", in your media file; can be true or false. Supported on Universal-3.5 Pro and Universal-2.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disfluencies")]
        public bool? Disfluencies { get; set; }

        /// <summary>
        /// Enable domain-specific transcription models to improve accuracy for specialized terminology. Set to `"medical-v1"` to enable [Medical Mode](https://www.assemblyai.com/docs/pre-recorded-audio/medical-mode) for improved accuracy of medical terms such as medications, procedures, conditions, and dosages.<br/>
        /// Supported languages: English (`en`), Spanish (`es`), German (`de`), French (`fr`). If `medical-v1` is used with an unsupported language, the parameter is ignored and a warning is returned.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.TranscriptOptionalParamsDomainJsonConverter))]
        public global::AssemblyAI.TranscriptOptionalParamsDomain? Domain { get; set; }

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
        /// Improve accuracy with up to 200 (for Universal-2) or 1000 (for Universal-3.5 Pro) domain-specific words or phrases (maximum 6 words per phrase). See [Keyterms Prompting](https://www.assemblyai.com/docs/pre-recorded-audio/universal-3-5-pro/prompting#keyterms-prompting) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms_prompt")]
        public global::System.Collections.Generic.IList<string>? KeytermsPrompt { get; set; }

        /// <summary>
        /// The language of your audio file. Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/pre-recorded-audio/supported-languages).<br/>
        /// If you don't specify a language, it's detected automatically. Cannot be used together with `language_detection`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.AnyOf<global::AssemblyAI.TranscriptLanguageCode?, string>?, object>? LanguageCode { get; set; }

        /// <summary>
        /// The language codes of your audio file. Used for [Code switching](/speech-to-text/pre-recorded-audio/code-switching)<br/>
        /// One of the values specified must be `en`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_codes")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptLanguageCode>? LanguageCodes { get; set; }

        /// <summary>
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// Defaults to 0. Can only be set when `language_detection` is enabled. See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence_threshold")]
        public float? LanguageConfidenceThreshold { get; set; }

        /// <summary>
        /// [Automatic language detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) identifies the spoken language and routes the request to the best model. It's applied automatically when you don't specify a `language_code`. Set to `false` only together with a `language_code`; disabling it without specifying a language returns an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public bool? LanguageDetection { get; set; }

        /// <summary>
        /// Specify options for [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection_options")]
        public global::AssemblyAI.TranscriptOptionalParamsLanguageDetectionOptions? LanguageDetectionOptions { get; set; }

        /// <summary>
        /// Enable [Multichannel](https://www.assemblyai.com/docs/pre-recorded-audio/transcribe-multiple-audio-channels) transcription, can be true or false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multichannel")]
        public bool? Multichannel { get; set; }

        /// <summary>
        /// Provide natural language prompting of up to 1,500 words of contextual information to the model. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for best practices.<br/>
        /// Note: This parameter is only supported for the Universal-3.5 Pro model.
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
        /// Redact PII from the transcribed text using the Redact PII model, can be true or false. Requires `format_text` to be `true`. See [PII Redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii")]
        public bool? RedactPii { get; set; }

        /// <summary>
        /// Generate a copy of the original media file with spoken PII "beeped" out, can be true or false. Requires `redact_pii` to be `true`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more details.<br/>
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
        /// The replacement logic for detected PII, can be `entity_name` or `hash`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: hash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_sub")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.SubstitutionPolicy?, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.SubstitutionPolicy?, object>? RedactPiiSub { get; set; }

        /// <summary>
        /// When set to `true`, returns the original unredacted transcript alongside the redacted one in the same response. Requires `redact_pii` to be `true`, otherwise a 400 error is returned.<br/>
        /// When enabled, the response includes the additional fields `unredacted_text`, `unredacted_words`, and `unredacted_utterances`. The existing `text`, `words`, and `utterances` fields remain fully redacted. When disabled (default), the response is unchanged and contains only the redacted transcript. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_return_unredacted")]
        public bool? RedactPiiReturnUnredacted { get; set; }

        /// <summary>
        /// A map of user-defined terms to redact, where each key is a redaction label and each value is a list of exact terms to match (e.g. `{ "INTERNAL_TOOL": ["Bearclaw", "Cubclaw"] }`). Each matching term in the transcript is redacted using the `redact_pii_sub` substitution, on top of standard PII Redaction. Useful for redacting specific, predefined terms (proprietary names, internal codenames) that aren't general PII categories.<br/>
        /// This is a literal find-and-replace (tolerant of casing, surrounding punctuation, and minor spacing/hyphenation), not a model — it does not generalize beyond the terms you provide. Requires `redact_pii` to be `true`, otherwise a 400 error is returned. When `redact_pii_audio` is enabled, matched terms are also redacted in the audio output. You can provide up to 100 labels, each with up to 200 terms of at most 200 characters; a label may contain only letters, numbers, spaces, underscores, and hyphens (max 80 characters). See [Static Entity Redaction](https://www.assemblyai.com/docs/guardrails/redact-pii-from-transcripts#static-entity-redaction) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_static_entities")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? RedactStaticEntities { get; set; }

        /// <summary>
        /// Enable [Sentiment Analysis](https://www.assemblyai.com/docs/speech-understanding/sentiment-analysis), can be true or false. Requires `punctuate` to be `true`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public bool? SentimentAnalysis { get; set; }

        /// <summary>
        /// Enable [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers), can be true or false. Requires `punctuate` to be `true`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_labels")]
        public bool? SpeakerLabels { get; set; }

        /// <summary>
        /// Specify options for [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-a-range-of-possible-speakers). Use this to set a range of possible speakers. Requires `speaker_labels` to be `true`, and cannot be used together with `speakers_expected`. When both bounds are set, `min_speakers_expected` must be less than or equal to `max_speakers_expected`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_options")]
        public global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions? SpeakerOptions { get; set; }

        /// <summary>
        /// Tells the speaker label model how many speakers it should attempt to identify. Requires `speaker_labels` to be `true` and must be a positive integer; cannot be used together with `speaker_options`. See [Set number of speakers expected](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-number-of-speakers-expected) for more details.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers_expected")]
        public int? SpeakersExpected { get; set; }

        /// <summary>
        /// Optional. Supported values: `universal-3-5-pro`, `universal-2`. If omitted, defaults to `["universal-3-5-pro", "universal-2"]`. See [Model Selection](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model) for available models and routing behavior.<br/>
        /// Default Value: [universal-3-5-pro, universal-2]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_models")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.SpeechModel2>? SpeechModels { get; set; }

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
        /// Enable [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarization), can be true or false. Requires both `punctuate` and `format_text` to be `true`, and cannot be enabled together with `auto_chapters`. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/quickstart) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarization) for details.<br/>
        /// Note: This parameter is only supported for the Universal-2 model.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Summarization { get; set; }

        /// <summary>
        /// The model to summarize the transcript. Must be set together with `summary_type`. Compatibility - `catchy` supports `gist` and `headline`; `informative` and `conversational` support `headline`, `paragraph`, `bullets`, and `bullets_verbose`. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/quickstart) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarization) for details.<br/>
        /// Default Value: informative
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SummaryModelJsonConverter))]
        public global::AssemblyAI.SummaryModel? SummaryModel { get; set; }

        /// <summary>
        /// The type of summary. Must be set together with `summary_model`; see `summary_model` for the supported model and type combinations. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/quickstart) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarization) for details.<br/>
        /// Default Value: bullets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SummaryTypeJsonConverter))]
        public global::AssemblyAI.SummaryType? SummaryType { get; set; }

        /// <summary>
        /// Universal-3.5 Pro generates rich transcripts that can include inline annotations such as audio event markers and speaker cues. Set to `"all"` to remove all inline annotations, or `"speaker"` to remove only speaker cues while keeping other annotations. By default, all inline annotations are removed.<br/>
        /// Note: This parameter is only supported for the Universal-3.5 Pro model.<br/>
        /// Default Value: all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_audio_tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>? RemoveAudioTags { get; set; }

        /// <summary>
        /// Control the amount of randomness injected into the model's response. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for more details.<br/>
        /// Note: This parameter only takes effect on the Universal-3.5 Pro model.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The header name to be sent with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests. Must be 1-1000 characters and contain only ASCII letters, numbers, hyphens, and underscores. Requires `webhook_auth_header_value` and `webhook_url` to also be set.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_name")]
        public string? WebhookAuthHeaderName { get; set; }

        /// <summary>
        /// The header value to send back with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests for added security. Must be 1-1000 characters and must not contain carriage returns or newlines. Requires `webhook_auth_header_name` and `webhook_url` to also be set.<br/>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<global::AssemblyAI.SpeechModel2?, object>))]
        public global::AssemblyAI.OneOf<global::AssemblyAI.SpeechModel2?, object>? SpeechModel { get; set; }

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
        /// <param name="autoHighlights">
        /// Enable [Key Phrases](https://www.assemblyai.com/docs/speech-understanding/key-phrases), either true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="contentSafety">
        /// Enable [Content Moderation](https://www.assemblyai.com/docs/content-moderation), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="contentSafetyConfidence">
        /// The confidence threshold for the [Content Moderation](https://www.assemblyai.com/docs/content-moderation) model. Values must be between 25 and 100. Requires `content_safety` to be enabled; otherwise it's ignored.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="customSpelling">
        /// Customize how words are spelled and formatted using to and from values. Each `to` value must be a single word, and each `from` phrase can contain at most 5 words. See [Custom Spelling](https://www.assemblyai.com/docs/pre-recorded-audio/correct-spelling-of-terms) for more details.
        /// </param>
        /// <param name="disfluencies">
        /// Transcribe [Filler Words](https://www.assemblyai.com/docs/pre-recorded-audio/include-filler-words), like "umm", in your media file; can be true or false. Supported on Universal-3.5 Pro and Universal-2.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="domain">
        /// Enable domain-specific transcription models to improve accuracy for specialized terminology. Set to `"medical-v1"` to enable [Medical Mode](https://www.assemblyai.com/docs/pre-recorded-audio/medical-mode) for improved accuracy of medical terms such as medications, procedures, conditions, and dosages.<br/>
        /// Supported languages: English (`en`), Spanish (`es`), German (`de`), French (`fr`). If `medical-v1` is used with an unsupported language, the parameter is ignored and a warning is returned.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        /// Improve accuracy with up to 200 (for Universal-2) or 1000 (for Universal-3.5 Pro) domain-specific words or phrases (maximum 6 words per phrase). See [Keyterms Prompting](https://www.assemblyai.com/docs/pre-recorded-audio/universal-3-5-pro/prompting#keyterms-prompting) for more details.
        /// </param>
        /// <param name="languageCode">
        /// The language of your audio file. Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/pre-recorded-audio/supported-languages).<br/>
        /// If you don't specify a language, it's detected automatically. Cannot be used together with `language_detection`.
        /// </param>
        /// <param name="languageCodes">
        /// The language codes of your audio file. Used for [Code switching](/speech-to-text/pre-recorded-audio/code-switching)<br/>
        /// One of the values specified must be `en`.
        /// </param>
        /// <param name="languageConfidenceThreshold">
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// Defaults to 0. Can only be set when `language_detection` is enabled. See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="languageDetection">
        /// [Automatic language detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) identifies the spoken language and routes the request to the best model. It's applied automatically when you don't specify a `language_code`. Set to `false` only together with a `language_code`; disabling it without specifying a language returns an error.
        /// </param>
        /// <param name="languageDetectionOptions">
        /// Specify options for [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection).
        /// </param>
        /// <param name="multichannel">
        /// Enable [Multichannel](https://www.assemblyai.com/docs/pre-recorded-audio/transcribe-multiple-audio-channels) transcription, can be true or false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// Provide natural language prompting of up to 1,500 words of contextual information to the model. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for best practices.<br/>
        /// Note: This parameter is only supported for the Universal-3.5 Pro model.
        /// </param>
        /// <param name="punctuate">
        /// Enable [Automatic Punctuation](https://www.assemblyai.com/docs/pre-recorded-audio), can be true or false<br/>
        /// Default Value: true
        /// </param>
        /// <param name="redactPii">
        /// Redact PII from the transcribed text using the Redact PII model, can be true or false. Requires `format_text` to be `true`. See [PII Redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="redactPiiAudio">
        /// Generate a copy of the original media file with spoken PII "beeped" out, can be true or false. Requires `redact_pii` to be `true`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more details.<br/>
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
        /// The replacement logic for detected PII, can be `entity_name` or `hash`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: hash
        /// </param>
        /// <param name="redactPiiReturnUnredacted">
        /// When set to `true`, returns the original unredacted transcript alongside the redacted one in the same response. Requires `redact_pii` to be `true`, otherwise a 400 error is returned.<br/>
        /// When enabled, the response includes the additional fields `unredacted_text`, `unredacted_words`, and `unredacted_utterances`. The existing `text`, `words`, and `utterances` fields remain fully redacted. When disabled (default), the response is unchanged and contains only the redacted transcript. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="redactStaticEntities">
        /// A map of user-defined terms to redact, where each key is a redaction label and each value is a list of exact terms to match (e.g. `{ "INTERNAL_TOOL": ["Bearclaw", "Cubclaw"] }`). Each matching term in the transcript is redacted using the `redact_pii_sub` substitution, on top of standard PII Redaction. Useful for redacting specific, predefined terms (proprietary names, internal codenames) that aren't general PII categories.<br/>
        /// This is a literal find-and-replace (tolerant of casing, surrounding punctuation, and minor spacing/hyphenation), not a model — it does not generalize beyond the terms you provide. Requires `redact_pii` to be `true`, otherwise a 400 error is returned. When `redact_pii_audio` is enabled, matched terms are also redacted in the audio output. You can provide up to 100 labels, each with up to 200 terms of at most 200 characters; a label may contain only letters, numbers, spaces, underscores, and hyphens (max 80 characters). See [Static Entity Redaction](https://www.assemblyai.com/docs/guardrails/redact-pii-from-transcripts#static-entity-redaction) for more details.
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Enable [Sentiment Analysis](https://www.assemblyai.com/docs/speech-understanding/sentiment-analysis), can be true or false. Requires `punctuate` to be `true`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speakerLabels">
        /// Enable [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers), can be true or false. Requires `punctuate` to be `true`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speakerOptions">
        /// Specify options for [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-a-range-of-possible-speakers). Use this to set a range of possible speakers. Requires `speaker_labels` to be `true`, and cannot be used together with `speakers_expected`. When both bounds are set, `min_speakers_expected` must be less than or equal to `max_speakers_expected`.
        /// </param>
        /// <param name="speakersExpected">
        /// Tells the speaker label model how many speakers it should attempt to identify. Requires `speaker_labels` to be `true` and must be a positive integer; cannot be used together with `speaker_options`. See [Set number of speakers expected](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-number-of-speakers-expected) for more details.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="speechModels">
        /// Optional. Supported values: `universal-3-5-pro`, `universal-2`. If omitted, defaults to `["universal-3-5-pro", "universal-2"]`. See [Model Selection](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model) for available models and routing behavior.<br/>
        /// Default Value: [universal-3-5-pro, universal-2]
        /// </param>
        /// <param name="speechThreshold">
        /// Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive. See [Speech Threshold](https://www.assemblyai.com/docs/speech-threshold) for more details.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="speechUnderstanding">
        /// Enable speech understanding tasks like [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). See the task-specific docs for available options and configuration.
        /// </param>
        /// <param name="removeAudioTags">
        /// Universal-3.5 Pro generates rich transcripts that can include inline annotations such as audio event markers and speaker cues. Set to `"all"` to remove all inline annotations, or `"speaker"` to remove only speaker cues while keeping other annotations. By default, all inline annotations are removed.<br/>
        /// Note: This parameter is only supported for the Universal-3.5 Pro model.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="temperature">
        /// Control the amount of randomness injected into the model's response. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for more details.<br/>
        /// Note: This parameter only takes effect on the Universal-3.5 Pro model.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="webhookAuthHeaderName">
        /// The header name to be sent with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests. Must be 1-1000 characters and contain only ASCII letters, numbers, hyphens, and underscores. Requires `webhook_auth_header_value` and `webhook_url` to also be set.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="webhookAuthHeaderValue">
        /// The header value to send back with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests for added security. Must be 1-1000 characters and must not contain carriage returns or newlines. Requires `webhook_auth_header_name` and `webhook_url` to also be set.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which we send [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptOptionalParams(
            int? audioEndAt,
            int? audioStartFrom,
            bool? autoHighlights,
            bool? contentSafety,
            int? contentSafetyConfidence,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? customSpelling,
            bool? disfluencies,
            global::AssemblyAI.TranscriptOptionalParamsDomain? domain,
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
            bool? redactPiiReturnUnredacted,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? redactStaticEntities,
            bool? sentimentAnalysis,
            bool? speakerLabels,
            global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions? speakerOptions,
            int? speakersExpected,
            global::System.Collections.Generic.IList<global::AssemblyAI.SpeechModel2>? speechModels,
            float? speechThreshold,
            global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstanding? speechUnderstanding,
            global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>? removeAudioTags,
            double? temperature,
            string? webhookAuthHeaderName,
            string? webhookAuthHeaderValue,
            string? webhookUrl)
        {
            this.AudioEndAt = audioEndAt;
            this.AudioStartFrom = audioStartFrom;
            this.AutoHighlights = autoHighlights;
            this.ContentSafety = contentSafety;
            this.ContentSafetyConfidence = contentSafetyConfidence;
            this.CustomSpelling = customSpelling;
            this.Disfluencies = disfluencies;
            this.Domain = domain;
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
            this.RedactPiiReturnUnredacted = redactPiiReturnUnredacted;
            this.RedactStaticEntities = redactStaticEntities;
            this.SentimentAnalysis = sentimentAnalysis;
            this.SpeakerLabels = speakerLabels;
            this.SpeakerOptions = speakerOptions;
            this.SpeakersExpected = speakersExpected;
            this.SpeechModels = speechModels;
            this.SpeechThreshold = speechThreshold;
            this.SpeechUnderstanding = speechUnderstanding;
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