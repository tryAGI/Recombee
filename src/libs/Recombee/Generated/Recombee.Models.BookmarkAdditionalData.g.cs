
#nullable enable

namespace Recombee
{
    /// <summary>
    /// A dictionary of additional data for the interaction.
    /// </summary>
    public sealed partial class BookmarkAdditionalData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}