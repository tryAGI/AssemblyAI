
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// A JSON Schema object describing the parameters the function accepts.
    /// </summary>
    public sealed partial class FunctionDescriptionParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}