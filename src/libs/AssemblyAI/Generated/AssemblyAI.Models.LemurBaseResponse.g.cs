
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurBaseResponse
    {
        /// <summary>
        /// The ID of the LeMUR request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// The usage numbers for the LeMUR request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.LemurUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The ID of the LeMUR request
        /// </param>
        /// <param name="usage">
        /// The usage numbers for the LeMUR request
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LemurBaseResponse(
            global::System.Guid requestId,
            global::AssemblyAI.LemurUsage usage)
        {
            this.RequestId = requestId;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseResponse" /> class.
        /// </summary>
        public LemurBaseResponse()
        {
        }
    }
}