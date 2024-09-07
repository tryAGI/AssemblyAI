using System.Linq;
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
        /// 
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
        public static implicit operator RedactedAudioNotification(global::AssemblyAI.RedactedAudioResponse value) => new RedactedAudioNotification(value);

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
        public bool Validate()
        {
            return IsResponse;
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
            return fields.Aggregate(offset, HashCodeAggregator);
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
