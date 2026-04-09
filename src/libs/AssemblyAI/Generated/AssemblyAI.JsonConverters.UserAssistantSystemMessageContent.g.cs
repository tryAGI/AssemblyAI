#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AssemblyAI.JsonConverters
{
    /// <inheritdoc />
    public class UserAssistantSystemMessageContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.UserAssistantSystemMessageContent>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.UserAssistantSystemMessageContent Read(
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
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(string), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            string? userAssistantSystemMessageContentVariant1 = default;
            global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>? userAssistantSystemMessageContent1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        userAssistantSystemMessageContentVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>).Name}");
                        userAssistantSystemMessageContent1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (userAssistantSystemMessageContentVariant1 == null && userAssistantSystemMessageContent1 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    userAssistantSystemMessageContentVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>).Name}");
                    userAssistantSystemMessageContent1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::AssemblyAI.UserAssistantSystemMessageContent(
                userAssistantSystemMessageContentVariant1,

                userAssistantSystemMessageContent1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.UserAssistantSystemMessageContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUserAssistantSystemMessageContentVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserAssistantSystemMessageContentVariant1!, typeInfo);
            }
            else if (value.IsUserAssistantSystemMessageContent1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::AssemblyAI.ContentPart>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserAssistantSystemMessageContent1!, typeInfo);
            }
        }
    }
}