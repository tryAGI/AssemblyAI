
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// The result of the Sentiment Analysis model<br/>
    /// Example: {"text":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts throughout the US.","start":250,"end":6350,"sentiment":"NEGATIVE","confidence":0.8181032538414001,"speaker":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}
    /// </summary>
    public sealed partial class SentimentAnalysisResult
    {
        /// <summary>
        /// The transcript of the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, of the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The ending time, in milliseconds, of the sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The detected sentiment for the sentence, one of POSITIVE, NEUTRAL, NEGATIVE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AssemblyAI.JsonConverters.SentimentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AssemblyAI.Sentiment Sentiment { get; set; }

        /// <summary>
        /// The confidence score for the detected sentiment of the sentence, from 0 to 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The channel of this utterance. The left and right channels are channels 1 and 2. Additional channels increment the channel number sequentially.
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
        /// Initializes a new instance of the <see cref="SentimentAnalysisResult" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcript of the sentence
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, of the sentence
        /// </param>
        /// <param name="end">
        /// The ending time, in milliseconds, of the sentence
        /// </param>
        /// <param name="sentiment">
        /// The detected sentiment for the sentence, one of POSITIVE, NEUTRAL, NEGATIVE
        /// </param>
        /// <param name="confidence">
        /// The confidence score for the detected sentiment of the sentence, from 0 to 1
        /// </param>
        /// <param name="channel">
        /// The channel of this utterance. The left and right channels are channels 1 and 2. Additional channels increment the channel number sequentially.
        /// </param>
        /// <param name="speaker">
        /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentAnalysisResult(
            string text,
            int start,
            int end,
            global::AssemblyAI.Sentiment sentiment,
            double confidence,
            string? speaker,
            string? channel)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
            this.Sentiment = sentiment;
            this.Confidence = confidence;
            this.Speaker = speaker ?? throw new global::System.ArgumentNullException(nameof(speaker));
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