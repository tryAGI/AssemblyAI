#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class LemurSummaryParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.LemurSummaryParams>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.LemurSummaryParams Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::AssemblyAI.LemurBaseParams? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LemurBaseParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LemurBaseParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LemurBaseParams).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::AssemblyAI.LemurSummaryParamsVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LemurSummaryParamsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LemurSummaryParamsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LemurSummaryParamsVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::AssemblyAI.LemurSummaryParams(
                value1,
                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LemurBaseParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LemurBaseParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LemurBaseParams).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LemurSummaryParamsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LemurSummaryParamsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LemurSummaryParamsVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.LemurSummaryParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LemurBaseParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LemurBaseParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LemurBaseParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LemurSummaryParamsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LemurSummaryParamsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LemurSummaryParamsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}