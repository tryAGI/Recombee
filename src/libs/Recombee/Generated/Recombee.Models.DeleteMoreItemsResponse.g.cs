
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteMoreItemsResponse
    {
        /// <summary>
        /// Number of deleted items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// IDs of deleted items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ItemIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMoreItemsResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of deleted items
        /// </param>
        /// <param name="itemIds">
        /// IDs of deleted items
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteMoreItemsResponse(
            int count,
            global::System.Collections.Generic.IList<string> itemIds)
        {
            this.Count = count;
            this.ItemIds = itemIds ?? throw new global::System.ArgumentNullException(nameof(itemIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMoreItemsResponse" /> class.
        /// </summary>
        public DeleteMoreItemsResponse()
        {
        }
    }
}