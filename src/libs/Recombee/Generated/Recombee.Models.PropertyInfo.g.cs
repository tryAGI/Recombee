
#nullable enable

namespace Recombee
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PropertyInfo
    {
        /// <summary>
        /// Name of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Type of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::Recombee.PropertyRole? Role { get; set; }

        /// <summary>
        /// [Metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) entries associated with the property.<br/>
        /// Metadata provides additional configuration or annotations that influence how the property is processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.IList<global::Recombee.PropertyMetadata>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInfo" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the property
        /// </param>
        /// <param name="type">
        /// Type of the property
        /// </param>
        /// <param name="role"></param>
        /// <param name="metadata">
        /// [Metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) entries associated with the property.<br/>
        /// Metadata provides additional configuration or annotations that influence how the property is processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertyInfo(
            string name,
            string type,
            global::Recombee.PropertyRole? role,
            global::System.Collections.Generic.IList<global::Recombee.PropertyMetadata>? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Role = role;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInfo" /> class.
        /// </summary>
        public PropertyInfo()
        {
        }

    }
}