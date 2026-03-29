
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Purchase
    {
        /// <summary>
        /// User who purchased the item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Purchased item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// UTC timestamp of the purchase as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Recombee.OneOf<string, double?>? Timestamp { get; set; }

        /// <summary>
        /// Sets whether the given user/item should be created if not present in the database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascadeCreate")]
        public bool? CascadeCreate { get; set; }

        /// <summary>
        /// Amount (number) of purchased items. The default is 1. For example, if `user-x` purchases two `item-y` during a single order (session...), the `amount` should equal 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Price paid by the user for the item. If `amount` is greater than 1, the sum of prices of all the items should be given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Your profit from the purchased item. The profit is natural in the e-commerce domain (for example, if `user-x` purchases `item-y` for $100 and the gross margin is 30 %, then the profit is $30) but is also applicable in other domains (for example, at a news company it may be income from a displayed advertisement on article page). If `amount` is greater than 1, the sum of profit of all the items should be given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profit")]
        public double? Profit { get; set; }

        /// <summary>
        /// If this purchase is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommId")]
        public string? RecommId { get; set; }

        /// <summary>
        /// A dictionary of additional data for the interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalData")]
        public object? AdditionalData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase" /> class.
        /// </summary>
        /// <param name="userId">
        /// User who purchased the item
        /// </param>
        /// <param name="itemId">
        /// Purchased item
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the purchase as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="amount">
        /// Amount (number) of purchased items. The default is 1. For example, if `user-x` purchases two `item-y` during a single order (session...), the `amount` should equal 2.
        /// </param>
        /// <param name="price">
        /// Price paid by the user for the item. If `amount` is greater than 1, the sum of prices of all the items should be given.
        /// </param>
        /// <param name="profit">
        /// Your profit from the purchased item. The profit is natural in the e-commerce domain (for example, if `user-x` purchases `item-y` for $100 and the gross margin is 30 %, then the profit is $30) but is also applicable in other domains (for example, at a news company it may be income from a displayed advertisement on article page). If `amount` is greater than 1, the sum of profit of all the items should be given.
        /// </param>
        /// <param name="recommId">
        /// If this purchase is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Purchase(
            string userId,
            string itemId,
            global::Recombee.OneOf<string, double?>? timestamp,
            bool? cascadeCreate,
            double? amount,
            double? price,
            double? profit,
            string? recommId,
            object? additionalData)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Timestamp = timestamp;
            this.CascadeCreate = cascadeCreate;
            this.Amount = amount;
            this.Price = price;
            this.Profit = profit;
            this.RecommId = recommId;
            this.AdditionalData = additionalData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase" /> class.
        /// </summary>
        public Purchase()
        {
        }
    }
}