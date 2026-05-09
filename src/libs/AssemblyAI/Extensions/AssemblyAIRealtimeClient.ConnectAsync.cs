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

    /// <summary>Audio encoding. v3 supports <c>pcm_s16le</c> (default) and <c>pcm_mulaw</c>.</summary>
    public string Encoding { get; init; } = "pcm_s16le";

    /// <summary>Whether the server should produce formatted (punctuated, capitalized) turn output.</summary>
    public bool FormatTurns { get; init; }

    /// <summary>Optional list of keyterms to bias transcription. Sent as a single <c>keyterms_prompt</c> query parameter containing a JSON-encoded array (the format AssemblyAI's v3 streaming API expects).</summary>
    public IReadOnlyList<string>? KeytermsPrompt { get; init; }

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
        query.Append("sample_rate=").Append(SampleRate.ToString(CultureInfo.InvariantCulture));
        query.Append("&encoding=").Append(Uri.EscapeDataString(Encoding));
        query.Append("&format_turns=").Append(FormatTurns ? "true" : "false");

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
                var jsonArray = "[" + string.Join(",", nonEmpty.ConvertAll(t => "\"" + t.Replace("\\", "\\\\", StringComparison.Ordinal).Replace("\"", "\\\"", StringComparison.Ordinal) + "\"")) + "]";
                query.Append("&keyterms_prompt=").Append(Uri.EscapeDataString(jsonArray));
            }
        }

        if (!string.IsNullOrEmpty(Token))
        {
            query.Append("&token=").Append(Uri.EscapeDataString(Token));
        }

        return new Uri($"wss://{host}/v3/ws?{query}");
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
