#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LemurStringResponse : global::System.IEquatable<LemurStringResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LemurStringResponseVariant1? Value1 { get; init; }
#else
        public global::AssemblyAI.LemurStringResponseVariant1? Value1 { get; }
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
        public static implicit operator LemurStringResponse(global::AssemblyAI.LemurStringResponseVariant1 value) => new LemurStringResponse((global::AssemblyAI.LemurStringResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LemurStringResponseVariant1?(LemurStringResponse @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public LemurStringResponse(global::AssemblyAI.LemurStringResponseVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LemurBaseResponse? Value2 { get; init; }
#else
        public global::AssemblyAI.LemurBaseResponse? Value2 { get; }
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
        public static implicit operator LemurStringResponse(global::AssemblyAI.LemurBaseResponse value) => new LemurStringResponse((global::AssemblyAI.LemurBaseResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LemurBaseResponse?(LemurStringResponse @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public LemurStringResponse(global::AssemblyAI.LemurBaseResponse? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurStringResponse(
            global::AssemblyAI.LemurStringResponseVariant1? value1,
            global::AssemblyAI.LemurBaseResponse? value2
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
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
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
            global::System.Func<global::AssemblyAI.LemurStringResponseVariant1?, TResult>? value1 = null,
            global::System.Func<global::AssemblyAI.LemurBaseResponse?, TResult>? value2 = null,
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
            global::System.Action<global::AssemblyAI.LemurStringResponseVariant1?>? value1 = null,
            global::System.Action<global::AssemblyAI.LemurBaseResponse?>? value2 = null,
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
                typeof(global::AssemblyAI.LemurStringResponseVariant1),
                Value2,
                typeof(global::AssemblyAI.LemurBaseResponse),
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
        public bool Equals(LemurStringResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LemurStringResponseVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LemurBaseResponse?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurStringResponse obj1, LemurStringResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurStringResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurStringResponse obj1, LemurStringResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurStringResponse o && Equals(o);
        }
    }
}
