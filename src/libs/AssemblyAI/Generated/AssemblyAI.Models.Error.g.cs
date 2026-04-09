
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// Error message describing what went wrong
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error1 { get; set; }

        /// <summary>
        /// Error code for programmatic handling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional error details if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::AssemblyAI.ErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="error1">
        /// Error message describing what went wrong
        /// </param>
        /// <param name="code">
        /// Error code for programmatic handling
        /// </param>
        /// <param name="details">
        /// Additional error details if available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error(
            string error1,
            string? code,
            global::AssemblyAI.ErrorDetails? details)
        {
            this.Error1 = error1 ?? throw new global::System.ArgumentNullException(nameof(error1));
            this.Code = code;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }
    }
}