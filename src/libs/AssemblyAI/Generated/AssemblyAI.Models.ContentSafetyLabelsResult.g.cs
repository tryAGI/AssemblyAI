
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// An array of results for the Content Moderation model, if it is enabled.<br/>
    /// See [Content moderation](https://www.assemblyai.com/docs/models/content-moderation) for more information.
    /// </summary>
    public sealed partial class ContentSafetyLabelsResult
    {
        /// <summary>
        /// Either success, or unavailable in the rare case that the model failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AudioIntelligenceModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.AudioIntelligenceModelStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.ContentSafetyLabelResult> Results { get; set; }

        /// <summary>
        /// A summary of the Content Moderation confidence results for the entire audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.ContentSafetyLabelsResultSummary Summary { get; set; }

        /// <summary>
        /// A summary of the Content Moderation severity results for the entire audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_score_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.ContentSafetyLabelsResultSeverityScoreSummary SeverityScoreSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}