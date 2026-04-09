#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TranscriptSpeechUnderstandingResponse : global::System.IEquatable<TranscriptSpeechUnderstandingResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.TranslationResponse? TranslationResponse { get; init; }
#else
        public global::AssemblyAI.TranslationResponse? TranslationResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranslationResponse))]
#endif
        public bool IsTranslationResponse => TranslationResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.SpeakerIdentificationResponse? SpeakerIdentificationResponse { get; init; }
#else
        public global::AssemblyAI.SpeakerIdentificationResponse? SpeakerIdentificationResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakerIdentificationResponse))]
#endif
        public bool IsSpeakerIdentificationResponse => SpeakerIdentificationResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.CustomFormattingResponse? CustomFormattingResponse { get; init; }
#else
        public global::AssemblyAI.CustomFormattingResponse? CustomFormattingResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomFormattingResponse))]
#endif
        public bool IsCustomFormattingResponse => CustomFormattingResponse != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptSpeechUnderstandingResponse(global::AssemblyAI.TranslationResponse value) => new TranscriptSpeechUnderstandingResponse((global::AssemblyAI.TranslationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.TranslationResponse?(TranscriptSpeechUnderstandingResponse @this) => @this.TranslationResponse;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptSpeechUnderstandingResponse(global::AssemblyAI.TranslationResponse? value)
        {
            TranslationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptSpeechUnderstandingResponse(global::AssemblyAI.SpeakerIdentificationResponse value) => new TranscriptSpeechUnderstandingResponse((global::AssemblyAI.SpeakerIdentificationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.SpeakerIdentificationResponse?(TranscriptSpeechUnderstandingResponse @this) => @this.SpeakerIdentificationResponse;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptSpeechUnderstandingResponse(global::AssemblyAI.SpeakerIdentificationResponse? value)
        {
            SpeakerIdentificationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptSpeechUnderstandingResponse(global::AssemblyAI.CustomFormattingResponse value) => new TranscriptSpeechUnderstandingResponse((global::AssemblyAI.CustomFormattingResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.CustomFormattingResponse?(TranscriptSpeechUnderstandingResponse @this) => @this.CustomFormattingResponse;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptSpeechUnderstandingResponse(global::AssemblyAI.CustomFormattingResponse? value)
        {
            CustomFormattingResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptSpeechUnderstandingResponse(
            global::AssemblyAI.TranslationResponse? translationResponse,
            global::AssemblyAI.SpeakerIdentificationResponse? speakerIdentificationResponse,
            global::AssemblyAI.CustomFormattingResponse? customFormattingResponse
            )
        {
            TranslationResponse = translationResponse;
            SpeakerIdentificationResponse = speakerIdentificationResponse;
            CustomFormattingResponse = customFormattingResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomFormattingResponse as object ??
            SpeakerIdentificationResponse as object ??
            TranslationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranslationResponse?.ToString() ??
            SpeakerIdentificationResponse?.ToString() ??
            CustomFormattingResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranslationResponse && !IsSpeakerIdentificationResponse && !IsCustomFormattingResponse || !IsTranslationResponse && IsSpeakerIdentificationResponse && !IsCustomFormattingResponse || !IsTranslationResponse && !IsSpeakerIdentificationResponse && IsCustomFormattingResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.TranslationResponse?, TResult>? translationResponse = null,
            global::System.Func<global::AssemblyAI.SpeakerIdentificationResponse?, TResult>? speakerIdentificationResponse = null,
            global::System.Func<global::AssemblyAI.CustomFormattingResponse?, TResult>? customFormattingResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranslationResponse && translationResponse != null)
            {
                return translationResponse(TranslationResponse!);
            }
            else if (IsSpeakerIdentificationResponse && speakerIdentificationResponse != null)
            {
                return speakerIdentificationResponse(SpeakerIdentificationResponse!);
            }
            else if (IsCustomFormattingResponse && customFormattingResponse != null)
            {
                return customFormattingResponse(CustomFormattingResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.TranslationResponse?>? translationResponse = null,
            global::System.Action<global::AssemblyAI.SpeakerIdentificationResponse?>? speakerIdentificationResponse = null,
            global::System.Action<global::AssemblyAI.CustomFormattingResponse?>? customFormattingResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranslationResponse)
            {
                translationResponse?.Invoke(TranslationResponse!);
            }
            else if (IsSpeakerIdentificationResponse)
            {
                speakerIdentificationResponse?.Invoke(SpeakerIdentificationResponse!);
            }
            else if (IsCustomFormattingResponse)
            {
                customFormattingResponse?.Invoke(CustomFormattingResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranslationResponse,
                typeof(global::AssemblyAI.TranslationResponse),
                SpeakerIdentificationResponse,
                typeof(global::AssemblyAI.SpeakerIdentificationResponse),
                CustomFormattingResponse,
                typeof(global::AssemblyAI.CustomFormattingResponse),
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
        public bool Equals(TranscriptSpeechUnderstandingResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.TranslationResponse?>.Default.Equals(TranslationResponse, other.TranslationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.SpeakerIdentificationResponse?>.Default.Equals(SpeakerIdentificationResponse, other.SpeakerIdentificationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.CustomFormattingResponse?>.Default.Equals(CustomFormattingResponse, other.CustomFormattingResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TranscriptSpeechUnderstandingResponse obj1, TranscriptSpeechUnderstandingResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranscriptSpeechUnderstandingResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TranscriptSpeechUnderstandingResponse obj1, TranscriptSpeechUnderstandingResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranscriptSpeechUnderstandingResponse o && Equals(o);
        }
    }
}
