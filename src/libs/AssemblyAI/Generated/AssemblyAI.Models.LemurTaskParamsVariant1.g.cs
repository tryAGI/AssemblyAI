
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurTaskParamsVariant1
    {
        /// <summary>
        /// The model that is used for the final prompt after compression is performed.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.LemurModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.LemurModel FinalModel { get; set; }

        /// <summary>
        /// Custom formatted transcript data. Maximum size is the context limit of the selected model.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        public string? InputText { get; set; }

        /// <summary>
        /// Maximum output size in tokens, up to the `final_model`'s max [(see chart)](/docs/lemur/customize-parameters#change-the-maximum-output-size).<br/>
        /// Default Value: 2000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_size")]
        public int? MaxOutputSize { get; set; }

        /// <summary>
        /// Your text to prompt the model to produce a desired output, including any context you want to pass into the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The temperature to use for the model.<br/>
        /// Higher values result in answers that are more creative, lower values are more conservative.<br/>
        /// Can be any value between 0.0 and 1.0 inclusive.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// A list of completed transcripts with text. Up to a maximum of 100 hours of audio.<br/>
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
        /// Initializes a new instance of the <see cref="LemurTaskParamsVariant1" /> class.
        /// </summary>
        /// <param name="finalModel">
        /// The model that is used for the final prompt after compression is performed.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="inputText">
        /// Custom formatted transcript data. Maximum size is the context limit of the selected model.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </param>
        /// <param name="maxOutputSize">
        /// Maximum output size in tokens, up to the `final_model`'s max [(see chart)](/docs/lemur/customize-parameters#change-the-maximum-output-size).<br/>
        /// Default Value: 2000
        /// </param>
        /// <param name="prompt">
        /// Your text to prompt the model to produce a desired output, including any context you want to pass into the model.
        /// </param>
        /// <param name="temperature">
        /// The temperature to use for the model.<br/>
        /// Higher values result in answers that are more creative, lower values are more conservative.<br/>
        /// Can be any value between 0.0 and 1.0 inclusive.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="transcriptIds">
        /// A list of completed transcripts with text. Up to a maximum of 100 hours of audio.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LemurTaskParamsVariant1(
            global::AssemblyAI.LemurModel finalModel,
            string prompt,
            string? inputText,
            int? maxOutputSize,
            float? temperature,
            global::System.Collections.Generic.IList<global::System.Guid>? transcriptIds)
        {
            this.FinalModel = finalModel;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.InputText = inputText;
            this.MaxOutputSize = maxOutputSize;
            this.Temperature = temperature;
            this.TranscriptIds = transcriptIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurTaskParamsVariant1" /> class.
        /// </summary>
        public LemurTaskParamsVariant1()
        {
        }
    }
}