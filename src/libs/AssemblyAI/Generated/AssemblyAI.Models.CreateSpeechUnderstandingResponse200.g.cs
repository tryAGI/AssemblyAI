#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateSpeechUnderstandingResponse200 : global::System.IEquatable<CreateSpeechUnderstandingResponse200>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LLMGatewayTranslationResponse? LLMGatewayTranslationResponse { get; init; }
#else
        public global::AssemblyAI.LLMGatewayTranslationResponse? LLMGatewayTranslationResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMGatewayTranslationResponse))]
#endif
        public bool IsLLMGatewayTranslationResponse => LLMGatewayTranslationResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse? LLMGatewaySpeakerIdentificationResponse { get; init; }
#else
        public global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse? LLMGatewaySpeakerIdentificationResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMGatewaySpeakerIdentificationResponse))]
#endif
        public bool IsLLMGatewaySpeakerIdentificationResponse => LLMGatewaySpeakerIdentificationResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LLMGatewayCustomFormattingResponse? LLMGatewayCustomFormattingResponse { get; init; }
#else
        public global::AssemblyAI.LLMGatewayCustomFormattingResponse? LLMGatewayCustomFormattingResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LLMGatewayCustomFormattingResponse))]
#endif
        public bool IsLLMGatewayCustomFormattingResponse => LLMGatewayCustomFormattingResponse != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSpeechUnderstandingResponse200(global::AssemblyAI.LLMGatewayTranslationResponse value) => new CreateSpeechUnderstandingResponse200((global::AssemblyAI.LLMGatewayTranslationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LLMGatewayTranslationResponse?(CreateSpeechUnderstandingResponse200 @this) => @this.LLMGatewayTranslationResponse;

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechUnderstandingResponse200(global::AssemblyAI.LLMGatewayTranslationResponse? value)
        {
            LLMGatewayTranslationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSpeechUnderstandingResponse200(global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse value) => new CreateSpeechUnderstandingResponse200((global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse?(CreateSpeechUnderstandingResponse200 @this) => @this.LLMGatewaySpeakerIdentificationResponse;

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechUnderstandingResponse200(global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse? value)
        {
            LLMGatewaySpeakerIdentificationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateSpeechUnderstandingResponse200(global::AssemblyAI.LLMGatewayCustomFormattingResponse value) => new CreateSpeechUnderstandingResponse200((global::AssemblyAI.LLMGatewayCustomFormattingResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LLMGatewayCustomFormattingResponse?(CreateSpeechUnderstandingResponse200 @this) => @this.LLMGatewayCustomFormattingResponse;

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechUnderstandingResponse200(global::AssemblyAI.LLMGatewayCustomFormattingResponse? value)
        {
            LLMGatewayCustomFormattingResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateSpeechUnderstandingResponse200(
            global::AssemblyAI.LLMGatewayTranslationResponse? lLMGatewayTranslationResponse,
            global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse? lLMGatewaySpeakerIdentificationResponse,
            global::AssemblyAI.LLMGatewayCustomFormattingResponse? lLMGatewayCustomFormattingResponse
            )
        {
            LLMGatewayTranslationResponse = lLMGatewayTranslationResponse;
            LLMGatewaySpeakerIdentificationResponse = lLMGatewaySpeakerIdentificationResponse;
            LLMGatewayCustomFormattingResponse = lLMGatewayCustomFormattingResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LLMGatewayCustomFormattingResponse as object ??
            LLMGatewaySpeakerIdentificationResponse as object ??
            LLMGatewayTranslationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LLMGatewayTranslationResponse?.ToString() ??
            LLMGatewaySpeakerIdentificationResponse?.ToString() ??
            LLMGatewayCustomFormattingResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLLMGatewayTranslationResponse && !IsLLMGatewaySpeakerIdentificationResponse && !IsLLMGatewayCustomFormattingResponse || !IsLLMGatewayTranslationResponse && IsLLMGatewaySpeakerIdentificationResponse && !IsLLMGatewayCustomFormattingResponse || !IsLLMGatewayTranslationResponse && !IsLLMGatewaySpeakerIdentificationResponse && IsLLMGatewayCustomFormattingResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.LLMGatewayTranslationResponse?, TResult>? lLMGatewayTranslationResponse = null,
            global::System.Func<global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse?, TResult>? lLMGatewaySpeakerIdentificationResponse = null,
            global::System.Func<global::AssemblyAI.LLMGatewayCustomFormattingResponse?, TResult>? lLMGatewayCustomFormattingResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLLMGatewayTranslationResponse && lLMGatewayTranslationResponse != null)
            {
                return lLMGatewayTranslationResponse(LLMGatewayTranslationResponse!);
            }
            else if (IsLLMGatewaySpeakerIdentificationResponse && lLMGatewaySpeakerIdentificationResponse != null)
            {
                return lLMGatewaySpeakerIdentificationResponse(LLMGatewaySpeakerIdentificationResponse!);
            }
            else if (IsLLMGatewayCustomFormattingResponse && lLMGatewayCustomFormattingResponse != null)
            {
                return lLMGatewayCustomFormattingResponse(LLMGatewayCustomFormattingResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.LLMGatewayTranslationResponse?>? lLMGatewayTranslationResponse = null,
            global::System.Action<global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse?>? lLMGatewaySpeakerIdentificationResponse = null,
            global::System.Action<global::AssemblyAI.LLMGatewayCustomFormattingResponse?>? lLMGatewayCustomFormattingResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLLMGatewayTranslationResponse)
            {
                lLMGatewayTranslationResponse?.Invoke(LLMGatewayTranslationResponse!);
            }
            else if (IsLLMGatewaySpeakerIdentificationResponse)
            {
                lLMGatewaySpeakerIdentificationResponse?.Invoke(LLMGatewaySpeakerIdentificationResponse!);
            }
            else if (IsLLMGatewayCustomFormattingResponse)
            {
                lLMGatewayCustomFormattingResponse?.Invoke(LLMGatewayCustomFormattingResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LLMGatewayTranslationResponse,
                typeof(global::AssemblyAI.LLMGatewayTranslationResponse),
                LLMGatewaySpeakerIdentificationResponse,
                typeof(global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse),
                LLMGatewayCustomFormattingResponse,
                typeof(global::AssemblyAI.LLMGatewayCustomFormattingResponse),
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
        public bool Equals(CreateSpeechUnderstandingResponse200 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LLMGatewayTranslationResponse?>.Default.Equals(LLMGatewayTranslationResponse, other.LLMGatewayTranslationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse?>.Default.Equals(LLMGatewaySpeakerIdentificationResponse, other.LLMGatewaySpeakerIdentificationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LLMGatewayCustomFormattingResponse?>.Default.Equals(LLMGatewayCustomFormattingResponse, other.LLMGatewayCustomFormattingResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateSpeechUnderstandingResponse200 obj1, CreateSpeechUnderstandingResponse200 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateSpeechUnderstandingResponse200>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateSpeechUnderstandingResponse200 obj1, CreateSpeechUnderstandingResponse200 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateSpeechUnderstandingResponse200 o && Equals(o);
        }
    }
}
