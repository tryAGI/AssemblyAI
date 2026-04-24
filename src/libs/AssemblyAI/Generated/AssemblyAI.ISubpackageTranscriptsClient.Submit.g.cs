#nullable enable

namespace AssemblyAI
{
    public partial interface ISubpackageTranscriptsClient
    {
        /// <summary>
        /// Transcribe audio<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// &lt;Note&gt;To use our EU server for transcription, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// &lt;Tip&gt;Building a load test or submitting a large batch? [See our guide →](/docs/pre-recorded-audio/guides/bulk-transcription-and-load-tests-at-scale)&lt;/Tip&gt;<br/>
        /// Create a transcript from a media file that is accessible via a URL.
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AssemblyAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Transcript> SubmitAsync(
            string authorization,

            global::AssemblyAI.TranscriptParams request,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe audio<br/>
        /// &lt;llms-only&gt;<br/>
        /// &gt; For the complete documentation index, see [llms.txt](https://www.assemblyai.com/docs/llms.txt)<br/>
        /// &lt;/llms-only&gt;<br/>
        /// &lt;Note&gt;To use our EU server for transcription, replace `api.assemblyai.com` with `api.eu.assemblyai.com`.&lt;/Note&gt;<br/>
        /// &lt;Tip&gt;Building a load test or submitting a large batch? [See our guide →](/docs/pre-recorded-audio/guides/bulk-transcription-and-load-tests-at-scale)&lt;/Tip&gt;<br/>
        /// Create a transcript from a media file that is accessible via a URL.
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="audioEndAt">
        /// The point in time, in milliseconds, to stop transcribing in your media file. See [Set the start and end of the transcript](https://www.assemblyai.com/docs/pre-recorded-audio/set-the-start-and-end-of-the-transcript) for more details.
        /// </param>
        /// <param name="audioStartFrom">
        /// The point in time, in milliseconds, to begin transcribing in your media file. See [Set the start and end of the transcript](https://www.assemblyai.com/docs/pre-recorded-audio/set-the-start-and-end-of-the-transcript) for more details.
        /// </param>
        /// <param name="autoChapters">
        /// Enable [Auto Chapters](https://www.assemblyai.com/docs/speech-understanding/create-summarized-chapters), can be true or false. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible chapter summaries. See the [updated Auto Chapters page](https://www.assemblyai.com/docs/speech-understanding/create-summarized-chapters) for details.<br/>
        /// Note: This parameter is only supported for the Universal-2 model.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoHighlights">
        /// Enable [Key Phrases](https://www.assemblyai.com/docs/speech-understanding/identify-highlights), either true or false<br/>
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
        /// Customize how words are spelled and formatted using to and from values. See [Custom Spelling](https://www.assemblyai.com/docs/pre-recorded-audio/correct-spelling-of-terms) for more details.
        /// </param>
        /// <param name="disfluencies">
        /// Transcribe [Filler Words](https://www.assemblyai.com/docs/pre-recorded-audio/include-filler-words), like "umm", in your media file; can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="domain">
        /// Enable domain-specific transcription models to improve accuracy for specialized terminology. Set to `"medical-v1"` to enable [Medical Mode](https://www.assemblyai.com/docs/pre-recorded-audio/medical-mode) for improved accuracy of medical terms such as medications, procedures, conditions, and dosages.<br/>
        /// Supported languages: English (`en`), Spanish (`es`), German (`de`), French (`fr`). If used with an unsupported language, the parameter is ignored and a warning is returned.
        /// </param>
        /// <param name="entityDetection">
        /// Enable [Entity Detection](https://www.assemblyai.com/docs/speech-understanding/detect-entities-in-transcript), can be true or false<br/>
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
        /// Enable [Topic Detection](https://www.assemblyai.com/docs/speech-understanding/detect-discussion-topics), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keytermsPrompt">
        /// Improve accuracy with up to 200 (for Universal-2) or 1000 (for Universal-3 Pro) domain-specific words or phrases (maximum 6 words per phrase). See [Keyterms Prompting](https://www.assemblyai.com/docs/pre-recorded-audio/keyterms-prompting) for more details.
        /// </param>
        /// <param name="languageCode">
        /// The language of your audio file. Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/pre-recorded-audio/supported-languages).<br/>
        /// The default value is 'en_us'.
        /// </param>
        /// <param name="languageCodes">
        /// The language codes of your audio file. Used for [Code switching](/docs/speech-to-text/pre-recorded-audio/code-switching)<br/>
        /// One of the values specified must be `en`.
        /// </param>
        /// <param name="languageConfidenceThreshold">
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// Defaults to 0. See [Automatic Language Detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection) for more details.
        /// </param>
        /// <param name="languageDetection">
        /// Enable [Automatic language detection](https://www.assemblyai.com/docs/pre-recorded-audio/language-detection), either true or false.<br/>
        /// Default Value: false
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
        /// Note: This parameter is only supported for the Universal-3 Pro model.
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
        /// Controls the filetype of the audio created by redact_pii_audio. Currently supports mp3 (default) and wav. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction#request-for-redacted-audio) for more details.
        /// </param>
        /// <param name="redactPiiPolicies">
        /// The list of PII Redaction policies to enable. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.
        /// </param>
        /// <param name="redactPiiSub">
        /// The replacement logic for detected PII, can be `entity_type` or `hash`. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.
        /// </param>
        /// <param name="redactPiiReturnUnredacted">
        /// When set to `true`, returns the original unredacted transcript alongside the redacted one in the same response. Requires `redact_pii` to be `true`, otherwise a 400 error is returned.<br/>
        /// When enabled, the response includes the additional fields `unredacted_text`, `unredacted_words`, and `unredacted_utterances`. The existing `text`, `words`, and `utterances` fields remain fully redacted. When disabled (default), the response is unchanged and contains only the redacted transcript. See [PII redaction](https://www.assemblyai.com/docs/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Enable [Sentiment Analysis](https://www.assemblyai.com/docs/speech-understanding/analyze-sentiment-of-speech), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speakerLabels">
        /// Enable [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speakerOptions">
        /// Specify options for [Speaker diarization](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-a-range-of-possible-speakers). Use this to set a range of possible speakers.
        /// </param>
        /// <param name="speakersExpected">
        /// Tells the speaker label model how many speakers it should attempt to identify. See [Set number of speakers expected](https://www.assemblyai.com/docs/pre-recorded-audio/label-speakers#set-number-of-speakers-expected) for more details.
        /// </param>
        /// <param name="speechModels">
        /// List multiple speech models in priority order, allowing our system to automatically route your audio to the best available option. See [Model Selection](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model) for available models and routing behavior.
        /// </param>
        /// <param name="speechThreshold">
        /// Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive. See [Speech Threshold](https://www.assemblyai.com/docs/speech-threshold) for more details.
        /// </param>
        /// <param name="speechUnderstanding">
        /// Enable speech understanding tasks like [Translation](https://www.assemblyai.com/docs/speech-understanding/translation), [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification), and [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting). See the task-specific docs for available options and configuration.
        /// </param>
        /// <param name="summarization">
        /// Enable [Summarization](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts), can be true or false. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.<br/>
        /// Note: This parameter is only supported for the Universal-2 model.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summaryModel">
        /// The model to summarize the transcript. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.
        /// </param>
        /// <param name="summaryType">
        /// The type of summary. Deprecated - use [LLM Gateway](https://www.assemblyai.com/docs/llm-gateway/overview) instead for more flexible summaries. See the [updated Summarization page](https://www.assemblyai.com/docs/speech-understanding/summarize-transcripts) for details.
        /// </param>
        /// <param name="removeAudioTags">
        /// Remove [audio event tags](https://www.assemblyai.com/docs/pre-recorded-audio/universal-3-pro#audio-event-tags) from the transcript text. Set to `"all"` to remove all audio tags.<br/>
        /// Note: This parameter is only supported for the Universal-3 Pro model.
        /// </param>
        /// <param name="temperature">
        /// Control the amount of randomness injected into the model's response. See the [Prompting Guide](https://www.assemblyai.com/docs/pre-recorded-audio/prompting) for more details.<br/>
        /// Note: This parameter can only be used with the Universal-3 Pro model.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="webhookAuthHeaderName">
        /// The header name to be sent with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests
        /// </param>
        /// <param name="webhookAuthHeaderValue">
        /// The header value to send back with the transcript completed or failed [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests for added security
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which we send [webhook](https://www.assemblyai.com/docs/deployment/webhooks-for-pre-recorded-audio) requests.
        /// </param>
        /// <param name="customTopics">
        /// This parameter does not currently have any functionality attached to it.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speechModel">
        /// This parameter has been replaced with the `speech_models` parameter, learn more about the `speech_models` parameter [here](https://www.assemblyai.com/docs/pre-recorded-audio/select-the-speech-model).
        /// </param>
        /// <param name="topics">
        /// This parameter does not currently have any functionality attached to it.
        /// </param>
        /// <param name="audioUrl">
        /// The URL of the audio or video file to transcribe.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AssemblyAI.Transcript> SubmitAsync(
            string authorization,
            global::System.Collections.Generic.IList<string> speechModels,
            string audioUrl,
            int? audioEndAt = default,
            int? audioStartFrom = default,
            bool? autoChapters = default,
            bool? autoHighlights = default,
            bool? contentSafety = default,
            int? contentSafetyConfidence = default,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptCustomSpelling>? customSpelling = default,
            bool? disfluencies = default,
            string? domain = default,
            bool? entityDetection = default,
            bool? filterProfanity = default,
            bool? formatText = default,
            bool? iabCategories = default,
            global::System.Collections.Generic.IList<string>? keytermsPrompt = default,
            global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptLanguageCode?, object>? languageCode = default,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptLanguageCode>? languageCodes = default,
            double? languageConfidenceThreshold = default,
            bool? languageDetection = default,
            global::AssemblyAI.TranscriptOptionalParamsLanguageDetectionOptions? languageDetectionOptions = default,
            bool? multichannel = default,
            string? prompt = default,
            bool? punctuate = default,
            bool? redactPii = default,
            bool? redactPiiAudio = default,
            global::AssemblyAI.TranscriptOptionalParamsRedactPiiAudioOptions? redactPiiAudioOptions = default,
            global::AssemblyAI.RedactPiiAudioQuality? redactPiiAudioQuality = default,
            global::System.Collections.Generic.IList<global::AssemblyAI.PiiPolicy>? redactPiiPolicies = default,
            global::AssemblyAI.OneOf<global::AssemblyAI.SubstitutionPolicy?, object>? redactPiiSub = default,
            bool? redactPiiReturnUnredacted = default,
            bool? sentimentAnalysis = default,
            bool? speakerLabels = default,
            global::AssemblyAI.TranscriptOptionalParamsSpeakerOptions? speakerOptions = default,
            int? speakersExpected = default,
            double? speechThreshold = default,
            global::AssemblyAI.TranscriptOptionalParamsSpeechUnderstanding? speechUnderstanding = default,
            bool? summarization = default,
            global::AssemblyAI.SummaryModel? summaryModel = default,
            global::AssemblyAI.SummaryType? summaryType = default,
            global::AssemblyAI.OneOf<global::AssemblyAI.TranscriptOptionalParamsRemoveAudioTags?, object>? removeAudioTags = default,
            double? temperature = default,
            string? webhookAuthHeaderName = default,
            string? webhookAuthHeaderValue = default,
            string? webhookUrl = default,
            bool? customTopics = default,
            global::AssemblyAI.OneOf<string, object>? speechModel = default,
            global::System.Collections.Generic.IList<string>? topics = default,
            global::AssemblyAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}