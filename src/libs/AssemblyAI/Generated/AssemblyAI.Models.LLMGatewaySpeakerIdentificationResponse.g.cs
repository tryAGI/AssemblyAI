
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMGatewaySpeakerIdentificationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_understanding")]
        public global::AssemblyAI.LlmGatewaySpeakerIdentificationResponseSpeechUnderstanding? SpeechUnderstanding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewaySpeakerIdentificationResponseUtterancesItems>? Utterances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewaySpeakerIdentificationResponseWordsItems>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGatewaySpeakerIdentificationResponse" /> class.
        /// </summary>
        /// <param name="speechUnderstanding"></param>
        /// <param name="utterances"></param>
        /// <param name="words"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMGatewaySpeakerIdentificationResponse(
            global::AssemblyAI.LlmGatewaySpeakerIdentificationResponseSpeechUnderstanding? speechUnderstanding,
            global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewaySpeakerIdentificationResponseUtterancesItems>? utterances,
            global::System.Collections.Generic.IList<global::AssemblyAI.LlmGatewaySpeakerIdentificationResponseWordsItems>? words)
        {
            this.SpeechUnderstanding = speechUnderstanding;
            this.Utterances = utterances;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMGatewaySpeakerIdentificationResponse" /> class.
        /// </summary>
        public LLMGatewaySpeakerIdentificationResponse()
        {
        }
    }
}