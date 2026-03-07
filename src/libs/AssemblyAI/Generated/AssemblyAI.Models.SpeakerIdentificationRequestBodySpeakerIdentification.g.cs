
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakerIdentificationRequestBodySpeakerIdentification
    {
        /// <summary>
        /// Type of speaker identification. See [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification) for details on each type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType SpeakerType { get; set; }

        /// <summary>
        /// Required if speaker_type is "role". Each value must be 35 characters or less.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("known_values")]
        public global::System.Collections.Generic.IList<string>? KnownValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerIdentificationRequestBodySpeakerIdentification" /> class.
        /// </summary>
        /// <param name="speakerType">
        /// Type of speaker identification. See [Speaker Identification](https://www.assemblyai.com/docs/speech-understanding/speaker-identification) for details on each type.
        /// </param>
        /// <param name="knownValues">
        /// Required if speaker_type is "role". Each value must be 35 characters or less.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerIdentificationRequestBodySpeakerIdentification(
            global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType speakerType,
            global::System.Collections.Generic.IList<string>? knownValues)
        {
            this.SpeakerType = speakerType;
            this.KnownValues = knownValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerIdentificationRequestBodySpeakerIdentification" /> class.
        /// </summary>
        public SpeakerIdentificationRequestBodySpeakerIdentification()
        {
        }
    }
}