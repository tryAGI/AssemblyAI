#nullable enable

namespace AssemblyAI.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ErrorPayloadTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.Realtime.ErrorPayloadType?>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.Realtime.ErrorPayloadType? Read(
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
                        return global::AssemblyAI.Realtime.ErrorPayloadTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AssemblyAI.Realtime.ErrorPayloadType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AssemblyAI.Realtime.ErrorPayloadType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.Realtime.ErrorPayloadType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AssemblyAI.Realtime.ErrorPayloadTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
