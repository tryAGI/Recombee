
#nullable enable

namespace Recombee
{
    /// <summary>
    /// Additional data associated with the interaction. The expected structure is defined for specific use cases and will be provided by the Recombee Support team when applicable.
    /// </summary>
    public sealed partial class ViewPortionAdditionalData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}