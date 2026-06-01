#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AssemblyAI.JsonConverters
{
    /// <inheritdoc />
    public class NewPlantJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.NewPlant>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.NewPlant Read(
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
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("tag")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::AssemblyAI.Plant? plant = default;
            global::AssemblyAI.NewPlantVariant2? newPlantVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.Plant), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.Plant> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.Plant).Name}");
                        plant = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.NewPlantVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.NewPlantVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.NewPlantVariant2).Name}");
                        newPlantVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (plant == null && newPlantVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.Plant), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.Plant> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.Plant).Name}");
                    plant = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (plant == null && newPlantVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.NewPlantVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.NewPlantVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.NewPlantVariant2).Name}");
                    newPlantVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::AssemblyAI.NewPlant(
                plant,

                newPlantVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.NewPlant value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPlant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.Plant), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.Plant?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.Plant).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Plant!, typeInfo);
            }
            else if (value.IsNewPlantVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.NewPlantVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.NewPlantVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.NewPlantVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NewPlantVariant2!, typeInfo);
            }
        }
    }
}