
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker
    {
        /// <summary>
        /// The role of the speaker. Required when `speaker_type` is "role".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// The name of the speaker. Required when `speaker_type` is "name".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the speaker to help the model identify them based on conversational context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the speaker. Required when `speaker_type` is "role".
        /// </param>
        /// <param name="name">
        /// The name of the speaker. Required when `speaker_type` is "name".
        /// </param>
        /// <param name="description">
        /// A description of the speaker to help the model identify them based on conversational context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker(
            string? role,
            string? name,
            string? description)
        {
            this.Role = role;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker" /> class.
        /// </summary>
        public SpeakerIdentificationRequestBodySpeakerIdentificationSpeaker()
        {
        }
    }
}