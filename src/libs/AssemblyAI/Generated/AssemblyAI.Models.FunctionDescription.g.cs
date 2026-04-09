
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDescription
    {
        /// <summary>
        /// The name of the function to be called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of what the function does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A JSON Schema object describing the parameters the function accepts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDescription" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function to be called.
        /// </param>
        /// <param name="parameters">
        /// A JSON Schema object describing the parameters the function accepts.
        /// </param>
        /// <param name="description">
        /// A description of what the function does.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDescription(
            string name,
            object parameters,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDescription" /> class.
        /// </summary>
        public FunctionDescription()
        {
        }
    }
}