
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurActionItemsParamsVariant2
    {
        /// <summary>
        /// How you want the action items to be returned. This can be any text.<br/>
        /// Defaults to "Bullet Points".<br/>
        /// Default Value: Bullet Points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_format")]
        public string? AnswerFormat { get; set; } = "Bullet Points";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}