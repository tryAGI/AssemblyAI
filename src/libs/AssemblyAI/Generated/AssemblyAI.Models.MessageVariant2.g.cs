
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// assistant variant
    /// </summary>
    public sealed partial class MessageVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.UserAssistantSystemMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.UserAssistantSystemMessageRole Role { get; set; }

        /// <summary>
        /// The content of the message. Can be a string or an array of content parts (for user messages).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.UserAssistantSystemMessageContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.UserAssistantSystemMessageContent Content { get; set; }

        /// <summary>
        /// An optional name for the participant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageVariant2" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content">
        /// The content of the message. Can be a string or an array of content parts (for user messages).
        /// </param>
        /// <param name="name">
        /// An optional name for the participant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageVariant2(
            global::AssemblyAI.UserAssistantSystemMessageRole role,
            global::AssemblyAI.UserAssistantSystemMessageContent content,
            string? name)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageVariant2" /> class.
        /// </summary>
        public MessageVariant2()
        {
        }
    }
}