
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Rating
    {
        /// <summary>
        /// User who submitted the rating
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Rated item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// UTC timestamp of the rating as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Recombee.OneOf<string, double?>? Timestamp { get; set; }

        /// <summary>
        /// Rating rescaled to interval [-1.0,1.0], where -1.0 means the worst rating possible, 0.0 means neutral, and 1.0 means absolutely positive rating. For example, in the case of 5-star evaluations, rating = (numStars-3)/2 formula may be used for the conversion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rating1 { get; set; }

        /// <summary>
        /// Sets whether the given user/item should be created if not present in the database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascadeCreate")]
        public bool? CascadeCreate { get; set; }

        /// <summary>
        /// If this rating is based on a recommendation request, `recommId` is the id of the clicked recommendation.
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
        /// Initializes a new instance of the <see cref="Rating" /> class.
        /// </summary>
        /// <param name="userId">
        /// User who submitted the rating
        /// </param>
        /// <param name="itemId">
        /// Rated item
        /// </param>
        /// <param name="rating1">
        /// Rating rescaled to interval [-1.0,1.0], where -1.0 means the worst rating possible, 0.0 means neutral, and 1.0 means absolutely positive rating. For example, in the case of 5-star evaluations, rating = (numStars-3)/2 formula may be used for the conversion.
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the rating as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="recommId">
        /// If this rating is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Rating(
            string userId,
            string itemId,
            double rating1,
            global::Recombee.OneOf<string, double?>? timestamp,
            bool? cascadeCreate,
            string? recommId,
            object? additionalData)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Timestamp = timestamp;
            this.Rating1 = rating1;
            this.CascadeCreate = cascadeCreate;
            this.RecommId = recommId;
            this.AdditionalData = additionalData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rating" /> class.
        /// </summary>
        public Rating()
        {
        }
    }
}