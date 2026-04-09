#nullable enable

namespace AssemblyAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseFormatTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.ResponseFormatType>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.ResponseFormatType Read(
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
                        return global::AssemblyAI.ResponseFormatTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AssemblyAI.ResponseFormatType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AssemblyAI.ResponseFormatType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.ResponseFormatType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AssemblyAI.ResponseFormatTypeExtensions.ToValueString(value));
        }
    }
}
