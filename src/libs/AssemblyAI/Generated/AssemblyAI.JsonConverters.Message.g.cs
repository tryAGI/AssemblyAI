#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AssemblyAI.JsonConverters
{
    /// <inheritdoc />
    public class MessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.Message>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.Message Read(
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

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("content")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            if (__jsonProps.Contains("tool_call_id")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::AssemblyAI.MessageVariant1? messageVariant1 = default;
            global::AssemblyAI.MessageVariant2? messageVariant2 = default;
            global::AssemblyAI.MessageVariant3? messageVariant3 = default;
            global::AssemblyAI.MessageVariant4? tool = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant1).Name}");
                        messageVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant2).Name}");
                        messageVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant3).Name}");
                        messageVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant4).Name}");
                        tool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messageVariant1 == null && messageVariant2 == null && messageVariant3 == null && tool == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant1).Name}");
                    messageVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant2).Name}");
                    messageVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant3).Name}");
                    messageVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant4).Name}");
                    tool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::AssemblyAI.Message(
                messageVariant1,

                messageVariant2,

                messageVariant3,

                tool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.Message value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageVariant1!, typeInfo);
            }
            else if (value.IsMessageVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageVariant2!, typeInfo);
            }
            else if (value.IsMessageVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageVariant3!, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.MessageVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.MessageVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.MessageVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool!, typeInfo);
            }
        }
    }
}