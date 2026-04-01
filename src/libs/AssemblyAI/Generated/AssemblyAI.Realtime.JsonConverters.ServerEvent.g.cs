#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AssemblyAI.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.Realtime.ServerEvent>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.Realtime.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.Realtime.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.Realtime.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AssemblyAI.Realtime.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AssemblyAI.Realtime.SessionBeginsPayload? begin = default;
            if (discriminator?.Type == global::AssemblyAI.Realtime.ServerEventDiscriminatorType.Begin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.Realtime.SessionBeginsPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.Realtime.SessionBeginsPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AssemblyAI.Realtime.SessionBeginsPayload)}");
                begin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AssemblyAI.Realtime.TurnPayload? turn = default;
            if (discriminator?.Type == global::AssemblyAI.Realtime.ServerEventDiscriminatorType.Turn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.Realtime.TurnPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.Realtime.TurnPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AssemblyAI.Realtime.TurnPayload)}");
                turn = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AssemblyAI.Realtime.TerminationPayload? termination = default;
            if (discriminator?.Type == global::AssemblyAI.Realtime.ServerEventDiscriminatorType.Termination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.Realtime.TerminationPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.Realtime.TerminationPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AssemblyAI.Realtime.TerminationPayload)}");
                termination = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AssemblyAI.Realtime.ServerEvent(
                discriminator?.Type,
                begin,

                turn,

                termination
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.Realtime.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBegin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.Realtime.SessionBeginsPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.Realtime.SessionBeginsPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.Realtime.SessionBeginsPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Begin!, typeInfo);
            }
            else if (value.IsTurn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.Realtime.TurnPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.Realtime.TurnPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.Realtime.TurnPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Turn!, typeInfo);
            }
            else if (value.IsTermination)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.Realtime.TerminationPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.Realtime.TerminationPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.Realtime.TerminationPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Termination!, typeInfo);
            }
        }
    }
}