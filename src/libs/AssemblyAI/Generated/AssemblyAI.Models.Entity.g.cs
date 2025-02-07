
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A detected entity
    /// </summary>
    public sealed partial class Entity
    {
        /// <summary>
        /// The ending time, in milliseconds, for the detected entity in the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The type of entity for the detected entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.EntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.EntityType EntityType { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, at which the detected entity appears in the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The text for the detected entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="end">
        /// The ending time, in milliseconds, for the detected entity in the audio file
        /// </param>
        /// <param name="entityType">
        /// The type of entity for the detected entity
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, at which the detected entity appears in the audio file
        /// </param>
        /// <param name="text">
        /// The text for the detected entity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Entity(
            int end,
            global::AssemblyAI.EntityType entityType,
            int start,
            string text)
        {
            this.End = end;
            this.EntityType = entityType;
            this.Start = start;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        public Entity()
        {
        }
    }
}