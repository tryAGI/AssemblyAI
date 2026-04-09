#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Controls which (if any) function is called by the model.
    /// </summary>
    public readonly partial struct ToolChoice : global::System.IEquatable<ToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.ToolChoice0? ToolChoice0 { get; init; }
#else
        public global::AssemblyAI.ToolChoice0? ToolChoice0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolChoice0))]
#endif
        public bool IsToolChoice0 => ToolChoice0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.ToolChoice1? ToolChoice1 { get; init; }
#else
        public global::AssemblyAI.ToolChoice1? ToolChoice1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolChoice1))]
#endif
        public bool IsToolChoice1 => ToolChoice1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::AssemblyAI.ToolChoice0 value) => new ToolChoice((global::AssemblyAI.ToolChoice0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.ToolChoice0?(ToolChoice @this) => @this.ToolChoice0;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::AssemblyAI.ToolChoice0? value)
        {
            ToolChoice0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::AssemblyAI.ToolChoice1 value) => new ToolChoice((global::AssemblyAI.ToolChoice1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.ToolChoice1?(ToolChoice @this) => @this.ToolChoice1;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::AssemblyAI.ToolChoice1? value)
        {
            ToolChoice1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(
            global::AssemblyAI.ToolChoice0? toolChoice0,
            global::AssemblyAI.ToolChoice1? toolChoice1
            )
        {
            ToolChoice0 = toolChoice0;
            ToolChoice1 = toolChoice1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolChoice1 as object ??
            ToolChoice0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolChoice0?.ToValueString() ??
            ToolChoice1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolChoice0 && !IsToolChoice1 || !IsToolChoice0 && IsToolChoice1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.ToolChoice0?, TResult>? toolChoice0 = null,
            global::System.Func<global::AssemblyAI.ToolChoice1?, TResult>? toolChoice1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolChoice0 && toolChoice0 != null)
            {
                return toolChoice0(ToolChoice0!);
            }
            else if (IsToolChoice1 && toolChoice1 != null)
            {
                return toolChoice1(ToolChoice1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.ToolChoice0?>? toolChoice0 = null,
            global::System.Action<global::AssemblyAI.ToolChoice1?>? toolChoice1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolChoice0)
            {
                toolChoice0?.Invoke(ToolChoice0!);
            }
            else if (IsToolChoice1)
            {
                toolChoice1?.Invoke(ToolChoice1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolChoice0,
                typeof(global::AssemblyAI.ToolChoice0),
                ToolChoice1,
                typeof(global::AssemblyAI.ToolChoice1),
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
        public bool Equals(ToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.ToolChoice0?>.Default.Equals(ToolChoice0, other.ToolChoice0) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.ToolChoice1?>.Default.Equals(ToolChoice1, other.ToolChoice1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolChoice obj1, ToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolChoice obj1, ToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChoice o && Equals(o);
        }
    }
}
