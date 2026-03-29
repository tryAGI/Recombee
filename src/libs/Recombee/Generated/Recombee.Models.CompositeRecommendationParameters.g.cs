
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompositeRecommendationParameters
    {
        /// <summary>
        /// Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenario")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scenario { get; set; }

        /// <summary>
        /// Number of items to be recommended (N for the top-N recommendation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// ID of the item for which the recommendations are to be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        /// <summary>
        /// ID of the user for which the recommendations are to be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logic")]
        public global::Recombee.Logic? Logic { get; set; }

        /// <summary>
        /// ID of the segment from `contextSegmentationId` for which the recommendations are to be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentId")]
        public string? SegmentId { get; set; }

        /// <summary>
        /// If the entity for the source recommendation does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that entity, as the entity will be already known to the system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascadeCreate")]
        public bool? CascadeCreate { get; set; }

        /// <summary>
        /// Parameters applied for recommending the *Source* stage. The accepted parameters correspond with the recommendation sub-endpoint used to recommend the *Source*.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceSettings")]
        public object? SourceSettings { get; set; }

        /// <summary>
        /// Parameters applied for recommending the *Result* stage. The accepted parameters correspond with the recommendation sub-endpoint used to recommend the *Result*.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultSettings")]
        public object? ResultSettings { get; set; }

        /// <summary>
        /// Dictionary of custom options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expertSettings")]
        public object? ExpertSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRecommendationParameters" /> class.
        /// </summary>
        /// <param name="scenario">
        /// Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="count">
        /// Number of items to be recommended (N for the top-N recommendation).
        /// </param>
        /// <param name="itemId">
        /// ID of the item for which the recommendations are to be generated.
        /// </param>
        /// <param name="userId">
        /// ID of the user for which the recommendations are to be generated.
        /// </param>
        /// <param name="logic"></param>
        /// <param name="segmentId">
        /// ID of the segment from `contextSegmentationId` for which the recommendations are to be generated.
        /// </param>
        /// <param name="cascadeCreate">
        /// If the entity for the source recommendation does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that entity, as the entity will be already known to the system.
        /// </param>
        /// <param name="sourceSettings">
        /// Parameters applied for recommending the *Source* stage. The accepted parameters correspond with the recommendation sub-endpoint used to recommend the *Source*.
        /// </param>
        /// <param name="resultSettings">
        /// Parameters applied for recommending the *Result* stage. The accepted parameters correspond with the recommendation sub-endpoint used to recommend the *Result*.
        /// </param>
        /// <param name="expertSettings">
        /// Dictionary of custom options.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompositeRecommendationParameters(
            string scenario,
            int count,
            string? itemId,
            string? userId,
            global::Recombee.Logic? logic,
            string? segmentId,
            bool? cascadeCreate,
            object? sourceSettings,
            object? resultSettings,
            object? expertSettings)
        {
            this.Scenario = scenario ?? throw new global::System.ArgumentNullException(nameof(scenario));
            this.Count = count;
            this.ItemId = itemId;
            this.UserId = userId;
            this.Logic = logic;
            this.SegmentId = segmentId;
            this.CascadeCreate = cascadeCreate;
            this.SourceSettings = sourceSettings;
            this.ResultSettings = resultSettings;
            this.ExpertSettings = expertSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRecommendationParameters" /> class.
        /// </summary>
        public CompositeRecommendationParameters()
        {
        }
    }
}