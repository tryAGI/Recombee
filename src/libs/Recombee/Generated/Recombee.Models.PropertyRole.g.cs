
#nullable enable

namespace Recombee
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PropertyRole
    {
        /// <summary>
        /// Name of the [role](https://docs.recombee.com/api/property_roles_metadata#roles) assigned to the property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional configuration specific to the selected role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyRole" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the [role](https://docs.recombee.com/api/property_roles_metadata#roles) assigned to the property.
        /// </param>
        /// <param name="settings">
        /// Optional configuration specific to the selected role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertyRole(
            string name,
            object? settings)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyRole" /> class.
        /// </summary>
        public PropertyRole()
        {
        }

    }
}