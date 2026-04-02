#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// LeMUR task parameters<br/>
    /// Example: {"transcript_ids":["64nygnr62k-405c-4ae8-8a6b-d90b40ff3cce"],"prompt":"List all the locations affected by wildfires.","final_model":"anthropic/claude-sonnet-4-20250514","temperature":0,"max_output_size":3000}
    /// </summary>
    public readonly partial struct LemurTaskParams : global::System.IEquatable<LemurTaskParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LemurTaskParamsVariant1? LemurTaskParamsVariant1 { get; init; }
#else
        public global::AssemblyAI.LemurTaskParamsVariant1? LemurTaskParamsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LemurTaskParamsVariant1))]
#endif
        public bool IsLemurTaskParamsVariant1 => LemurTaskParamsVariant1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurTaskParams(global::AssemblyAI.LemurTaskParamsVariant1 value) => new LemurTaskParams((global::AssemblyAI.LemurTaskParamsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LemurTaskParamsVariant1?(LemurTaskParams @this) => @this.LemurTaskParamsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public LemurTaskParams(global::AssemblyAI.LemurTaskParamsVariant1? value)
        {
            LemurTaskParamsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LemurTaskParamsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            LemurTaskParamsVariant1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLemurTaskParamsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AssemblyAI.LemurTaskParamsVariant1?, TResult>? lemurTaskParamsVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLemurTaskParamsVariant1 && lemurTaskParamsVariant1 != null)
            {
                return lemurTaskParamsVariant1(LemurTaskParamsVariant1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AssemblyAI.LemurTaskParamsVariant1?>? lemurTaskParamsVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLemurTaskParamsVariant1)
            {
                lemurTaskParamsVariant1?.Invoke(LemurTaskParamsVariant1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LemurTaskParamsVariant1,
                typeof(global::AssemblyAI.LemurTaskParamsVariant1),
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
        public bool Equals(LemurTaskParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LemurTaskParamsVariant1?>.Default.Equals(LemurTaskParamsVariant1, other.LemurTaskParamsVariant1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurTaskParams obj1, LemurTaskParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurTaskParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurTaskParams obj1, LemurTaskParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurTaskParams o && Equals(o);
        }
    }
}
