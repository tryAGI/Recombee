
#nullable enable

namespace Recombee
{
    /// <summary>
    /// Optional configuration specific to the selected role.
    /// </summary>
    public sealed partial class PropertyRoleSettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}