
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
        /// An array of speaker objects with metadata to improve identification accuracy. Each object should include a `role` or `name` (depending on `speaker_type`) and an optional `description` to help the model identify the speaker. You can also include any additional custom properties (e.g., `company`, `title`) to provide more context. Use this as an alternative to `known_values` when you want to provide additional context about each speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers")]
        public global::System.Collections.Generic.IList<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakersItems>? Speakers { get; set; }

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
        /// <param name="speakers">
        /// An array of speaker objects with metadata to improve identification accuracy. Each object should include a `role` or `name` (depending on `speaker_type`) and an optional `description` to help the model identify the speaker. You can also include any additional custom properties (e.g., `company`, `title`) to provide more context. Use this as an alternative to `known_values` when you want to provide additional context about each speaker.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeakerIdentificationRequestBodySpeakerIdentification(
            global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakerType speakerType,
            global::System.Collections.Generic.IList<string>? knownValues,
            global::System.Collections.Generic.IList<global::AssemblyAI.SpeakerIdentificationRequestBodySpeakerIdentificationSpeakersItems>? speakers)
        {
            this.SpeakerType = speakerType;
            this.KnownValues = knownValues;
            this.Speakers = speakers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerIdentificationRequestBodySpeakerIdentification" /> class.
        /// </summary>
        public SpeakerIdentificationRequestBodySpeakerIdentification()
        {
        }
    }
}