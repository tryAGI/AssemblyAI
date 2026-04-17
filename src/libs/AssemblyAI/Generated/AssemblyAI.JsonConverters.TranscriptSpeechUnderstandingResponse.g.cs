#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AssemblyAI.JsonConverters
{
    /// <inheritdoc />
    public class TranscriptSpeechUnderstandingResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.TranscriptSpeechUnderstandingResponse>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.TranscriptSpeechUnderstandingResponse Read(
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
            if (__jsonProps.Contains("translation")) __score0++;
            if (__jsonProps.Contains("translation.status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("speaker_identification")) __score1++;
            if (__jsonProps.Contains("speaker_identification.mapping")) __score1++;
            if (__jsonProps.Contains("speaker_identification.status")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("custom_formatting")) __score2++;
            if (__jsonProps.Contains("custom_formatting.formatted_text")) __score2++;
            if (__jsonProps.Contains("custom_formatting.mapping")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::AssemblyAI.TranslationResponse? translationResponse = default;
            global::AssemblyAI.SpeakerIdentificationResponse? speakerIdentificationResponse = default;
            global::AssemblyAI.CustomFormattingResponse? customFormattingResponse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.TranslationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.TranslationResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.TranslationResponse).Name}");
                        translationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.SpeakerIdentificationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.SpeakerIdentificationResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.SpeakerIdentificationResponse).Name}");
                        speakerIdentificationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.CustomFormattingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.CustomFormattingResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.CustomFormattingResponse).Name}");
                        customFormattingResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (translationResponse == null && speakerIdentificationResponse == null && customFormattingResponse == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.TranslationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.TranslationResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.TranslationResponse).Name}");
                    translationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.SpeakerIdentificationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.SpeakerIdentificationResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.SpeakerIdentificationResponse).Name}");
                    speakerIdentificationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.CustomFormattingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.CustomFormattingResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.CustomFormattingResponse).Name}");
                    customFormattingResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::AssemblyAI.TranscriptSpeechUnderstandingResponse(
                translationResponse,

                speakerIdentificationResponse,

                customFormattingResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.TranscriptSpeechUnderstandingResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranslationResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.TranslationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.TranslationResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.TranslationResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranslationResponse!, typeInfo);
            }
            else if (value.IsSpeakerIdentificationResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.SpeakerIdentificationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.SpeakerIdentificationResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.SpeakerIdentificationResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakerIdentificationResponse!, typeInfo);
            }
            else if (value.IsCustomFormattingResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.CustomFormattingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.CustomFormattingResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.CustomFormattingResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomFormattingResponse!, typeInfo);
            }
        }
    }
}