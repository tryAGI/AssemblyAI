
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomFormattingRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_formatting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.CustomFormattingRequestBodyCustomFormatting CustomFormatting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormattingRequestBody" /> class.
        /// </summary>
        /// <param name="customFormatting"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomFormattingRequestBody(
            global::AssemblyAI.CustomFormattingRequestBodyCustomFormatting customFormatting)
        {
            this.CustomFormatting = customFormatting ?? throw new global::System.ArgumentNullException(nameof(customFormatting));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormattingRequestBody" /> class.
        /// </summary>
        public CustomFormattingRequestBody()
        {
        }
    }
}