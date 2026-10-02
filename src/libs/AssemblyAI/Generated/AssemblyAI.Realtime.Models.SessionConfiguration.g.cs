
#nullable enable

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// Configuration actually applied by the server. Check model against the requested speech model because unrecognized query parameters may be ignored.
    /// </summary>
    public sealed partial class SessionConfiguration
    {
        /// <summary>
        /// Speech model selected by the server, for example universal-3-6-pro.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Applied latency and accuracy preset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Applied API version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Whether speaker diarization is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_labels")]
        public bool? SpeakerLabels { get; set; }

        /// <summary>
        /// Whether PII redaction is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii")]
        public bool? RedactPii { get; set; }

        /// <summary>
        /// Whether profanity filtering is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_profanity")]
        public bool? FilterProfanity { get; set; }

        /// <summary>
        /// Applied domain specialization, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Applied Voice Focus mode; null when disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_focus")]
        public string? VoiceFocus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfiguration" /> class.
        /// </summary>
        /// <param name="model">
        /// Speech model selected by the server, for example universal-3-6-pro.
        /// </param>
        /// <param name="mode">
        /// Applied latency and accuracy preset.
        /// </param>
        /// <param name="apiVersion">
        /// Applied API version.
        /// </param>
        /// <param name="speakerLabels">
        /// Whether speaker diarization is enabled.
        /// </param>
        /// <param name="redactPii">
        /// Whether PII redaction is enabled.
        /// </param>
        /// <param name="filterProfanity">
        /// Whether profanity filtering is enabled.
        /// </param>
        /// <param name="domain">
        /// Applied domain specialization, if any.
        /// </param>
        /// <param name="voiceFocus">
        /// Applied Voice Focus mode; null when disabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionConfiguration(
            string? model,
            string? mode,
            string? apiVersion,
            bool? speakerLabels,
            bool? redactPii,
            bool? filterProfanity,
            string? domain,
            string? voiceFocus)
        {
            this.Model = model;
            this.Mode = mode;
            this.ApiVersion = apiVersion;
            this.SpeakerLabels = speakerLabels;
            this.RedactPii = redactPii;
            this.FilterProfanity = filterProfanity;
            this.Domain = domain;
            this.VoiceFocus = voiceFocus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfiguration" /> class.
        /// </summary>
        public SessionConfiguration()
        {
        }

    }
}