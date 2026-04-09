
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptWord
    {
        /// <summary>
        /// The confidence score for the transcript of this word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, for the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The ending time, in milliseconds, for the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The text of the word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The channel of the word. The left and right channels are channels 1 and 2. Additional channels increment the channel number sequentially.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// The speaker of the word if [Speaker Diarization](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization) is enabled, else null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptWord" /> class.
        /// </summary>
        /// <param name="confidence">
        /// The confidence score for the transcript of this word
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, for the word
        /// </param>
        /// <param name="end">
        /// The ending time, in milliseconds, for the word
        /// </param>
        /// <param name="text">
        /// The text of the word
        /// </param>
        /// <param name="channel">
        /// The channel of the word. The left and right channels are channels 1 and 2. Additional channels increment the channel number sequentially.
        /// </param>
        /// <param name="speaker">
        /// The speaker of the word if [Speaker Diarization](https://www.assemblyai.com/docs/pre-recorded-audio/speaker-diarization) is enabled, else null
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptWord(
            double confidence,
            int start,
            int end,
            string text,
            string? channel,
            string? speaker)
        {
            this.Confidence = confidence;
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Channel = channel;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptWord" /> class.
        /// </summary>
        public TranscriptWord()
        {
        }
    }
}