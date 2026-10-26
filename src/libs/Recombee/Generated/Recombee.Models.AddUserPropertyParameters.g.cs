
#nullable enable

namespace Recombee
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddUserPropertyParameters
    {
        /// <summary>
        /// Value type of the user property to be created. One of: `int`, `double`, `string`, `boolean`, `timestamp`, `set`.<br/>
        /// * `int` - Signed integer number.<br/>
        /// * `double` - Floating point number. It uses 64-bit base-2 format (IEEE 754 standard).<br/>
        /// * `string` - UTF-8 string.<br/>
        /// * `boolean` - *true* / *false*<br/>
        /// * `timestamp` - Value representing date and time. ISO8601-1 pattern (string) or UTC epoch time (number).<br/>
        /// * `set` - Set of strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recombee.JsonConverters.AddUserPropertyParametersTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Recombee.AddUserPropertyParametersType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::Recombee.PropertyRole? Role { get; set; }

        /// <summary>
        /// List of [metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) entries to assign to the property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.IList<global::Recombee.PropertyMetadata>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserPropertyParameters" /> class.
        /// </summary>
        /// <param name="type">
        /// Value type of the user property to be created. One of: `int`, `double`, `string`, `boolean`, `timestamp`, `set`.<br/>
        /// * `int` - Signed integer number.<br/>
        /// * `double` - Floating point number. It uses 64-bit base-2 format (IEEE 754 standard).<br/>
        /// * `string` - UTF-8 string.<br/>
        /// * `boolean` - *true* / *false*<br/>
        /// * `timestamp` - Value representing date and time. ISO8601-1 pattern (string) or UTC epoch time (number).<br/>
        /// * `set` - Set of strings.
        /// </param>
        /// <param name="role"></param>
        /// <param name="metadata">
        /// List of [metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) entries to assign to the property.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddUserPropertyParameters(
            global::Recombee.AddUserPropertyParametersType type,
            global::Recombee.PropertyRole? role,
            global::System.Collections.Generic.IList<global::Recombee.PropertyMetadata>? metadata)
        {
            this.Type = type;
            this.Role = role;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserPropertyParameters" /> class.
        /// </summary>
        public AddUserPropertyParameters()
        {
        }

    }
}