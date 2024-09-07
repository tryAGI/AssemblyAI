#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class RedactedAudioNotificationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.RedactedAudioNotification>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.RedactedAudioNotification Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::AssemblyAI.RedactedAudioResponse? response = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.RedactedAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.RedactedAudioResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.RedactedAudioResponse).Name}");
                response = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::AssemblyAI.RedactedAudioNotification(
                response
                );

            if (response != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.RedactedAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.RedactedAudioResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.RedactedAudioResponse).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.RedactedAudioNotification value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.RedactedAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.RedactedAudioResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.RedactedAudioResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Response, typeInfo);
            }
        }
    }
}