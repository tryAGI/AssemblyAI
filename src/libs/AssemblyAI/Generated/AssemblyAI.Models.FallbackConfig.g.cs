
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Configuration for fallback behavior. See [Specify fallback models](https://www.assemblyai.com/docs/llm-gateway/fallback) for more details.
    /// </summary>
    public sealed partial class FallbackConfig
    {
        /// <summary>
        /// Whether to automatically retry the request once after 500ms on failure. Defaults to `true`.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry")]
        public bool? Retry { get; set; }

        /// <summary>
        /// The maximum number of fallbacks to traverse. Defaults to `1`, with a maximum of `2`.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackConfig" /> class.
        /// </summary>
        /// <param name="retry">
        /// Whether to automatically retry the request once after 500ms on failure. Defaults to `true`.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="depth">
        /// The maximum number of fallbacks to traverse. Defaults to `1`, with a maximum of `2`.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackConfig(
            bool? retry,
            int? depth)
        {
            this.Retry = retry;
            this.Depth = depth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackConfig" /> class.
        /// </summary>
        public FallbackConfig()
        {
        }
    }
}