#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The content of the message. Can be a string or an array of content parts (for user messages).
    /// </summary>
    public readonly partial struct UserAssistantSystemMessageContent : global::System.IEquatable<UserAssistantSystemMessageContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? UserAssistantSystemMessageContentVariant1 { get; init; }
#else
        public string? UserAssistantSystemMessageContentVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserAssistantSystemMessageContentVariant1))]
#endif
        public bool IsUserAssistantSystemMessageContentVariant1 => UserAssistantSystemMessageContentVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>? UserAssistantSystemMessageContent1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>? UserAssistantSystemMessageContent1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserAssistantSystemMessageContent1))]
#endif
        public bool IsUserAssistantSystemMessageContent1 => UserAssistantSystemMessageContent1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserAssistantSystemMessageContent(string value) => new UserAssistantSystemMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(UserAssistantSystemMessageContent @this) => @this.UserAssistantSystemMessageContentVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UserAssistantSystemMessageContent(string? value)
        {
            UserAssistantSystemMessageContentVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UserAssistantSystemMessageContent(
            string? userAssistantSystemMessageContentVariant1,
            global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>? userAssistantSystemMessageContent1
            )
        {
            UserAssistantSystemMessageContentVariant1 = userAssistantSystemMessageContentVariant1;
            UserAssistantSystemMessageContent1 = userAssistantSystemMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UserAssistantSystemMessageContent1 as object ??
            UserAssistantSystemMessageContentVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UserAssistantSystemMessageContentVariant1?.ToString() ??
            UserAssistantSystemMessageContent1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserAssistantSystemMessageContentVariant1 && !IsUserAssistantSystemMessageContent1 || !IsUserAssistantSystemMessageContentVariant1 && IsUserAssistantSystemMessageContent1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? userAssistantSystemMessageContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>?, TResult>? userAssistantSystemMessageContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserAssistantSystemMessageContentVariant1 && userAssistantSystemMessageContentVariant1 != null)
            {
                return userAssistantSystemMessageContentVariant1(UserAssistantSystemMessageContentVariant1!);
            }
            else if (IsUserAssistantSystemMessageContent1 && userAssistantSystemMessageContent1 != null)
            {
                return userAssistantSystemMessageContent1(UserAssistantSystemMessageContent1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? userAssistantSystemMessageContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>?>? userAssistantSystemMessageContent1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserAssistantSystemMessageContentVariant1)
            {
                userAssistantSystemMessageContentVariant1?.Invoke(UserAssistantSystemMessageContentVariant1!);
            }
            else if (IsUserAssistantSystemMessageContent1)
            {
                userAssistantSystemMessageContent1?.Invoke(UserAssistantSystemMessageContent1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserAssistantSystemMessageContentVariant1,
                typeof(string),
                UserAssistantSystemMessageContent1,
                typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>),
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
        public bool Equals(UserAssistantSystemMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(UserAssistantSystemMessageContentVariant1, other.UserAssistantSystemMessageContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>?>.Default.Equals(UserAssistantSystemMessageContent1, other.UserAssistantSystemMessageContent1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UserAssistantSystemMessageContent obj1, UserAssistantSystemMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserAssistantSystemMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UserAssistantSystemMessageContent obj1, UserAssistantSystemMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserAssistantSystemMessageContent o && Equals(o);
        }
    }
}
