
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace AssemblyAI.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSourceGenerationContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.UpdateConfigurationPayload? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.UpdateConfigurationPayloadType? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.UpdateConfigurationPayloadMode? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.ForceEndpointPayload? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.ForceEndpointPayloadType? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SessionTerminationPayload? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SessionTerminationPayloadType? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SessionBeginsPayload? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SessionBeginsPayloadType? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SessionConfiguration? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SpeechStartedPayload? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SpeechStartedPayloadType? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.Word? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.TurnPayload? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.TurnPayloadType? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Realtime.Word>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SpeakerRevisionPayload? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SpeakerRevisionPayloadType? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Realtime.SpeakerRevision>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SpeakerRevision? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::AssemblyAI.Realtime.SpeakerRevisionWord>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.SpeakerRevisionWord? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.TerminationPayload? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.TerminationPayloadType? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.ErrorPayload? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.ErrorPayloadType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.KeepAlivePayload? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.KeepAlivePayloadType? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.ServerEvent? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.ServerEventDiscriminator? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::AssemblyAI.Realtime.ServerEventDiscriminatorType? Type36 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Realtime.Word>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Realtime.SpeakerRevision>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::AssemblyAI.Realtime.SpeakerRevisionWord>? ListType3 { get; set; }
    }
}