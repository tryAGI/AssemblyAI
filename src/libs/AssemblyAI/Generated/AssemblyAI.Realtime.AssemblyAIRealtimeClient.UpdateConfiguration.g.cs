
#nullable enable

namespace AssemblyAI.Realtime
{
    public sealed partial class AssemblyAIRealtimeClient
    {
        /// <summary>
        /// Update streaming configuration parameters during an active session.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendUpdateConfigurationAsync(
            global::AssemblyAI.Realtime.UpdateConfigurationPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::AssemblyAI.Realtime.UpdateConfigurationPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}