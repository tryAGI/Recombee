#nullable enable

namespace Recombee
{
    public partial interface IRecommendationsClient
    {
        /// <summary>
        /// Composite Recommendation<br/>
        /// Composite Recommendation returns both a *source entity* (e.g., an Item or [Item Segment](https://docs.recombee.com/segmentations.html)) and a list of related recommendations in a single response.<br/>
        /// It is ideal for use cases such as personalized homepage sections (*Articles from &lt;category&gt;*), *Because You Watched &lt;movie&gt;*, or *Artists Related to Your Favorite Artist &lt;artist&gt;*.<br/>
        /// See detailed **examples and configuration guidance** in the [Composite Scenarios documentation](https://docs.recombee.com/scenarios#composite-recommendations).<br/>
        /// **Structure**<br/>
        /// The endpoint operates in two stages:<br/>
        /// 1. Recommends the *source* (e.g., an Item Segment or item) to the user.<br/>
        /// 2. Recommends *results* (items or Item Segments) related to that *source*.<br/>
        /// For example, *Articles from &lt;category&gt;* can be decomposed into:<br/>
        ///   - [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-item-segments-to-user) to find the category.<br/>
        ///   - [Recommend Items To Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment) to recommend articles from that category.<br/>
        /// Since the first step uses [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-items-to-user), you must include the `userId` parameter in the *Composite Recommendation* request.<br/>
        /// Each *Composite Recommendation* counts as a single recommendation API request for billing.<br/>
        /// **Stage-specific Parameters**<br/>
        /// Additional parameters can be supplied via [sourceSettings](https://docs.recombee.com/api#composite-recommendation-param-sourceSettings) and [resultSettings](https://docs.recombee.com/api#composite-recommendation-param-resultSettings).<br/>
        /// In the example above:<br/>
        ///   - `sourceSettings` may include any parameter valid for [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-items-to-user) (e.g., `filter`, `booster`).<br/>
        ///   - `resultSettings` may include any parameter valid for [Recommend Items To Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment).<br/>
        /// See [this example](https://docs.recombee.com/api#composite-recommendation-example-setting-parameters-for-individual-stages) for more details.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.CompositeRecommendationResponse> CreateByDatabaseIdRecommsCompositeAsync(
            string databaseId,

            global::Recombee.CompositeRecommendationParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Composite Recommendation<br/>
        /// Composite Recommendation returns both a *source entity* (e.g., an Item or [Item Segment](https://docs.recombee.com/segmentations.html)) and a list of related recommendations in a single response.<br/>
        /// It is ideal for use cases such as personalized homepage sections (*Articles from &lt;category&gt;*), *Because You Watched &lt;movie&gt;*, or *Artists Related to Your Favorite Artist &lt;artist&gt;*.<br/>
        /// See detailed **examples and configuration guidance** in the [Composite Scenarios documentation](https://docs.recombee.com/scenarios#composite-recommendations).<br/>
        /// **Structure**<br/>
        /// The endpoint operates in two stages:<br/>
        /// 1. Recommends the *source* (e.g., an Item Segment or item) to the user.<br/>
        /// 2. Recommends *results* (items or Item Segments) related to that *source*.<br/>
        /// For example, *Articles from &lt;category&gt;* can be decomposed into:<br/>
        ///   - [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-item-segments-to-user) to find the category.<br/>
        ///   - [Recommend Items To Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment) to recommend articles from that category.<br/>
        /// Since the first step uses [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-items-to-user), you must include the `userId` parameter in the *Composite Recommendation* request.<br/>
        /// Each *Composite Recommendation* counts as a single recommendation API request for billing.<br/>
        /// **Stage-specific Parameters**<br/>
        /// Additional parameters can be supplied via [sourceSettings](https://docs.recombee.com/api#composite-recommendation-param-sourceSettings) and [resultSettings](https://docs.recombee.com/api#composite-recommendation-param-resultSettings).<br/>
        /// In the example above:<br/>
        ///   - `sourceSettings` may include any parameter valid for [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-items-to-user) (e.g., `filter`, `booster`).<br/>
        ///   - `resultSettings` may include any parameter valid for [Recommend Items To Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment).<br/>
        /// See [this example](https://docs.recombee.com/api#composite-recommendation-example-setting-parameters-for-individual-stages) for more details.
        /// </summary>
        /// <param name="databaseId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.CompositeRecommendationResponse> CreateByDatabaseIdRecommsCompositeAsync(
            string databaseId,
            string scenario,
            int count,
            string? itemId = default,
            string? userId = default,
            global::Recombee.Logic? logic = default,
            string? segmentId = default,
            bool? cascadeCreate = default,
            object? sourceSettings = default,
            object? resultSettings = default,
            object? expertSettings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}