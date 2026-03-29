
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViewPortion
    {
        /// <summary>
        /// User who viewed a portion of the item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Viewed item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Viewed portion of the item (number between 0.0 (viewed nothing) and 1.0 (viewed full item) ). It should be the actual viewed part of the item, no matter the seeking. For example, if the user seeked immediately to half of the item and then viewed 10% of the item, the `portion` should still be `0.1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("portion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Portion { get; set; }

        /// <summary>
        /// ID of the session in which the user viewed the item. Default is `null` (`None`, `nil`, `NULL` etc., depending on the language).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// UTC timestamp of the view portion as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
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
        /// If this view portion is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommId")]
        public string? RecommId { get; set; }

        /// <summary>
        /// A dictionary of additional data for the interaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalData")]
        public object? AdditionalData { get; set; }

        /// <summary>
        /// Indicates whether the item was automatically presented to the user (e.g., in a swiping feed) or explicitly requested by the user (e.g., by clicking on a link). Defaults to `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoPresented")]
        public bool? AutoPresented { get; set; }

        /// <summary>
        /// The duration (in seconds) that the user viewed the item. In update requests, this value may only increase and is required only if it has changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSpent")]
        public double? TimeSpent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewPortion" /> class.
        /// </summary>
        /// <param name="userId">
        /// User who viewed a portion of the item
        /// </param>
        /// <param name="itemId">
        /// Viewed item
        /// </param>
        /// <param name="portion">
        /// Viewed portion of the item (number between 0.0 (viewed nothing) and 1.0 (viewed full item) ). It should be the actual viewed part of the item, no matter the seeking. For example, if the user seeked immediately to half of the item and then viewed 10% of the item, the `portion` should still be `0.1`.
        /// </param>
        /// <param name="sessionId">
        /// ID of the session in which the user viewed the item. Default is `null` (`None`, `nil`, `NULL` etc., depending on the language).
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the view portion as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="recommId">
        /// If this view portion is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
        /// <param name="autoPresented">
        /// Indicates whether the item was automatically presented to the user (e.g., in a swiping feed) or explicitly requested by the user (e.g., by clicking on a link). Defaults to `false`.
        /// </param>
        /// <param name="timeSpent">
        /// The duration (in seconds) that the user viewed the item. In update requests, this value may only increase and is required only if it has changed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewPortion(
            string userId,
            string itemId,
            double portion,
            string? sessionId,
            global::Recombee.OneOf<string, double?>? timestamp,
            bool? cascadeCreate,
            string? recommId,
            object? additionalData,
            bool? autoPresented,
            double? timeSpent)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Portion = portion;
            this.SessionId = sessionId;
            this.Timestamp = timestamp;
            this.CascadeCreate = cascadeCreate;
            this.RecommId = recommId;
            this.AdditionalData = additionalData;
            this.AutoPresented = autoPresented;
            this.TimeSpent = timeSpent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewPortion" /> class.
        /// </summary>
        public ViewPortion()
        {
        }
    }
}