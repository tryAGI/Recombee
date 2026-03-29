
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddSeries
    {
        /// <summary>
        /// If set to `true`, the item will be created with the same ID as the series. Default is `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascadeCreate")]
        public bool? CascadeCreate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddSeries" /> class.
        /// </summary>
        /// <param name="cascadeCreate">
        /// If set to `true`, the item will be created with the same ID as the series. Default is `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddSeries(
            bool? cascadeCreate)
        {
            this.CascadeCreate = cascadeCreate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddSeries" /> class.
        /// </summary>
        public AddSeries()
        {
        }
    }
}