#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TranscriptSpeechUnderstandingRequest : global::System.IEquatable<TranscriptSpeechUnderstandingRequest>
    {
        /// <summary>
        /// Request body for [Translation](https://www.assemblyai.com/docs/speech-understanding/translation).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.TranslationRequestBody? TranslationRequestBody { get; init; }
#else
        public global::AssemblyAI.TranslationRequestBody? TranslationRequestBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranslationRequestBody))]
#endif
        public bool IsTranslationRequestBody => TranslationRequestBody != null;

        /// <summary>
        /// Request body for [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.SpeakerIdentificationRequestBody? SpeakerIdentificationRequestBody { get; init; }
#else
        public global::AssemblyAI.SpeakerIdentificationRequestBody? SpeakerIdentificationRequestBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeakerIdentificationRequestBody))]
#endif
        public bool IsSpeakerIdentificationRequestBody => SpeakerIdentificationRequestBody != null;

        /// <summary>
        /// Request body for [Custom Formatting](https://www.assemblyai.com/docs/speech-understanding/custom-formatting).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.CustomFormattingRequestBody? CustomFormattingRequestBody { get; init; }
#else
        public global::AssemblyAI.CustomFormattingRequestBody? CustomFormattingRequestBody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomFormattingRequestBody))]
#endif
        public bool IsCustomFormattingRequestBody => CustomFormattingRequestBody != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptSpeechUnderstandingRequest(global::AssemblyAI.TranslationRequestBody value) => new TranscriptSpeechUnderstandingRequest((global::AssemblyAI.TranslationRequestBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.TranslationRequestBody?(TranscriptSpeechUnderstandingRequest @this) => @this.TranslationRequestBody;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptSpeechUnderstandingRequest(global::AssemblyAI.TranslationRequestBody? value)
        {
            TranslationRequestBody = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptSpeechUnderstandingRequest(global::AssemblyAI.SpeakerIdentificationRequestBody value) => new TranscriptSpeechUnderstandingRequest((global::AssemblyAI.SpeakerIdentificationRequestBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.SpeakerIdentificationRequestBody?(TranscriptSpeechUnderstandingRequest @this) => @this.SpeakerIdentificationRequestBody;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptSpeechUnderstandingRequest(global::AssemblyAI.SpeakerIdentificationRequestBody? value)
        {
            SpeakerIdentificationRequestBody = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TranscriptSpeechUnderstandingRequest(global::AssemblyAI.CustomFormattingRequestBody value) => new TranscriptSpeechUnderstandingRequest((global::AssemblyAI.CustomFormattingRequestBody?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.CustomFormattingRequestBody?(TranscriptSpeechUnderstandingRequest @this) => @this.CustomFormattingRequestBody;

        /// <summary>
        /// 
        /// </summary>
        public TranscriptSpeechUnderstandingRequest(global::AssemblyAI.CustomFormattingRequestBody? value)
        {
            CustomFormattingRequestBody = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptSpeechUnderstandingRequest(
            global::AssemblyAI.TranslationRequestBody? translationRequestBody,
            global::AssemblyAI.SpeakerIdentificationRequestBody? speakerIdentificationRequestBody,
            global::AssemblyAI.CustomFormattingRequestBody? customFormattingRequestBody
            )
        {
            TranslationRequestBody = translationRequestBody;
            SpeakerIdentificationRequestBody = speakerIdentificationRequestBody;
            CustomFormattingRequestBody = customFormattingRequestBody;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomFormattingRequestBody as object ??
            SpeakerIdentificationRequestBody as object ??
            TranslationRequestBody as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranslationRequestBody?.ToString() ??
            SpeakerIdentificationRequestBody?.ToString() ??
            CustomFormattingRequestBody?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranslationRequestBody && !IsSpeakerIdentificationRequestBody && !IsCustomFormattingRequestBody || !IsTranslationRequestBody && IsSpeakerIdentificationRequestBody && !IsCustomFormattingRequestBody || !IsTranslationRequestBody && !IsSpeakerIdentificationRequestBody && IsCustomFormattingRequestBody;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.TranslationRequestBody?, TResult>? translationRequestBody = null,
            global::System.Func<global::AssemblyAI.SpeakerIdentificationRequestBody?, TResult>? speakerIdentificationRequestBody = null,
            global::System.Func<global::AssemblyAI.CustomFormattingRequestBody?, TResult>? customFormattingRequestBody = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranslationRequestBody && translationRequestBody != null)
            {
                return translationRequestBody(TranslationRequestBody!);
            }
            else if (IsSpeakerIdentificationRequestBody && speakerIdentificationRequestBody != null)
            {
                return speakerIdentificationRequestBody(SpeakerIdentificationRequestBody!);
            }
            else if (IsCustomFormattingRequestBody && customFormattingRequestBody != null)
            {
                return customFormattingRequestBody(CustomFormattingRequestBody!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.TranslationRequestBody?>? translationRequestBody = null,
            global::System.Action<global::AssemblyAI.SpeakerIdentificationRequestBody?>? speakerIdentificationRequestBody = null,
            global::System.Action<global::AssemblyAI.CustomFormattingRequestBody?>? customFormattingRequestBody = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranslationRequestBody)
            {
                translationRequestBody?.Invoke(TranslationRequestBody!);
            }
            else if (IsSpeakerIdentificationRequestBody)
            {
                speakerIdentificationRequestBody?.Invoke(SpeakerIdentificationRequestBody!);
            }
            else if (IsCustomFormattingRequestBody)
            {
                customFormattingRequestBody?.Invoke(CustomFormattingRequestBody!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranslationRequestBody,
                typeof(global::AssemblyAI.TranslationRequestBody),
                SpeakerIdentificationRequestBody,
                typeof(global::AssemblyAI.SpeakerIdentificationRequestBody),
                CustomFormattingRequestBody,
                typeof(global::AssemblyAI.CustomFormattingRequestBody),
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
        public bool Equals(TranscriptSpeechUnderstandingRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.TranslationRequestBody?>.Default.Equals(TranslationRequestBody, other.TranslationRequestBody) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.SpeakerIdentificationRequestBody?>.Default.Equals(SpeakerIdentificationRequestBody, other.SpeakerIdentificationRequestBody) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.CustomFormattingRequestBody?>.Default.Equals(CustomFormattingRequestBody, other.CustomFormattingRequestBody) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TranscriptSpeechUnderstandingRequest obj1, TranscriptSpeechUnderstandingRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TranscriptSpeechUnderstandingRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TranscriptSpeechUnderstandingRequest obj1, TranscriptSpeechUnderstandingRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TranscriptSpeechUnderstandingRequest o && Equals(o);
        }
    }
}
