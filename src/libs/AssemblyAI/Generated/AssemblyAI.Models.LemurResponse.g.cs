using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LemurResponse : global::System.IEquatable<LemurResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LemurStringResponse? String { get; init; }
#else
        public global::AssemblyAI.LemurStringResponse? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurResponse(global::AssemblyAI.LemurStringResponse value) => new LemurResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LemurStringResponse?(LemurResponse @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public LemurResponse(global::AssemblyAI.LemurStringResponse? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AssemblyAI.LemurQuestionAnswerResponse? QuestionAnswer { get; init; }
#else
        public global::AssemblyAI.LemurQuestionAnswerResponse? QuestionAnswer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QuestionAnswer))]
#endif
        public bool IsQuestionAnswer => QuestionAnswer != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurResponse(global::AssemblyAI.LemurQuestionAnswerResponse value) => new LemurResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AssemblyAI.LemurQuestionAnswerResponse?(LemurResponse @this) => @this.QuestionAnswer;

        /// <summary>
        /// 
        /// </summary>
        public LemurResponse(global::AssemblyAI.LemurQuestionAnswerResponse? value)
        {
            QuestionAnswer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurResponse(
            global::AssemblyAI.LemurStringResponse? @string,
            global::AssemblyAI.LemurQuestionAnswerResponse? questionAnswer
            )
        {
            String = @string;
            QuestionAnswer = questionAnswer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            QuestionAnswer as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsQuestionAnswer || !IsString && IsQuestionAnswer;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::AssemblyAI.LemurStringResponse),
                QuestionAnswer,
                typeof(global::AssemblyAI.LemurQuestionAnswerResponse),
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
        public bool Equals(LemurResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LemurStringResponse?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::AssemblyAI.LemurQuestionAnswerResponse?>.Default.Equals(QuestionAnswer, other.QuestionAnswer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurResponse obj1, LemurResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurResponse obj1, LemurResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurResponse o && Equals(o);
        }
    }
}