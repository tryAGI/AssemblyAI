
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Plant
    {
        /// <summary>
        /// The name of the plant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tag to specify the type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Plant" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the plant
        /// </param>
        /// <param name="tag">
        /// Tag to specify the type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Plant(
            string name,
            string? tag)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plant" /> class.
        /// </summary>
        public Plant()
        {
        }

    }
}