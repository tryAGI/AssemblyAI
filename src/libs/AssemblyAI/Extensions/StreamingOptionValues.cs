#nullable enable

namespace AssemblyAI.Realtime;

/// <summary>
/// Speech model value for AssemblyAI's streaming WebSocket API.
/// </summary>
public readonly record struct StreamingSpeechModel(string Value)
{
    /// <summary>Universal-3.5 Pro Realtime model.</summary>
    public static StreamingSpeechModel Universal35ProRealtime { get; } = new("u3-rt-pro");

    /// <summary>Universal Streaming English model.</summary>
    public static StreamingSpeechModel UniversalStreamingEnglish { get; } = new("universal-streaming-english");

    /// <summary>Universal Streaming Multilingual model.</summary>
    public static StreamingSpeechModel UniversalStreamingMultilingual { get; } = new("universal-streaming-multilingual");

    /// <summary>Creates a speech model value from a raw API string.</summary>
    public static StreamingSpeechModel FromString(string value) => new(value);

    /// <summary>Converts a speech model value to its raw API string.</summary>
    public static implicit operator string(StreamingSpeechModel value) => value.Value;

    /// <summary>Converts a raw API string to a speech model value.</summary>
    public static implicit operator StreamingSpeechModel(string value) => FromString(value);

    /// <summary>Returns the raw API string.</summary>
    public override string ToString() => Value;
}

/// <summary>
/// Latency and accuracy preset for Universal-3 Pro realtime streaming.
/// </summary>
public readonly record struct StreamingMode(string Value)
{
    /// <summary>Prioritizes transcription accuracy.</summary>
    public static StreamingMode MaxAccuracy { get; } = new("max_accuracy");

    /// <summary>Prioritizes lower latency.</summary>
    public static StreamingMode MinLatency { get; } = new("min_latency");

    /// <summary>Balances latency and accuracy.</summary>
    public static StreamingMode Balanced { get; } = new("balanced");

    /// <summary>Creates a mode value from a raw API string.</summary>
    public static StreamingMode FromString(string value) => new(value);

    /// <summary>Converts a mode value to its raw API string.</summary>
    public static implicit operator string(StreamingMode value) => value.Value;

    /// <summary>Converts a raw API string to a mode value.</summary>
    public static implicit operator StreamingMode(string value) => FromString(value);

    /// <summary>Returns the raw API string.</summary>
    public override string ToString() => Value;
}

/// <summary>
/// Voice Focus capture mode for streaming transcription.
/// </summary>
public readonly record struct StreamingVoiceFocus(string Value)
{
    /// <summary>Close-talking microphones such as headsets, handsets, and phones.</summary>
    public static StreamingVoiceFocus NearField { get; } = new("near-field");

    /// <summary>Distant microphones such as conference rooms, laptop mics, and speakerphones.</summary>
    public static StreamingVoiceFocus FarField { get; } = new("far-field");

    /// <summary>Creates a Voice Focus value from a raw API string.</summary>
    public static StreamingVoiceFocus FromString(string value) => new(value);

    /// <summary>Converts a Voice Focus value to its raw API string.</summary>
    public static implicit operator string(StreamingVoiceFocus value) => value.Value;

    /// <summary>Converts a raw API string to a Voice Focus value.</summary>
    public static implicit operator StreamingVoiceFocus(string value) => FromString(value);

    /// <summary>Returns the raw API string.</summary>
    public override string ToString() => Value;
}

/// <summary>
/// Language-code steering value for Universal-3 Pro realtime streaming.
/// </summary>
public readonly record struct StreamingLanguageCode(string Value)
{
    /// <summary>English.</summary>
    public static StreamingLanguageCode English { get; } = new("en");

    /// <summary>Spanish.</summary>
    public static StreamingLanguageCode Spanish { get; } = new("es");

    /// <summary>French.</summary>
    public static StreamingLanguageCode French { get; } = new("fr");

    /// <summary>German.</summary>
    public static StreamingLanguageCode German { get; } = new("de");

    /// <summary>Italian.</summary>
    public static StreamingLanguageCode Italian { get; } = new("it");

    /// <summary>Portuguese.</summary>
    public static StreamingLanguageCode Portuguese { get; } = new("pt");

    /// <summary>Turkish.</summary>
    public static StreamingLanguageCode Turkish { get; } = new("tr");

    /// <summary>Dutch.</summary>
    public static StreamingLanguageCode Dutch { get; } = new("nl");

    /// <summary>Swedish.</summary>
    public static StreamingLanguageCode Swedish { get; } = new("sv");

    /// <summary>Norwegian.</summary>
    public static StreamingLanguageCode Norwegian { get; } = new("no");

    /// <summary>Danish.</summary>
    public static StreamingLanguageCode Danish { get; } = new("da");

    /// <summary>Finnish.</summary>
    public static StreamingLanguageCode Finnish { get; } = new("fi");

    /// <summary>Hindi.</summary>
    public static StreamingLanguageCode Hindi { get; } = new("hi");

    /// <summary>Vietnamese.</summary>
    public static StreamingLanguageCode Vietnamese { get; } = new("vi");

    /// <summary>Arabic.</summary>
    public static StreamingLanguageCode Arabic { get; } = new("ar");

    /// <summary>Hebrew.</summary>
    public static StreamingLanguageCode Hebrew { get; } = new("he");

    /// <summary>Japanese.</summary>
    public static StreamingLanguageCode Japanese { get; } = new("ja");

    /// <summary>Urdu.</summary>
    public static StreamingLanguageCode Urdu { get; } = new("ur");

    /// <summary>Mandarin Chinese.</summary>
    public static StreamingLanguageCode Chinese { get; } = new("zh");

    /// <summary>Creates a language-code value from a raw API string.</summary>
    public static StreamingLanguageCode FromString(string value) => new(value);

    /// <summary>Converts a language-code value to its raw API string.</summary>
    public static implicit operator string(StreamingLanguageCode value) => value.Value;

    /// <summary>Converts a raw API string to a language-code value.</summary>
    public static implicit operator StreamingLanguageCode(string value) => FromString(value);

    /// <summary>Returns the raw API string.</summary>
    public override string ToString() => Value;
}
