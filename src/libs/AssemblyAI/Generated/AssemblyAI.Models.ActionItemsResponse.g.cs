
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionItemsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_items")]
        public global::AssemblyAI.ActionItemsResponseActionItems? ActionItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionItemsResponse" /> class.
        /// </summary>
        /// <param name="actionItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionItemsResponse(
            global::AssemblyAI.ActionItemsResponseActionItems? actionItems)
        {
            this.ActionItems = actionItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionItemsResponse" /> class.
        /// </summary>
        public ActionItemsResponse()
        {
        }

    }
}