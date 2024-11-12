
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptSentence
    {
        /// <summary>
        /// The transcript of the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, for the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The ending time, in milliseconds, for the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The confidence score for the transcript of this sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// An array of words in the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord> Words { get; set; }

        /// <summary>
        /// The channel of the sentence. The left and right channels are channels 1 and 2. Additional channels increment the channel number sequentially.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptSentence" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcript of the sentence
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, for the sentence
        /// </param>
        /// <param name="end">
        /// The ending time, in milliseconds, for the sentence
        /// </param>
        /// <param name="confidence">
        /// The confidence score for the transcript of this sentence
        /// </param>
        /// <param name="words">
        /// An array of words in the sentence
        /// </param>
        /// <param name="channel">
        /// The channel of the sentence. The left and right channels are channels 1 and 2. Additional channels increment the channel number sequentially.
        /// </param>
        /// <param name="speaker">
        /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptSentence(
            string text,
            int start,
            int end,
            double confidence,
            global::System.Collections.Generic.IList<global::AssemblyAI.TranscriptWord> words,
            string? speaker,
            string? channel)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.Speaker = speaker ?? throw new global::System.ArgumentNullException(nameof(speaker));
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptSentence" /> class.
        /// </summary>
        public TranscriptSentence()
        {
        }
    }
}