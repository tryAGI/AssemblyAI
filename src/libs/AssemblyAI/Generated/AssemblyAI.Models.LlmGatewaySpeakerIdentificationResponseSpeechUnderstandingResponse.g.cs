
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_identification")]
        public global::AssemblyAI.LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponseSpeakerIdentification? SpeakerIdentification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponse" /> class.
        /// </summary>
        /// <param name="speakerIdentification"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponse(
            global::AssemblyAI.LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponseSpeakerIdentification? speakerIdentification)
        {
            this.SpeakerIdentification = speakerIdentification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponse" /> class.
        /// </summary>
        public LlmGatewaySpeakerIdentificationResponseSpeechUnderstandingResponse()
        {
        }
    }
}