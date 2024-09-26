
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// AssemblyAI API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IAssemblyAIClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Transcript related operations
        /// </summary>
        public TranscriptClient Transcript { get; }

        /// <summary>
        /// LeMUR related operations
        /// </summary>
        public LeMURClient LeMUR { get; }

        /// <summary>
        /// Streaming Speech-to-Text
        /// </summary>
        public StreamingClient Streaming { get; }

    }
}