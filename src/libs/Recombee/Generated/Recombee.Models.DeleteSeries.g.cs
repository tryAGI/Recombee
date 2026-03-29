
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteSeries
    {
        /// <summary>
        /// If set to `true`, item with the same ID as seriesId will be also deleted. Default is `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascadeDelete")]
        public bool? CascadeDelete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSeries" /> class.
        /// </summary>
        /// <param name="cascadeDelete">
        /// If set to `true`, item with the same ID as seriesId will be also deleted. Default is `false`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteSeries(
            bool? cascadeDelete)
        {
            this.CascadeDelete = cascadeDelete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteSeries" /> class.
        /// </summary>
        public DeleteSeries()
        {
        }
    }
}