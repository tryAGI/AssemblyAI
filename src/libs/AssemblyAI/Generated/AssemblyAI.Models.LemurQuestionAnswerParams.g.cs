using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LemurQuestionAnswerParams : global::System.IEquatable<LemurQuestionAnswerParams>
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
        public static implicit operator LemurQuestionAnswerParams(global::AssemblyAI.LemurBaseParams value) => new LemurQuestionAnswerParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LemurBaseParams?(LemurQuestionAnswerParams @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public LemurQuestionAnswerParams(global::AssemblyAI.LemurBaseParams? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LemurQuestionAnswerParamsVariant2? Value2 { get; init; }
#else
        public global::AssemblyAI.LemurQuestionAnswerParamsVariant2? Value2 { get; }
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
        public static implicit operator LemurQuestionAnswerParams(global::AssemblyAI.LemurQuestionAnswerParamsVariant2 value) => new LemurQuestionAnswerParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LemurQuestionAnswerParamsVariant2?(LemurQuestionAnswerParams @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public LemurQuestionAnswerParams(global::AssemblyAI.LemurQuestionAnswerParamsVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurQuestionAnswerParams(
            global::AssemblyAI.LemurBaseParams? value1,
            global::AssemblyAI.LemurQuestionAnswerParamsVariant2? value2
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
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.LemurBaseParams?, TResult>? value1 = null,
            global::System.Func<global::AssemblyAI.LemurQuestionAnswerParamsVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.LemurBaseParams?>? value1 = null,
            global::System.Action<global::AssemblyAI.LemurQuestionAnswerParamsVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
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
                typeof(global::AssemblyAI.LemurQuestionAnswerParamsVariant2),
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
        public bool Equals(LemurQuestionAnswerParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LemurBaseParams?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LemurQuestionAnswerParamsVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurQuestionAnswerParams obj1, LemurQuestionAnswerParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurQuestionAnswerParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurQuestionAnswerParams obj1, LemurQuestionAnswerParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurQuestionAnswerParams o && Equals(o);
        }
    }
}
