using System.Globalization;
using System.Text;

namespace AssemblyAI.Realtime;

/// <summary>
/// Typed connection options for AssemblyAI's v3 streaming WebSocket API.
/// Use with the <c>AssemblyAIRealtimeClientStreamingExtensions.ConnectAsync</c> extension methods.
/// Auth: pass the API key to the <c>ConnectAsync(client, apiKey, options, …)</c> overload (sets the
/// <c>Authorization</c> header — recommended for server-side); for browser-side use, set
/// <see cref="Token"/> to a temporary token from the streaming token endpoint.
/// </summary>
public sealed record StreamingConnectOptions
{
    /// <summary>Audio sample rate in Hz. Default 16000.</summary>
    public int SampleRate { get; init; } = 16000;

    /// <summary>
    /// Speech model to use for the streaming session. Defaults to <c>u3-rt-pro</c>,
    /// AssemblyAI's current Universal-3.5 Pro Realtime model.
    /// </summary>
    public StreamingSpeechModel SpeechModel { get; init; } = StreamingSpeechModel.Universal35ProRealtime;

    /// <summary>Audio encoding. v3 supports <c>pcm_s16le</c> (default) and <c>pcm_mulaw</c>.</summary>
    public string Encoding { get; init; } = "pcm_s16le";

    /// <summary>Whether the server should produce formatted (punctuated, capitalized) turn output.</summary>
    public bool FormatTurns { get; init; }

    /// <summary>Optional contextual prompt describing the audio domain, scenario, or conversation details.</summary>
    public string? Prompt { get; init; }

    /// <summary>Your voice agent's spoken text. Used as context for the user's next turn.</summary>
    public string? AgentContext { get; init; }

    /// <summary>Optional list of keyterms to bias transcription. Sent as a single <c>keyterms_prompt</c> query parameter containing a JSON-encoded array (the format AssemblyAI's v3 streaming API expects).</summary>
    public IReadOnlyList<string>? KeytermsPrompt { get; init; }

    /// <summary>Latency and accuracy preset, for example <c>min_latency</c>, <c>balanced</c>, or <c>max_accuracy</c>.</summary>
    public StreamingMode? Mode { get; init; }

    /// <summary>Steer transcription toward a specific language code while still allowing token-level transcription.</summary>
    public StreamingLanguageCode? LanguageCode { get; init; }

    /// <summary>Whether to include detected language metadata in turn messages.</summary>
    public bool? LanguageDetection { get; init; }

    /// <summary>Voice Focus mode. Use <c>near-field</c> for close microphones or <c>far-field</c> for distant microphones.</summary>
    public StreamingVoiceFocus? VoiceFocus { get; init; }

    /// <summary>Voice Focus suppression strength from 0.0 to 1.0. Requires <see cref="VoiceFocus"/>.</summary>
    public double? VoiceFocusThreshold { get; init; }

    /// <summary>Whether to enable streaming speaker diarization.</summary>
    public bool? SpeakerLabels { get; init; }

    /// <summary>Maximum expected speakers for streaming diarization. Valid range is 1-10.</summary>
    public int? MaxSpeakers { get; init; }

    /// <summary>Maximum number of prior conversation entries carried forward as context. Set 0 to disable automatic carryover.</summary>
    public int? PreviousContextNTurns { get; init; }

    /// <summary>Minimum silence duration in ms before a speculative end-of-turn check.</summary>
    public int? MinTurnSilence { get; init; }

    /// <summary>Maximum silence duration in ms before the turn is forced to end.</summary>
    public int? MaxTurnSilence { get; init; }

    /// <summary>Confidence threshold from 0.0 to 1.0 for classifying audio frames as speech.</summary>
    public double? VadThreshold { get; init; }

    /// <summary>Whether to emit additional partial transcripts during long turns.</summary>
    public bool? ContinuousPartials { get; init; }

    /// <summary>Whether to emit partial turn messages while speech is still in progress.</summary>
    public bool? IncludePartialTurns { get; init; }

    /// <summary>How soon the first partial is emitted, in milliseconds.</summary>
    public int? InterruptionDelay { get; init; }

    /// <summary>Optional inactivity timeout in seconds.</summary>
    public int? InactivityTimeout { get; init; }

    /// <summary>
    /// Temporary token (from the streaming token endpoint). When set, appended to the connection
    /// URI as <c>?token=…</c>. Use this for browser/edge scenarios. For server-side auth, prefer
    /// the <c>ConnectAsync(client, apiKey, options, …)</c> overload, which sets the
    /// <c>Authorization</c> header instead.
    /// </summary>
    public string? Token { get; init; }

    /// <summary>Region selector. <c>"us"</c> → <c>streaming.assemblyai.com</c>; <c>"eu"</c> → <c>streaming.eu.assemblyai.com</c>.</summary>
    public string Region { get; init; } = "us";

