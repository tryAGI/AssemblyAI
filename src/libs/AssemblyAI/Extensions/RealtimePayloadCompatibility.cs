using System.Diagnostics.CodeAnalysis;

namespace AssemblyAI.Realtime;

public sealed partial class SessionBeginsPayload
{
    /// <summary>Creates a session-begins payload without server configuration metadata.</summary>
    [SetsRequiredMembers]
    public SessionBeginsPayload(string id, DateTimeOffset expiresAt, SessionBeginsPayloadType type)
        : this(id, expiresAt, type, configuration: null)
    {
    }
}

public sealed partial class UpdateConfigurationPayload
{
    /// <summary>Creates a configuration update while preserving the session's language steering.</summary>
    [SetsRequiredMembers]
    public UpdateConfigurationPayload(
        UpdateConfigurationPayloadType type,
        double? endOfTurnConfidenceThreshold,
        int? minTurnSilence,
        int? maxTurnSilence,
        int? interruptionDelay,
        double? vadThreshold,
        UpdateConfigurationPayloadMode? mode,
        string? prompt,
        string? agentContext,
        IList<string>? keytermsPrompt,
        bool? continuousPartials)
        : this(type, endOfTurnConfidenceThreshold, minTurnSilence, maxTurnSilence,
            interruptionDelay, vadThreshold, mode, prompt, agentContext, keytermsPrompt,
            languageCodes: null, continuousPartials)
    {
    }
}
