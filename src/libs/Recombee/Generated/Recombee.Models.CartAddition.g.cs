
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CartAddition
    {
        /// <summary>
        /// User who added the item to the cart
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Item added to the cart
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// UTC timestamp of the cart addition as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
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
        /// Amount (number) added to cart. The default is 1. For example, if `user-x` adds two `item-y` during a single order (session...), the `amount` should equal 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Price of the added item. If `amount` is greater than 1, the sum of prices of all the items should be given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// If this cart addition is based on a recommendation request, `recommId` is the id of the clicked recommendation.
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
        /// Initializes a new instance of the <see cref="CartAddition" /> class.
        /// </summary>
        /// <param name="userId">
        /// User who added the item to the cart
        /// </param>
        /// <param name="itemId">
        /// Item added to the cart
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the cart addition as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="amount">
        /// Amount (number) added to cart. The default is 1. For example, if `user-x` adds two `item-y` during a single order (session...), the `amount` should equal 2.
        /// </param>
        /// <param name="price">
        /// Price of the added item. If `amount` is greater than 1, the sum of prices of all the items should be given.
        /// </param>
        /// <param name="recommId">
        /// If this cart addition is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CartAddition(
            string userId,
            string itemId,
            global::Recombee.OneOf<string, double?>? timestamp,
            bool? cascadeCreate,
            double? amount,
            double? price,
            string? recommId,
            object? additionalData)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Timestamp = timestamp;
            this.CascadeCreate = cascadeCreate;
            this.Amount = amount;
            this.Price = price;
            this.RecommId = recommId;
            this.AdditionalData = additionalData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartAddition" /> class.
        /// </summary>
        public CartAddition()
        {
        }
    }
}