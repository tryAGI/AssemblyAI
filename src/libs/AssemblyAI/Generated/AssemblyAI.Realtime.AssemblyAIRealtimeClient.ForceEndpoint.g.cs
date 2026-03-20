
#nullable enable

namespace AssemblyAI.Realtime
{
    public sealed partial class AssemblyAIRealtimeClient
    {
        /// <summary>
        /// Manually force an endpoint in the transcription.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendForceEndpointAsync(
            global::AssemblyAI.Realtime.ForceEndpointPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::AssemblyAI.Realtime.ForceEndpointPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}