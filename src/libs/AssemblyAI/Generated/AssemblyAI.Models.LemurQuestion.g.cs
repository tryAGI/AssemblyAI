
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurQuestion
    {
        /// <summary>
        /// How you want the answer to be returned. This can be any text. Can't be used with answer_options. Examples: "short sentence", "bullet points"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_format")]
        public string? AnswerFormat { get; set; }

        /// <summary>
        /// What discrete options to return. Useful for precise responses. Can't be used with answer_format. Example: ["Yes", "No"]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_options")]
        public global::System.Collections.Generic.IList<string>? AnswerOptions { get; set; }

        /// <summary>
        /// Any context about the transcripts you wish to provide. This can be a string or any object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::AssemblyAI.OneOf<string, object>? Context { get; set; }

        /// <summary>
        /// The question you wish to ask. For more complex questions use default model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurQuestion" /> class.
        /// </summary>
        /// <param name="answerFormat">
        /// How you want the answer to be returned. This can be any text. Can't be used with answer_options. Examples: "short sentence", "bullet points"
        /// </param>
        /// <param name="answerOptions">
        /// What discrete options to return. Useful for precise responses. Can't be used with answer_format. Example: ["Yes", "No"]
        /// </param>
        /// <param name="context">
        /// Any context about the transcripts you wish to provide. This can be a string or any object.
        /// </param>
        /// <param name="question">
        /// The question you wish to ask. For more complex questions use default model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LemurQuestion(
            string question,
            string? answerFormat,
            global::System.Collections.Generic.IList<string>? answerOptions,
            global::AssemblyAI.OneOf<string, object>? context)
        {
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.AnswerFormat = answerFormat;
            this.AnswerOptions = answerOptions;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurQuestion" /> class.
        /// </summary>
        public LemurQuestion()
        {
        }
    }
}