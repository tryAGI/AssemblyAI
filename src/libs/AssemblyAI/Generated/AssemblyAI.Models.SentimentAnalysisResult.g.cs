
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The result of the Sentiment Analysis model
    /// </summary>
    public sealed partial class SentimentAnalysisResult
    {
        /// <summary>
        /// The channel of this utterance. The left and right channels are channels 1 and 2. Additional channels increment the channel number sequentially.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// The confidence score for the detected sentiment of the sentence, from 0 to 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The ending time, in milliseconds, of the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SentimentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.Sentiment Sentiment { get; set; }

        /// <summary>
        /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Speaker { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, of the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The transcript of the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResult" /> class.
        /// </summary>
        /// <param name="channel">
        /// The channel of this utterance. The left and right channels are channels 1 and 2. Additional channels increment the channel number sequentially.
        /// </param>
        /// <param name="confidence">
        /// The confidence score for the detected sentiment of the sentence, from 0 to 1
        /// </param>
        /// <param name="end">
        /// The ending time, in milliseconds, of the sentence
        /// </param>
        /// <param name="sentiment"></param>
        /// <param name="speaker">
        /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, of the sentence
        /// </param>
        /// <param name="text">
        /// The transcript of the sentence
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SentimentAnalysisResult(
            double confidence,
            int end,
            global::AssemblyAI.Sentiment sentiment,
            string? speaker,
            int start,
            string text,
            string? channel)
        {
            this.Confidence = confidence;
            this.End = end;
            this.Sentiment = sentiment;
            this.Speaker = speaker ?? throw new global::System.ArgumentNullException(nameof(speaker));
            this.Start = start;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResult" /> class.
        /// </summary>
        public SentimentAnalysisResult()
        {
        }
    }
}