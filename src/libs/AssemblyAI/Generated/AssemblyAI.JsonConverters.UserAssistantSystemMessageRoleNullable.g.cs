#nullable enable

namespace AssemblyAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class UserAssistantSystemMessageRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AssemblyAI.UserAssistantSystemMessageRole?>
    {
        /// <inheritdoc />
        public override global::AssemblyAI.UserAssistantSystemMessageRole? Read(
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
                        return global::AssemblyAI.UserAssistantSystemMessageRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AssemblyAI.UserAssistantSystemMessageRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AssemblyAI.UserAssistantSystemMessageRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AssemblyAI.UserAssistantSystemMessageRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AssemblyAI.UserAssistantSystemMessageRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
