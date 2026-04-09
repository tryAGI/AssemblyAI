
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public global::System.Guid? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.Choice>? Choices { get; set; }

        /// <summary>
        /// A copy of the original request, excluding `prompt` and `messages`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::AssemblyAI.ResponseRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::AssemblyAI.Usage? Usage { get; set; }

        /// <summary>
        /// The HTTP status code of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_status_code")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The response time in nanoseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_time")]
        public long? ResponseTime { get; set; }

        /// <summary>
        /// The status code from the LLM provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_status_code")]
        public int? LlmStatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="choices"></param>
        /// <param name="request">
        /// A copy of the original request, excluding `prompt` and `messages`.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="httpStatusCode">
        /// The HTTP status code of the response
        /// </param>
        /// <param name="responseTime">
        /// The response time in nanoseconds
        /// </param>
        /// <param name="llmStatusCode">
        /// The status code from the LLM provider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response(
            global::System.Guid? requestId,
            global::System.Collections.Generic.IList<global::AssemblyAI.Choice>? choices,
            global::AssemblyAI.ResponseRequest? request,
            global::AssemblyAI.Usage? usage,
            int? httpStatusCode,
            long? responseTime,
            int? llmStatusCode)
        {
            this.RequestId = requestId;
            this.Choices = choices;
            this.Request = request;
            this.Usage = usage;
            this.HttpStatusCode = httpStatusCode;
            this.ResponseTime = responseTime;
            this.LlmStatusCode = llmStatusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        public Response()
        {
        }
    }
}