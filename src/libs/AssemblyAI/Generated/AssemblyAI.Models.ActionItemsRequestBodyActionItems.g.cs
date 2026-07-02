
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionItemsRequestBodyActionItems
    {
        /// <summary>
        /// Option to include decision making in action items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_decisions")]
        public object? IncludeDecisions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.ActionItemsRequestBodyActionItemsEffortJsonConverter))]
        public global::AssemblyAI.ActionItemsRequestBodyActionItemsEffort? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionItemsRequestBodyActionItems" /> class.
        /// </summary>
        /// <param name="includeDecisions">
        /// Option to include decision making in action items.
        /// </param>
        /// <param name="effort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionItemsRequestBodyActionItems(
            object? includeDecisions,
            global::AssemblyAI.ActionItemsRequestBodyActionItemsEffort? effort)
        {
            this.IncludeDecisions = includeDecisions;
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionItemsRequestBodyActionItems" /> class.
        /// </summary>
        public ActionItemsRequestBodyActionItems()
        {
        }

    }
}