
#nullable enable

namespace AssemblyAI
{
    public sealed partial class AssemblyAIClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::AssemblyAI.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "Authorization",
                Value = apiKey,
            });
        }
    }
}