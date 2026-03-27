
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AssemblyAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::AssemblyAI.Realtime.JsonConverters.UpdateConfigurationPayloadTypeJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.UpdateConfigurationPayloadTypeNullableJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.ForceEndpointPayloadTypeJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.ForceEndpointPayloadTypeNullableJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.SessionTerminationPayloadTypeJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.SessionTerminationPayloadTypeNullableJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.SessionBeginsPayloadTypeJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.SessionBeginsPayloadTypeNullableJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.TurnPayloadTypeJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.TurnPayloadTypeNullableJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.TerminationPayloadTypeJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.TerminationPayloadTypeNullableJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::AssemblyAI.Realtime.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.UpdateConfigurationPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.UpdateConfigurationPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.ForceEndpointPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.ForceEndpointPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.SessionTerminationPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.SessionTerminationPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.SessionBeginsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.SessionBeginsPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.Word))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.TurnPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.TurnPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AssemblyAI.Realtime.Word>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.TerminationPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.TerminationPayloadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.ServerEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AssemblyAI.Realtime.ServerEventDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AssemblyAI.Realtime.Word>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}