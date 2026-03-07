
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// Request body for [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification).
    /// </summary>
    public sealed partial class SpeakerIdentificationRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_identification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentification SpeakerIdentification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerIdentificationRequestBody" /> class.
        /// </summary>
        /// <param name="speakerIdentification"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerIdentificationRequestBody(
            global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentification speakerIdentification)
        {
            this.SpeakerIdentification = speakerIdentification ?? throw new global::System.ArgumentNullException(nameof(speakerIdentification));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerIdentificationRequestBody" /> class.
        /// </summary>
        public SpeakerIdentificationRequestBody()
        {
        }
    }
}