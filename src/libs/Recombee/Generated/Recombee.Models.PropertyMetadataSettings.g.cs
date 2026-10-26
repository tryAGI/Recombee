
#nullable enable

namespace Recombee
{
    /// <summary>
    /// Optional configuration for this metadata entry.
    /// </summary>
    public sealed partial class PropertyMetadataSettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}