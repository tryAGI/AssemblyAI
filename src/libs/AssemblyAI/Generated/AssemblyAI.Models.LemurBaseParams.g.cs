
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// LeMUR base parameters<br/>
    /// Example: {"transcript_ids":["85f9b381-e90c-46ed-beca-7d76245d375e","7c3acd18-df4d-4432-88f5-1e89f8827eea"],"context":"This is an interview about wildfires.","final_model":"anthropic/claude-sonnet-4-20250514","temperature":0,"max_output_size":3000}
    /// </summary>
    public sealed partial class LemurBaseParams
    {
        /// <summary>
        /// A list of completed transcripts with text. Up to a maximum of 100 hours of audio.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TranscriptIds { get; set; }

        /// <summary>
        /// Custom formatted transcript data. Maximum size is the context limit of the selected model.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        public string? InputText { get; set; }

        /// <summary>
        /// Context to provide the model. This can be a string or a free-form JSON value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::AssemblyAI.OneOf<string, object>? Context { get; set; }

        /// <summary>
        /// The model that is used for the final prompt after compression is performed.<br/>
        /// Default Value: default
        /// </summary>
        /// <default>"default"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.AnyOfJsonConverter<global::AssemblyAI.LemurModel?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.AnyOf<global::AssemblyAI.LemurModel?, string> FinalModel { get; set; } = "default";

        /// <summary>
        /// Maximum output size in tokens, up to the `final_model`'s max [(see chart)](/docs/lemur/customize-parameters#change-the-maximum-output-size).<br/>
        /// Default Value: 2000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_size")]
        public int? MaxOutputSize { get; set; }

        /// <summary>
        /// The temperature to use for the model.<br/>
        /// Higher values result in answers that are more creative, lower values are more conservative.<br/>
        /// Can be any value between 0.0 and 1.0 inclusive.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseParams" /> class.
        /// </summary>
        /// <param name="transcriptIds">
        /// A list of completed transcripts with text. Up to a maximum of 100 hours of audio.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </param>
        /// <param name="inputText">
        /// Custom formatted transcript data. Maximum size is the context limit of the selected model.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </param>
        /// <param name="context">
        /// Context to provide the model. This can be a string or a free-form JSON value.
        /// </param>
        /// <param name="finalModel">
        /// The model that is used for the final prompt after compression is performed.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="maxOutputSize">
        /// Maximum output size in tokens, up to the `final_model`'s max [(see chart)](/docs/lemur/customize-parameters#change-the-maximum-output-size).<br/>
        /// Default Value: 2000
        /// </param>
        /// <param name="temperature">
        /// The temperature to use for the model.<br/>
        /// Higher values result in answers that are more creative, lower values are more conservative.<br/>
        /// Can be any value between 0.0 and 1.0 inclusive.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LemurBaseParams(
            global::AssemblyAI.AnyOf<global::AssemblyAI.LemurModel?, string> finalModel,
            global::System.Collections.Generic.IList<global::System.Guid>? transcriptIds,
            string? inputText,
            global::AssemblyAI.OneOf<string, object>? context,
            int? maxOutputSize,
            float? temperature)
        {
            this.FinalModel = finalModel;
            this.TranscriptIds = transcriptIds;
            this.InputText = inputText;
            this.Context = context;
            this.MaxOutputSize = maxOutputSize;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseParams" /> class.
        /// </summary>
        public LemurBaseParams()
        {
        }
    }
}