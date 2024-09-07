using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LemurSummaryParams : global::System.IEquatable<LemurSummaryParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LemurBaseParams? Value1 { get; init; }
#else
        public global::AssemblyAI.LemurBaseParams? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurSummaryParams(global::AssemblyAI.LemurBaseParams value) => new LemurSummaryParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LemurBaseParams?(LemurSummaryParams @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public LemurSummaryParams(global::AssemblyAI.LemurBaseParams? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LemurSummaryParamsVariant2? Value2 { get; init; }
#else
        public global::AssemblyAI.LemurSummaryParamsVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurSummaryParams(global::AssemblyAI.LemurSummaryParamsVariant2 value) => new LemurSummaryParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LemurSummaryParamsVariant2?(LemurSummaryParams @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public LemurSummaryParams(global::AssemblyAI.LemurSummaryParamsVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurSummaryParams(
            global::AssemblyAI.LemurBaseParams? value1,
            global::AssemblyAI.LemurSummaryParamsVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::AssemblyAI.LemurBaseParams),
                Value2,
                typeof(global::AssemblyAI.LemurSummaryParamsVariant2),
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
        public bool Equals(LemurSummaryParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LemurBaseParams?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LemurSummaryParamsVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurSummaryParams obj1, LemurSummaryParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurSummaryParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurSummaryParams obj1, LemurSummaryParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurSummaryParams o && Equals(o);
        }
    }
}