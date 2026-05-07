#nullable enable

namespace AssemblyAI.Realtime;

public readonly partial struct ServerEvent
{
    /// <summary>
    /// Gets the session-begins payload when this server event represents session start.
    /// </summary>
    public SessionBeginsPayload? SessionBegins => Begin;

    /// <summary>
    /// Gets a value indicating whether this server event represents session start.
    /// </summary>
    public bool IsSessionBegins => IsBegin;
}
