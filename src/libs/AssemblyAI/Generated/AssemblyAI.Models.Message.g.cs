#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Message : global::System.IEquatable<Message>
    {
        /// <summary>
        /// user variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.MessageVariant1? MessageVariant1 { get; init; }
#else
        public global::AssemblyAI.MessageVariant1? MessageVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageVariant1))]
#endif
        public bool IsMessageVariant1 => MessageVariant1 != null;

        /// <summary>
        /// assistant variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.MessageVariant2? MessageVariant2 { get; init; }
#else
        public global::AssemblyAI.MessageVariant2? MessageVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageVariant2))]
#endif
        public bool IsMessageVariant2 => MessageVariant2 != null;

        /// <summary>
        /// system variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.MessageVariant3? MessageVariant3 { get; init; }
#else
        public global::AssemblyAI.MessageVariant3? MessageVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageVariant3))]
#endif
        public bool IsMessageVariant3 => MessageVariant3 != null;

        /// <summary>
        /// tool variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.MessageVariant4? Tool { get; init; }
#else
        public global::AssemblyAI.MessageVariant4? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::AssemblyAI.MessageVariant1 value) => new Message((global::AssemblyAI.MessageVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.MessageVariant1?(Message @this) => @this.MessageVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::AssemblyAI.MessageVariant1? value)
        {
            MessageVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::AssemblyAI.MessageVariant2 value) => new Message((global::AssemblyAI.MessageVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.MessageVariant2?(Message @this) => @this.MessageVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::AssemblyAI.MessageVariant2? value)
        {
            MessageVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::AssemblyAI.MessageVariant3 value) => new Message((global::AssemblyAI.MessageVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.MessageVariant3?(Message @this) => @this.MessageVariant3;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::AssemblyAI.MessageVariant3? value)
        {
            MessageVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::AssemblyAI.MessageVariant4 value) => new Message((global::AssemblyAI.MessageVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.MessageVariant4?(Message @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::AssemblyAI.MessageVariant4? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Message(
            global::AssemblyAI.MessageVariant1? messageVariant1,
            global::AssemblyAI.MessageVariant2? messageVariant2,
            global::AssemblyAI.MessageVariant3? messageVariant3,
            global::AssemblyAI.MessageVariant4? tool
            )
        {
            MessageVariant1 = messageVariant1;
            MessageVariant2 = messageVariant2;
            MessageVariant3 = messageVariant3;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            MessageVariant3 as object ??
            MessageVariant2 as object ??
            MessageVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessageVariant1?.ToString() ??
            MessageVariant2?.ToString() ??
            MessageVariant3?.ToString() ??
            Tool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageVariant1 && !IsMessageVariant2 && !IsMessageVariant3 && !IsTool || !IsMessageVariant1 && IsMessageVariant2 && !IsMessageVariant3 && !IsTool || !IsMessageVariant1 && !IsMessageVariant2 && IsMessageVariant3 && !IsTool || !IsMessageVariant1 && !IsMessageVariant2 && !IsMessageVariant3 && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.MessageVariant1?, TResult>? messageVariant1 = null,
            global::System.Func<global::AssemblyAI.MessageVariant2?, TResult>? messageVariant2 = null,
            global::System.Func<global::AssemblyAI.MessageVariant3?, TResult>? messageVariant3 = null,
            global::System.Func<global::AssemblyAI.MessageVariant4?, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageVariant1 && messageVariant1 != null)
            {
                return messageVariant1(MessageVariant1!);
            }
            else if (IsMessageVariant2 && messageVariant2 != null)
            {
                return messageVariant2(MessageVariant2!);
            }
            else if (IsMessageVariant3 && messageVariant3 != null)
            {
                return messageVariant3(MessageVariant3!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.MessageVariant1?>? messageVariant1 = null,
            global::System.Action<global::AssemblyAI.MessageVariant2?>? messageVariant2 = null,
            global::System.Action<global::AssemblyAI.MessageVariant3?>? messageVariant3 = null,
            global::System.Action<global::AssemblyAI.MessageVariant4?>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageVariant1)
            {
                messageVariant1?.Invoke(MessageVariant1!);
            }
            else if (IsMessageVariant2)
            {
                messageVariant2?.Invoke(MessageVariant2!);
            }
            else if (IsMessageVariant3)
            {
                messageVariant3?.Invoke(MessageVariant3!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageVariant1,
                typeof(global::AssemblyAI.MessageVariant1),
                MessageVariant2,
                typeof(global::AssemblyAI.MessageVariant2),
                MessageVariant3,
                typeof(global::AssemblyAI.MessageVariant3),
                Tool,
                typeof(global::AssemblyAI.MessageVariant4),
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
        public bool Equals(Message other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.MessageVariant1?>.Default.Equals(MessageVariant1, other.MessageVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.MessageVariant2?>.Default.Equals(MessageVariant2, other.MessageVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.MessageVariant3?>.Default.Equals(MessageVariant3, other.MessageVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.MessageVariant4?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Message obj1, Message obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Message>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Message obj1, Message obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Message o && Equals(o);
        }
    }
}
