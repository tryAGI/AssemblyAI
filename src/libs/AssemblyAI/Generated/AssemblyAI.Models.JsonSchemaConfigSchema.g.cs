
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A valid JSON Schema object that defines the structure of the expected response.
    /// </summary>
    public sealed partial class JsonSchemaConfigSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}