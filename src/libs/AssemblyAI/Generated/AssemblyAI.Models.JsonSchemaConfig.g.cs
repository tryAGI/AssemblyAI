
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Configuration for JSON schema-based structured outputs.
    /// </summary>
    public sealed partial class JsonSchemaConfig
    {
        /// <summary>
        /// A name for the schema. Used for identification purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A valid JSON Schema object that defines the structure of the expected response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// When `true`, the model will strictly adhere to the schema. Recommended for reliable parsing.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaConfig" /> class.
        /// </summary>
        /// <param name="name">
        /// A name for the schema. Used for identification purposes.
        /// </param>
        /// <param name="schema">
        /// A valid JSON Schema object that defines the structure of the expected response.
        /// </param>
        /// <param name="strict">
        /// When `true`, the model will strictly adhere to the schema. Recommended for reliable parsing.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchemaConfig(
            string name,
            object schema,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaConfig" /> class.
        /// </summary>
        public JsonSchemaConfig()
        {
        }
    }
}