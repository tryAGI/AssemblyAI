
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Specifies the format of the model's response. Use `json_schema` type to constrain the model to output valid JSON matching a schema.
    /// </summary>
    public sealed partial class ResponseFormat
    {
        /// <summary>
        /// The type of response format. Use `json_schema` for structured outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.ResponseFormatTypeJsonConverter))]
        public global::AssemblyAI.ResponseFormatType Type { get; set; }

        /// <summary>
        /// The JSON schema configuration object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.JsonSchemaConfig JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// The JSON schema configuration object.
        /// </param>
        /// <param name="type">
        /// The type of response format. Use `json_schema` for structured outputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormat(
            global::AssemblyAI.JsonSchemaConfig jsonSchema,
            global::AssemblyAI.ResponseFormatType type)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        public ResponseFormat()
        {
        }
    }
}