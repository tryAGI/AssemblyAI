
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadedFile
    {
        /// <summary>
        /// A URL that points to your audio file, accessible only by AssemblyAI's servers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}