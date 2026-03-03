
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomFormattingResponseCustomFormatting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? Mapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted_text")]
        public string? FormattedText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormattingResponseCustomFormatting" /> class.
        /// </summary>
        /// <param name="mapping"></param>
        /// <param name="formattedText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomFormattingResponseCustomFormatting(
            global::System.Collections.Generic.Dictionary<string, string>? mapping,
            string? formattedText)
        {
            this.Mapping = mapping;
            this.FormattedText = formattedText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormattingResponseCustomFormatting" /> class.
        /// </summary>
        public CustomFormattingResponseCustomFormatting()
        {
        }
    }
}