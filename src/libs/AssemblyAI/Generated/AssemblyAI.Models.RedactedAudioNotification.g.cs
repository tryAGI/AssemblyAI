#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The notification when the redacted audio is ready.
    /// </summary>
    public readonly partial struct RedactedAudioNotification : global::System.IEquatable<RedactedAudioNotification>
    {
        /// <summary>
        /// Example: {"redacted_audio_url":"https://s3.us-west-2.amazonaws.com/api.assembly.ai.usw2/redacted-audio/785efd9e-0e20-45e1-967b-3db17770ed9f.wav?AWSAccessKeyId=aws-access-key0id\u0026Signature=signature\u0026x-amz-security-token=security-token\u0026Expires=1698966551","status":"redacted_audio_ready"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.RedactedAudioResponse? Response { get; init; }
#else
        public global::AssemblyAI.RedactedAudioResponse? Response { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Response))]
#endif
        public bool IsResponse => Response != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RedactedAudioNotification(global::AssemblyAI.RedactedAudioResponse value) => new RedactedAudioNotification((global::AssemblyAI.RedactedAudioResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.RedactedAudioResponse?(RedactedAudioNotification @this) => @this.Response;

        /// <summary>
        /// 
        /// </summary>
        public RedactedAudioNotification(global::AssemblyAI.RedactedAudioResponse? value)
        {
            Response = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Response as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Response?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.RedactedAudioResponse?, TResult>? response = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse && response != null)
            {
                return response(Response!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.RedactedAudioResponse?>? response = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse)
            {
                response?.Invoke(Response!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Response,
                typeof(global::AssemblyAI.RedactedAudioResponse),
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
        public bool Equals(RedactedAudioNotification other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.RedactedAudioResponse?>.Default.Equals(Response, other.Response) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RedactedAudioNotification obj1, RedactedAudioNotification obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RedactedAudioNotification>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RedactedAudioNotification obj1, RedactedAudioNotification obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RedactedAudioNotification o && Equals(o);
        }
    }
}
