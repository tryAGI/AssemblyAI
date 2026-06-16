#nullable enable

namespace AssemblyAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod?>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethodExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AssemblyAI.TranscriptRedactPiiAudioOptionsOverrideAudioRedactionMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
