
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// tool variant
    /// </summary>
    public sealed partial class MessageVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.ToolMessageRoleJsonConverter))]
        public global::AssemblyAI.ToolMessageRole Role { get; set; }

        /// <summary>
        /// The result of the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The ID of the tool call that this message is responding to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageVariant4" /> class.
        /// </summary>
        /// <param name="content">
        /// The result of the tool call.
        /// </param>
        /// <param name="toolCallId">
        /// The ID of the tool call that this message is responding to.
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageVariant4(
            string content,
            string toolCallId,
            global::AssemblyAI.ToolMessageRole role)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageVariant4" /> class.
        /// </summary>
        public MessageVariant4()
        {
        }
    }
}