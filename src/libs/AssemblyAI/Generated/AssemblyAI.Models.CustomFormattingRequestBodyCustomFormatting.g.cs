
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomFormattingRequestBodyCustomFormatting
    {
        /// <summary>
        /// Date format pattern (e.g., `"mm/dd/yyyy"`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Phone number format pattern (e.g., `"(xxx)xxx-xxxx"`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Email format pattern (e.g., `"username@domain.com"`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormattingRequestBodyCustomFormatting" /> class.
        /// </summary>
        /// <param name="date">
        /// Date format pattern (e.g., `"mm/dd/yyyy"`)
        /// </param>
        /// <param name="phoneNumber">
        /// Phone number format pattern (e.g., `"(xxx)xxx-xxxx"`)
        /// </param>
        /// <param name="email">
        /// Email format pattern (e.g., `"username@domain.com"`)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomFormattingRequestBodyCustomFormatting(
            string? date,
            string? phoneNumber,
            string? email)
        {
            this.Date = date;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFormattingRequestBodyCustomFormatting" /> class.
        /// </summary>
        public CustomFormattingRequestBodyCustomFormatting()
        {
        }
    }
}