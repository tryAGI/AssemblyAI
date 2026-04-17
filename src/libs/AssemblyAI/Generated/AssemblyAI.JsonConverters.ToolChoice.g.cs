#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AssemblyAI.JsonConverters
{
    /// <inheritdoc />
    public class ToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.ToolChoice>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.ToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            var __score1 = 0;
            if (__jsonProps.Contains("function")) __score1++;
            if (__jsonProps.Contains("function.name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::AssemblyAI.ToolChoice0? toolChoice0 = default;
            global::AssemblyAI.ToolChoice1? toolChoice1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.ToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.ToolChoice0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.ToolChoice0).Name}");
                        toolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.ToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.ToolChoice1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.ToolChoice1).Name}");
                        toolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (toolChoice0 == null && toolChoice1 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.ToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.ToolChoice0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.ToolChoice0).Name}");
                    toolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.ToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.ToolChoice1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.ToolChoice1).Name}");
                    toolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::AssemblyAI.ToolChoice(
                toolChoice0,

                toolChoice1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.ToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsToolChoice0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.ToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.ToolChoice0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.ToolChoice0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolChoice0!.Value, typeInfo);
            }
            else if (value.IsToolChoice1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.ToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.ToolChoice1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.ToolChoice1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolChoice1!, typeInfo);
            }
        }
    }
}