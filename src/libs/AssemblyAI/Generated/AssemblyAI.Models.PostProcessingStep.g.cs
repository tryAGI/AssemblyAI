
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A single post-processing operation to apply to the model's response.
    /// </summary>
    public sealed partial class PostProcessingStep
    {
        /// <summary>
        /// The type of post-processing to apply. Currently `json-repair` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.PostProcessingStepTypeJsonConverter))]
        public global::AssemblyAI.PostProcessingStepType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostProcessingStep" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of post-processing to apply. Currently `json-repair` is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostProcessingStep(
            global::AssemblyAI.PostProcessingStepType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostProcessingStep" /> class.
        /// </summary>
        public PostProcessingStep()
        {
        }
    }
}