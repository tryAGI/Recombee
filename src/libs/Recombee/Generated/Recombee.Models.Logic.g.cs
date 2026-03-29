
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Logic
    {
        /// <summary>
        /// Name of the logic that should be used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Parameters passed to the logic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Logic" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the logic that should be used
        /// </param>
        /// <param name="settings">
        /// Parameters passed to the logic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Logic(
            string? name,
            object? settings)
        {
            this.Name = name;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Logic" /> class.
        /// </summary>
        public Logic()
        {
        }
    }
}