#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AssemblyAI.JsonConverters
{
    /// <inheritdoc />
    public class TranscriptSpeechUnderstandingRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.TranscriptSpeechUnderstandingRequest>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.TranscriptSpeechUnderstandingRequest Read(
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
            if (__jsonProps.Contains("translation")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("speaker_identification")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("custom_formatting")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::AssemblyAI.TranslationRequestBody? translationRequestBody = default;
            global::AssemblyAI.SpeakerIdentificationRequestBody? speakerIdentificationRequestBody = default;
            global::AssemblyAI.CustomFormattingRequestBody? customFormattingRequestBody = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.TranslationRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.TranslationRequestBody> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.TranslationRequestBody).Name}");
                        translationRequestBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.SpeakerIdentificationRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.SpeakerIdentificationRequestBody> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.SpeakerIdentificationRequestBody).Name}");
                        speakerIdentificationRequestBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.CustomFormattingRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.CustomFormattingRequestBody> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.CustomFormattingRequestBody).Name}");
                        customFormattingRequestBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (translationRequestBody == null && speakerIdentificationRequestBody == null && customFormattingRequestBody == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.TranslationRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.TranslationRequestBody> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.TranslationRequestBody).Name}");
                    translationRequestBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.SpeakerIdentificationRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.SpeakerIdentificationRequestBody> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.SpeakerIdentificationRequestBody).Name}");
                    speakerIdentificationRequestBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.CustomFormattingRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.CustomFormattingRequestBody> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.CustomFormattingRequestBody).Name}");
                    customFormattingRequestBody = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::AssemblyAI.TranscriptSpeechUnderstandingRequest(
                translationRequestBody,

                speakerIdentificationRequestBody,

                customFormattingRequestBody
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.TranscriptSpeechUnderstandingRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranslationRequestBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.TranslationRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.TranslationRequestBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.TranslationRequestBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranslationRequestBody!, typeInfo);
            }
            else if (value.IsSpeakerIdentificationRequestBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.SpeakerIdentificationRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.SpeakerIdentificationRequestBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.SpeakerIdentificationRequestBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeakerIdentificationRequestBody!, typeInfo);
            }
            else if (value.IsCustomFormattingRequestBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.CustomFormattingRequestBody), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.CustomFormattingRequestBody?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.CustomFormattingRequestBody).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomFormattingRequestBody!, typeInfo);
            }
        }
    }
}