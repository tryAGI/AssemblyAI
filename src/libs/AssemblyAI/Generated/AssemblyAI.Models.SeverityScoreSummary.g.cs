
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SeverityScoreSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double High { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Low { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Medium { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SeverityScoreSummary" /> class.
        /// </summary>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <param name="medium"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SeverityScoreSummary(
            double high,
            double low,
            double medium)
        {
            this.High = high;
            this.Low = low;
            this.Medium = medium;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeverityScoreSummary" /> class.
        /// </summary>
        public SeverityScoreSummary()
        {
        }
    }
}