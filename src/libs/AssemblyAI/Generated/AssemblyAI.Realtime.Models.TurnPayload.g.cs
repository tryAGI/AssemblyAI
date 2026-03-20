
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Turn-based transcription result.
    /// </summary>
    public sealed partial class TurnPayload
    {
        /// <summary>
        /// Message type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.Realtime.JsonConverters.TurnPayloadTypeJsonConverter))]
        public global::AssemblyAI.Realtime.TurnPayloadType Type { get; set; }

        /// <summary>
        /// Order of this turn in the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TurnOrder { get; set; }

        /// <summary>
        /// Whether this turn has been formatted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_is_formatted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TurnIsFormatted { get; set; }

        /// <summary>
        /// Whether this marks the end of a turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_of_turn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EndOfTurn { get; set; }

        /// <summary>
        /// Transcript of all finalized words in the turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Finalized text at the moment a pause in speech is detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterance")]
        public string? Utterance { get; set; }

        /// <summary>
        /// Detected language code (when language detection is enabled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Language detection confidence (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence")]
        public double? LanguageConfidence { get; set; }

        /// <summary>
        /// Speaker label (when speaker_labels is enabled).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_label")]
        public string? SpeakerLabel { get; set; }

        /// <summary>
        /// Confidence this is end of turn (0-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_of_turn_confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndOfTurnConfidence { get; set; }

        /// <summary>
        /// Word-level details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.Realtime.Word> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// Message type identifier.
        /// </param>
        /// <param name="turnOrder">
        /// Order of this turn in the conversation.
        /// </param>
        /// <param name="turnIsFormatted">
        /// Whether this turn has been formatted.
        /// </param>
        /// <param name="endOfTurn">
        /// Whether this marks the end of a turn.
        /// </param>
        /// <param name="transcript">
        /// Transcript of all finalized words in the turn.
        /// </param>
        /// <param name="utterance">
        /// Finalized text at the moment a pause in speech is detected.
        /// </param>
        /// <param name="languageCode">
        /// Detected language code (when language detection is enabled).
        /// </param>
        /// <param name="languageConfidence">
        /// Language detection confidence (0-1).
        /// </param>
        /// <param name="speakerLabel">
        /// Speaker label (when speaker_labels is enabled).
        /// </param>
        /// <param name="endOfTurnConfidence">
        /// Confidence this is end of turn (0-1).
        /// </param>
        /// <param name="words">
        /// Word-level details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnPayload(
            int turnOrder,
            bool turnIsFormatted,
            bool endOfTurn,
            string transcript,
            double endOfTurnConfidence,
            global::System.Collections.Generic.IList<global::AssemblyAI.Realtime.Word> words,
            global::AssemblyAI.Realtime.TurnPayloadType type,
            string? utterance,
            string? languageCode,
            double? languageConfidence,
            string? speakerLabel)
        {
            this.TurnOrder = turnOrder;
            this.TurnIsFormatted = turnIsFormatted;
            this.EndOfTurn = endOfTurn;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.EndOfTurnConfidence = endOfTurnConfidence;
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.Type = type;
            this.Utterance = utterance;
            this.LanguageCode = languageCode;
            this.LanguageConfidence = languageConfidence;
            this.SpeakerLabel = speakerLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnPayload" /> class.
        /// </summary>
        public TurnPayload()
        {
        }
    }
}