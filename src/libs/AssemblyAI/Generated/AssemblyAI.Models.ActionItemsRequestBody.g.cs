
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Request body for [Action Items](https://www.assemblyai.com/docs/speech-understanding/action-items).
    /// </summary>
    public sealed partial class ActionItemsRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.ActionItemsRequestBodyActionItems ActionItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionItemsRequestBody" /> class.
        /// </summary>
        /// <param name="actionItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionItemsRequestBody(
            global::AssemblyAI.ActionItemsRequestBodyActionItems actionItems)
        {
            this.ActionItems = actionItems ?? throw new global::System.ArgumentNullException(nameof(actionItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionItemsRequestBody" /> class.
        /// </summary>
        public ActionItemsRequestBody()
        {
        }

    }
}