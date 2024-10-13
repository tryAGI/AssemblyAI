
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Details of the transcript page. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
    /// </summary>
    public sealed partial class PageDetails
    {
        /// <summary>
        /// The number of results this page is limited to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// The actual number of results in the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResultCount { get; set; }

        /// <summary>
        /// The URL used to retrieve the current page of transcripts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentUrl { get; set; }

        /// <summary>
        /// The URL to the next page of transcripts. The previous URL always points to a page with older transcripts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? PrevUrl { get; set; }

        /// <summary>
        /// The URL to the next page of transcripts. The next URL always points to a page with newer transcripts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? NextUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::AssemblyAI.PageDetails? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::AssemblyAI.PageDetails),
                jsonSerializerContext) as global::AssemblyAI.PageDetails;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::AssemblyAI.PageDetails? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::AssemblyAI.PageDetails>(
                json,
                jsonSerializerOptions);
        }

    }
}