    /// <summary>
    /// Builds the connection URI from the configured options.
    /// </summary>
    public Uri BuildUri()
    {
        var host = string.Equals(Region, "eu", StringComparison.OrdinalIgnoreCase)
            ? "streaming.eu.assemblyai.com"
            : "streaming.assemblyai.com";

        var query = new StringBuilder();
        Append(query, "sample_rate", SampleRate.ToString(CultureInfo.InvariantCulture));
        Append(query, "speech_model", SpeechModel.ToString());
        Append(query, "encoding", Encoding);
        Append(query, "format_turns", FormatTurns);
        Append(query, "prompt", Prompt);
        Append(query, "agent_context", AgentContext);
        Append(query, "mode", Mode?.ToString());
        Append(query, "language_code", LanguageCode?.ToString());
        Append(query, "language_detection", LanguageDetection);
        Append(query, "voice_focus", VoiceFocus?.ToString());
        Append(query, "voice_focus_threshold", VoiceFocusThreshold);
        Append(query, "speaker_labels", SpeakerLabels);
        Append(query, "max_speakers", MaxSpeakers);
        Append(query, "previous_context_n_turns", PreviousContextNTurns);
        Append(query, "min_turn_silence", MinTurnSilence);
        Append(query, "max_turn_silence", MaxTurnSilence);
        Append(query, "vad_threshold", VadThreshold);
        Append(query, "continuous_partials", ContinuousPartials);
        Append(query, "include_partial_turns", IncludePartialTurns);
        Append(query, "interruption_delay", InterruptionDelay);
        Append(query, "inactivity_timeout", InactivityTimeout);

        if (KeytermsPrompt is { Count: > 0 })
        {
            var nonEmpty = new List<string>(KeytermsPrompt.Count);
            foreach (var term in KeytermsPrompt)
            {
                if (!string.IsNullOrEmpty(term))
                {
                    nonEmpty.Add(term);
                }
            }
            if (nonEmpty.Count > 0)
            {
                Append(query, "keyterms_prompt", SerializeStringArray(nonEmpty));
            }
        }

        Append(query, "token", Token);

        return new Uri($"wss://{host}/v3/ws?{query}");
    }

    private static void Append(StringBuilder query, string name, string? value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return;
        }

        if (query.Length > 0)
        {
            query.Append('&');
        }

        query.Append(name).Append('=').Append(Uri.EscapeDataString(value));
    }

    private static void Append(StringBuilder query, string name, int? value)
    {
        if (value is { } intValue)
        {
            Append(query, name, intValue.ToString(CultureInfo.InvariantCulture));
        }
    }

    private static void Append(StringBuilder query, string name, double? value)
    {
        if (value is { } doubleValue)
        {
            Append(query, name, doubleValue.ToString(CultureInfo.InvariantCulture));
        }
    }

    private static void Append(StringBuilder query, string name, bool? value)
    {
        if (value is { } boolValue)
        {
            Append(query, name, boolValue ? "true" : "false");
        }
    }

    private static string SerializeStringArray(List<string> values)
    {
        var json = new StringBuilder();
        json.Append('[');

        for (var i = 0; i < values.Count; i++)
        {
            if (i > 0)
            {
                json.Append(',');
            }

            json.Append('"');
            AppendEscapedJsonString(json, values[i]);
            json.Append('"');
        }

        json.Append(']');
        return json.ToString();
    }

    private static void AppendEscapedJsonString(StringBuilder json, string value)
    {
        foreach (var character in value)
        {
            switch (character)
            {
                case '"':
                    json.Append("\\\"");
                    break;
                case '\\':
                    json.Append("\\\\");
                    break;
                case '\b':
                    json.Append("\\b");
                    break;
                case '\f':
                    json.Append("\\f");
                    break;
                case '\n':
                    json.Append("\\n");
                    break;
                case '\r':
                    json.Append("\\r");
                    break;
                case '\t':
                    json.Append("\\t");
                    break;
                default:
                    if (char.IsControl(character))
                    {
                        json.Append("\\u");
                        json.Append(((int)character).ToString("x4", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        json.Append(character);
                    }
                    break;
            }
        }
    }
}

/// <summary>
/// Extension methods for connecting <see cref="AssemblyAIRealtimeClient"/> with typed options.
/// </summary>
public static class AssemblyAIRealtimeClientStreamingExtensions
{
    /// <summary>
    /// Connects using the supplied <see cref="StreamingConnectOptions"/>. The caller is responsible
    /// for auth — either set <see cref="StreamingConnectOptions.Token"/> (browser scenario) or pass
    /// an <c>Authorization</c> header via <paramref name="additionalHeaders"/>.
    /// </summary>
    public static Task ConnectAsync(
        this AssemblyAIRealtimeClient client,
        StreamingConnectOptions options,
        IDictionary<string, string>? additionalHeaders = null,
        TimeSpan? keepAliveInterval = null,
        TimeSpan? connectTimeout = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(options);

        return client.ConnectAsync(
            uri: options.BuildUri(),
            additionalHeaders: additionalHeaders,
            additionalSubProtocols: null,
            keepAliveInterval: keepAliveInterval,
            connectTimeout: connectTimeout,
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Connects to AssemblyAI's v3 streaming endpoint using API-key auth via the
    /// <c>Authorization</c> header. This is the recommended overload for server-side use.
    /// </summary>
    public static Task ConnectAsync(
        this AssemblyAIRealtimeClient client,
        string apiKey,
        StreamingConnectOptions? options = null,
        TimeSpan? keepAliveInterval = null,
        TimeSpan? connectTimeout = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        if (string.IsNullOrEmpty(apiKey))
        {
            throw new ArgumentException("API key must be provided.", nameof(apiKey));
        }

        var headers = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["Authorization"] = apiKey,
        };

        return ConnectAsync(
            client,
            options ?? new StreamingConnectOptions(),
            additionalHeaders: headers,
            keepAliveInterval: keepAliveInterval,
            connectTimeout: connectTimeout,
            cancellationToken: cancellationToken);
    }
}
