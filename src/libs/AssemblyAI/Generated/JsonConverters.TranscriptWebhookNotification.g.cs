#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class TranscriptWebhookNotificationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.TranscriptWebhookNotification>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.TranscriptWebhookNotification Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::AssemblyAI.TranscriptReadyNotification? ready = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.TranscriptReadyNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.TranscriptReadyNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.TranscriptReadyNotification).Name}");
                ready = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::AssemblyAI.RedactedAudioNotification? redactedAudio = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.RedactedAudioNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.RedactedAudioNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.RedactedAudioNotification).Name}");
                redactedAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::AssemblyAI.TranscriptWebhookNotification(
                ready,
                redactedAudio
                );

            if (ready != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.TranscriptReadyNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.TranscriptReadyNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.TranscriptReadyNotification).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (redactedAudio != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.RedactedAudioNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.RedactedAudioNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.RedactedAudioNotification).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.TranscriptWebhookNotification value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.TranscriptReadyNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.TranscriptReadyNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.TranscriptReadyNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ready, typeInfo);
            }
            else if (value.IsRedactedAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.RedactedAudioNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.RedactedAudioNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.RedactedAudioNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedAudio, typeInfo);
            }
        }
    }
}