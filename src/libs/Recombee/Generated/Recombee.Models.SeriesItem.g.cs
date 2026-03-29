
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SeriesItem
    {
        /// <summary>
        /// `item` iff the regular item from the catalog is to be inserted, `series` iff series is inserted as the item.
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
        /// Time index used for sorting items in the series. According to time, items are sorted within series in ascending order. In the example of TV show episodes, the episode number is a natural choice to be passed as time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// Indicates that any non-existing entity specified within the request should be created (as if corresponding PUT requests were invoked). This concerns both the `seriesId` and the `itemId`. If `cascadeCreate` is set to true, the behavior also depends on the `itemType`. In case of `item`, an item is created, in case of `series` a series + corresponding item with the same ID is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascadeCreate")]
        public bool? CascadeCreate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesItem" /> class.
        /// </summary>
        /// <param name="itemType">
        /// `item` iff the regular item from the catalog is to be inserted, `series` iff series is inserted as the item.
        /// </param>
        /// <param name="itemId">
        /// ID of the item iff `itemType` is `item`. ID of the series iff `itemType` is `series`.
        /// </param>
        /// <param name="time">
        /// Time index used for sorting items in the series. According to time, items are sorted within series in ascending order. In the example of TV show episodes, the episode number is a natural choice to be passed as time.
        /// </param>
        /// <param name="cascadeCreate">
        /// Indicates that any non-existing entity specified within the request should be created (as if corresponding PUT requests were invoked). This concerns both the `seriesId` and the `itemId`. If `cascadeCreate` is set to true, the behavior also depends on the `itemType`. In case of `item`, an item is created, in case of `series` a series + corresponding item with the same ID is created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SeriesItem(
            string itemType,
            string itemId,
            double time,
            bool? cascadeCreate)
        {
            this.ItemType = itemType ?? throw new global::System.ArgumentNullException(nameof(itemType));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Time = time;
            this.CascadeCreate = cascadeCreate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesItem" /> class.
        /// </summary>
        public SeriesItem()
        {
        }
    }
}