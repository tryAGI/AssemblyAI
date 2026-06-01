
#nullable enable

namespace AssemblyAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewPlantVariant2
    {
        /// <summary>
        /// Identification number of the plant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewPlantVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// Identification number of the plant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewPlantVariant2(
            long id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewPlantVariant2" /> class.
        /// </summary>
        public NewPlantVariant2()
        {
        }

    }
}