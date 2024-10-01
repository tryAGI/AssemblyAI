
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// AssemblyAI API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class AssemblyAIClient : global::AssemblyAI.IAssemblyAIClient, global::System.IDisposable
    {
        /// <summary>
        /// AssemblyAI API
        /// </summary>
        public const string BaseUrl = "https://api.assemblyai.com";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::AssemblyAI.EndPointAuthorization? _authorization;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::AssemblyAI.SourceGenerationContext.Default;


        /// <summary>
        /// Transcript related operations
        /// </summary>
        public TranscriptClient Transcript => new TranscriptClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// LeMUR related operations
        /// </summary>
        public LeMURClient LeMUR => new LeMURClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Streaming Speech-to-Text
        /// </summary>
        public StreamingClient Streaming => new StreamingClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the AssemblyAIClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorization"></param>
        public AssemblyAIClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::AssemblyAI.EndPointAuthorization? authorization = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorization = authorization;

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}