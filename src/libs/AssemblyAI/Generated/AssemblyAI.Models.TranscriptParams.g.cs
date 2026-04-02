#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The parameters for creating a transcript<br/>
    /// Example: {"speech_model":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","language_code":"en_us","language_detection":true,"language_confidence_threshold":0.7,"audio_url":"https://assembly.ai/wildfires.mp3","punctuate":true,"format_text":true,"multichannel":true,"webhook_url":"https://your-webhook-url/path","webhook_auth_header_name":"webhook-secret","webhook_auth_header_value":"webhook-secret-value","auto_highlights":true,"audio_start_from":10,"audio_end_at":280,"filter_profanity":true,"redact_pii":true,"redact_pii_audio":true,"redact_pii_audio_quality":"mp3","redact_pii_policies":["us_social_security_number","credit_card_number"],"redact_pii_sub":"hash","speaker_labels":true,"speakers_expected":2,"content_safety":true,"iab_categories":true,"custom_spelling":[],"disfluencies":false,"sentiment_analysis":true,"auto_chapters":false,"entity_detection":true,"speech_threshold":0.5,"summarization":false,"summary_model":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","summary_type":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","custom_topics":true,"topics":[],"remove_audio_tags":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","domain":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","speech_understanding":{"request":{"translation":{"target_languages":["es","de"],"formal":true,"match_original_utterance":true}}}}
    /// </summary>
    public readonly partial struct TranscriptParams : global::System.IEquatable<TranscriptParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.TranscriptParamsVariant1? TranscriptParamsVariant1 { get; init; }
#else
        public global::AssemblyAI.TranscriptParamsVariant1? TranscriptParamsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptParamsVariant1))]
#endif
        public bool IsTranscriptParamsVariant1 => TranscriptParamsVariant1 != null;

        /// <summary>
        /// The parameters for creating a transcript<br/>
        /// Example: {"speech_model":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","language_code":"en_us","language_detection":true,"language_confidence_threshold":0.7,"punctuate":true,"format_text":true,"multichannel":true,"webhook_url":"https://your-webhook-url.tld/path","webhook_auth_header_name":"webhook-secret","webhook_auth_header_value":"webhook-secret-value","auto_highlights":true,"audio_start_from":10,"audio_end_at":280,"filter_profanity":true,"redact_pii":true,"redact_pii_audio":true,"redact_pii_audio_quality":"mp3","redact_pii_policies":["us_social_security_number","credit_card_number"],"redact_pii_sub":"hash","speaker_labels":true,"speakers_expected":2,"content_safety":true,"iab_categories":true,"custom_spelling":[],"disfluencies":false,"sentiment_analysis":true,"auto_chapters":false,"entity_detection":true,"speech_threshold":0.5,"summarization":false,"summary_model":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","summary_type":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","custom_topics":true,"topics":[],"remove_audio_tags":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","domain":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","speech_understanding":{"request":{"translation":{"target_languages":["es","de"],"formal":true,"match_original_utterance":true}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.TranscriptOptionalParams? Optional { get; init; }
#else
        public global::AssemblyAI.TranscriptOptionalParams? Optional { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Optional))]
#endif
        public bool IsOptional => Optional != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptParams(global::AssemblyAI.TranscriptParamsVariant1 value) => new TranscriptParams((global::AssemblyAI.TranscriptParamsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.TranscriptParamsVariant1?(TranscriptParams @this) => @this.TranscriptParamsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptParams(global::AssemblyAI.TranscriptParamsVariant1? value)
        {
            TranscriptParamsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptParams(global::AssemblyAI.TranscriptOptionalParams value) => new TranscriptParams((global::AssemblyAI.TranscriptOptionalParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.TranscriptOptionalParams?(TranscriptParams @this) => @this.Optional;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptParams(global::AssemblyAI.TranscriptOptionalParams? value)
        {
            Optional = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptParams(
            global::AssemblyAI.TranscriptParamsVariant1? transcriptParamsVariant1,
            global::AssemblyAI.TranscriptOptionalParams? optional
            )
        {
            TranscriptParamsVariant1 = transcriptParamsVariant1;
            Optional = optional;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Optional as object ??
            TranscriptParamsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranscriptParamsVariant1?.ToString() ??
            Optional?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranscriptParamsVariant1 && IsOptional;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.TranscriptParamsVariant1?, TResult>? transcriptParamsVariant1 = null,
            global::System.Func<global::AssemblyAI.TranscriptOptionalParams?, TResult>? optional = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptParamsVariant1 && transcriptParamsVariant1 != null)
            {
                return transcriptParamsVariant1(TranscriptParamsVariant1!);
            }
            else if (IsOptional && optional != null)
            {
                return optional(Optional!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.TranscriptParamsVariant1?>? transcriptParamsVariant1 = null,
            global::System.Action<global::AssemblyAI.TranscriptOptionalParams?>? optional = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptParamsVariant1)
            {
                transcriptParamsVariant1?.Invoke(TranscriptParamsVariant1!);
            }
            else if (IsOptional)
            {
                optional?.Invoke(Optional!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranscriptParamsVariant1,
                typeof(global::AssemblyAI.TranscriptParamsVariant1),
                Optional,
                typeof(global::AssemblyAI.TranscriptOptionalParams),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TranscriptParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.TranscriptParamsVariant1?>.Default.Equals(TranscriptParamsVariant1, other.TranscriptParamsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.TranscriptOptionalParams?>.Default.Equals(Optional, other.Optional) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TranscriptParams obj1, TranscriptParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranscriptParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TranscriptParams obj1, TranscriptParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranscriptParams o && Equals(o);
        }
    }
}
