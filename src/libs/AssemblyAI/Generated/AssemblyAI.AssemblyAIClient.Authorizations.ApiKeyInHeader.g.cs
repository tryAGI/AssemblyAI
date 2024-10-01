
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

            _authorization = new global::AssemblyAI.EndPointAuthorization
            {
                Name = "Authorization",
                Value = apiKey,
            };
        }
    }
}