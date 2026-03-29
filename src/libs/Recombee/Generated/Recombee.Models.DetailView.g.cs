
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailView
    {
        /// <summary>
        /// User who viewed the item
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
        /// UTC timestamp of the view as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recombee.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Recombee.OneOf<string, double?>? Timestamp { get; set; }

        /// <summary>
        /// Duration of the view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Sets whether the given user/item should be created if not present in the database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascadeCreate")]
        public bool? CascadeCreate { get; set; }

        /// <summary>
        /// If this detail view is based on a recommendation request, `recommId` is the id of the clicked recommendation.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailView" /> class.
        /// </summary>
        /// <param name="userId">
        /// User who viewed the item
        /// </param>
        /// <param name="itemId">
        /// Viewed item
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the view as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="duration">
        /// Duration of the view
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="recommId">
        /// If this detail view is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
        /// <param name="autoPresented">
        /// Indicates whether the item was automatically presented to the user (e.g., in a swiping feed) or explicitly requested by the user (e.g., by clicking on a link). Defaults to `false`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailView(
            string userId,
            string itemId,
            global::Recombee.OneOf<string, double?>? timestamp,
            int? duration,
            bool? cascadeCreate,
            string? recommId,
            object? additionalData,
            bool? autoPresented)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Timestamp = timestamp;
            this.Duration = duration;
            this.CascadeCreate = cascadeCreate;
            this.RecommId = recommId;
            this.AdditionalData = additionalData;
            this.AutoPresented = autoPresented;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailView" /> class.
        /// </summary>
        public DetailView()
        {
        }
    }
}