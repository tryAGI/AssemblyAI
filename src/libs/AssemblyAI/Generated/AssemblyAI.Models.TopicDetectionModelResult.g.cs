
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The result of the Topic Detection model, if it is enabled.<br/>
    /// See [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) for more information.
    /// </summary>
    public sealed partial class TopicDetectionModelResult
    {
        /// <summary>
        /// An array of results for the Topic Detection model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResult> Results { get; set; }

        /// <summary>
        /// Either success, or unavailable in the rare case that the model failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.AudioIntelligenceModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.AudioIntelligenceModelStatus Status { get; set; }

        /// <summary>
        /// The overall relevance of topic to the entire audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionModelResult" /> class.
        /// </summary>
        /// <param name="results">
        /// An array of results for the Topic Detection model
        /// </param>
        /// <param name="status">
        /// Either success, or unavailable in the rare case that the model failed
        /// </param>
        /// <param name="summary">
        /// The overall relevance of topic to the entire audio file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicDetectionModelResult(
            global::System.Collections.Generic.IList<global::AssemblyAI.TopicDetectionResult> results,
            global::AssemblyAI.AudioIntelligenceModelStatus status,
            global::System.Collections.Generic.Dictionary<string, double> summary)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Status = status;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionModelResult" /> class.
        /// </summary>
        public TopicDetectionModelResult()
        {
        }
    }
}