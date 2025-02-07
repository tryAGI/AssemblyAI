
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurBaseParams
    {
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
        /// Custom formatted transcript data. Maximum size is the context limit of the selected model, which defaults to 100000.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        public string? InputText { get; set; }

        /// <summary>
        /// Max output size in tokens, up to 4000<br/>
        /// Default Value: 2000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_size")]
        public int? MaxOutputSize { get; set; }

        /// <summary>
        /// The temperature to use for the model.<br/>
        /// Higher values result in answers that are more creative, lower values are more conservative.<br/>
        /// Can be any value between 0.0 and 1.0 inclusive.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// A list of completed transcripts with text. Up to a maximum of 100 files or 100 hours, whichever is lower.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TranscriptIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseParams" /> class.
        /// </summary>
        /// <param name="context">
        /// Context to provide the model. This can be a string or a free-form JSON value.
        /// </param>
        /// <param name="finalModel">
        /// The model that is used for the final prompt after compression is performed.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="inputText">
        /// Custom formatted transcript data. Maximum size is the context limit of the selected model, which defaults to 100000.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </param>
        /// <param name="maxOutputSize">
        /// Max output size in tokens, up to 4000<br/>
        /// Default Value: 2000
        /// </param>
        /// <param name="temperature">
        /// The temperature to use for the model.<br/>
        /// Higher values result in answers that are more creative, lower values are more conservative.<br/>
        /// Can be any value between 0.0 and 1.0 inclusive.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="transcriptIds">
        /// A list of completed transcripts with text. Up to a maximum of 100 files or 100 hours, whichever is lower.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LemurBaseParams(
            global::AssemblyAI.AnyOf<global::AssemblyAI.LemurModel?, string> finalModel,
            global::AssemblyAI.OneOf<string, object>? context,
            string? inputText,
            int? maxOutputSize,
            float? temperature,
            global::System.Collections.Generic.IList<global::System.Guid>? transcriptIds)
        {
            this.FinalModel = finalModel;
            this.Context = context;
            this.InputText = inputText;
            this.MaxOutputSize = maxOutputSize;
            this.Temperature = temperature;
            this.TranscriptIds = transcriptIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseParams" /> class.
        /// </summary>
        public LemurBaseParams()
        {
        }
    }
}