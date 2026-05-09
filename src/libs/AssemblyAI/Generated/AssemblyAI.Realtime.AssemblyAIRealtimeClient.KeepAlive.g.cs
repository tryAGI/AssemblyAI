
#nullable enable

namespace AssemblyAI.Realtime
{
    public sealed partial class AssemblyAIRealtimeClient
    {
        /// <summary>
        /// Send a keep-alive ping to reset inactivity_timeout.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendKeepAliveAsync(
            global::AssemblyAI.Realtime.KeepAlivePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::AssemblyAI.Realtime.KeepAlivePayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}