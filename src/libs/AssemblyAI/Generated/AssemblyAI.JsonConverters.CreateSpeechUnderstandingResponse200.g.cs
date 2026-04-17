#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AssemblyAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateSpeechUnderstandingResponse200JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.CreateSpeechUnderstandingResponse200>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.CreateSpeechUnderstandingResponse200 Read(
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
            if (__jsonProps.Contains("speech_understanding")) __score0++;
            if (__jsonProps.Contains("speech_understanding.request")) __score0++;
            if (__jsonProps.Contains("speech_understanding.response")) __score0++;
            if (__jsonProps.Contains("translated_texts")) __score0++;
            if (__jsonProps.Contains("utterances")) __score0++;
            if (__jsonProps.Contains("words")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("speech_understanding")) __score1++;
            if (__jsonProps.Contains("speech_understanding.request")) __score1++;
            if (__jsonProps.Contains("speech_understanding.response")) __score1++;
            if (__jsonProps.Contains("utterances")) __score1++;
            if (__jsonProps.Contains("words")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("speech_understanding")) __score2++;
            if (__jsonProps.Contains("speech_understanding.request")) __score2++;
            if (__jsonProps.Contains("speech_understanding.response")) __score2++;
            if (__jsonProps.Contains("utterances")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::AssemblyAI.LLMGatewayTranslationResponse? lLMGatewayTranslationResponse = default;
            global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse? lLMGatewaySpeakerIdentificationResponse = default;
            global::AssemblyAI.LLMGatewayCustomFormattingResponse? lLMGatewayCustomFormattingResponse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LLMGatewayTranslationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LLMGatewayTranslationResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LLMGatewayTranslationResponse).Name}");
                        lLMGatewayTranslationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse).Name}");
                        lLMGatewaySpeakerIdentificationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LLMGatewayCustomFormattingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LLMGatewayCustomFormattingResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LLMGatewayCustomFormattingResponse).Name}");
                        lLMGatewayCustomFormattingResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (lLMGatewayTranslationResponse == null && lLMGatewaySpeakerIdentificationResponse == null && lLMGatewayCustomFormattingResponse == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LLMGatewayTranslationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LLMGatewayTranslationResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LLMGatewayTranslationResponse).Name}");
                    lLMGatewayTranslationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse).Name}");
                    lLMGatewaySpeakerIdentificationResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LLMGatewayCustomFormattingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LLMGatewayCustomFormattingResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LLMGatewayCustomFormattingResponse).Name}");
                    lLMGatewayCustomFormattingResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::AssemblyAI.CreateSpeechUnderstandingResponse200(
                lLMGatewayTranslationResponse,

                lLMGatewaySpeakerIdentificationResponse,

                lLMGatewayCustomFormattingResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.CreateSpeechUnderstandingResponse200 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLLMGatewayTranslationResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LLMGatewayTranslationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LLMGatewayTranslationResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LLMGatewayTranslationResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMGatewayTranslationResponse!, typeInfo);
            }
            else if (value.IsLLMGatewaySpeakerIdentificationResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LLMGatewaySpeakerIdentificationResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMGatewaySpeakerIdentificationResponse!, typeInfo);
            }
            else if (value.IsLLMGatewayCustomFormattingResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AssemblyAI.LLMGatewayCustomFormattingResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AssemblyAI.LLMGatewayCustomFormattingResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AssemblyAI.LLMGatewayCustomFormattingResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LLMGatewayCustomFormattingResponse!, typeInfo);
            }
        }
    }
}