
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Timestamp containing a start and end property in milliseconds
    /// </summary>
    public sealed partial class Timestamp
    {
        /// <summary>
        /// The end time in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The start time in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Timestamp" /> class.
        /// </summary>
        /// <param name="end">
        /// The end time in milliseconds
        /// </param>
        /// <param name="start">
        /// The start time in milliseconds
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Timestamp(
            int end,
            int start)
        {
            this.End = end;
            this.Start = start;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Timestamp" /> class.
        /// </summary>
        public Timestamp()
        {
        }
    }
}