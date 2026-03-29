
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveSeriesItem
    {
        /// <summary>
        /// Type of the item to be removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemType { get; set; }

        /// <summary>
        /// ID of the item iff `itemType` is `item`. ID of the series iff `itemType` is `series`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveSeriesItem" /> class.
        /// </summary>
        /// <param name="itemType">
        /// Type of the item to be removed.
        /// </param>
        /// <param name="itemId">
        /// ID of the item iff `itemType` is `item`. ID of the series iff `itemType` is `series`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveSeriesItem(
            string itemType,
            string itemId)
        {
            this.ItemType = itemType ?? throw new global::System.ArgumentNullException(nameof(itemType));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveSeriesItem" /> class.
        /// </summary>
        public RemoveSeriesItem()
        {
        }
    }
}