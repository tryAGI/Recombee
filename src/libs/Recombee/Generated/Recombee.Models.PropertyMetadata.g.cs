
#nullable enable

namespace Recombee
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PropertyMetadata
    {
        /// <summary>
        /// Name of the [metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) assigned to the property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional configuration for this metadata entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyMetadata" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the [metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) assigned to the property.
        /// </param>
        /// <param name="settings">
        /// Optional configuration for this metadata entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertyMetadata(
            string name,
            object? settings)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyMetadata" /> class.
        /// </summary>
        public PropertyMetadata()
        {
        }

    }
}