namespace AssemblyAI;

internal static class AuthorizationExtensions
{
    public static string GetAuthorizationValue(this IEnumerable<EndPointAuthorization> authorizations)
    {
        ArgumentNullException.ThrowIfNull(authorizations);

        return authorizations.FirstOrDefault(static authorization =>
                string.Equals(authorization.Name, "Authorization", StringComparison.OrdinalIgnoreCase))
                ?.Value
            ?? throw new InvalidOperationException("AssemblyAI client is missing the Authorization API key.");
    }
}
