#nullable enable

namespace Recombee
{
    public partial interface IRecommendationsClient
    {
        /// <summary>
        /// Recommend Item Segments to Item<br/>
        /// Recommends Segments from a [Segmentation](https://docs.recombee.com/segmentations) that are the most relevant to a particular item.<br/>
        /// Based on the used Segmentation, this endpoint can be used for example for:<br/>
        ///   - Recommending the related categories<br/>
        ///   - Recommending the related genres<br/>
        ///   - Recommending the related brands<br/>
        ///   - Recommending the related artists<br/>
        /// You need to set the used Segmentation the Admin UI in the [Scenario settings](https://docs.recombee.com/scenarios) prior to using this endpoint.<br/>
        /// The returned segments are sorted by relevance (first segment being the most relevant).<br/>
        /// It is also possible to use POST HTTP method (for example in case of very long ReQL filter) - query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync(
            string databaseId,
            string itemId,

            global::Recombee.RecommendItemSegmentsToItemParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recommend Item Segments to Item<br/>
        /// Recommends Segments from a [Segmentation](https://docs.recombee.com/segmentations) that are the most relevant to a particular item.<br/>
        /// Based on the used Segmentation, this endpoint can be used for example for:<br/>
        ///   - Recommending the related categories<br/>
        ///   - Recommending the related genres<br/>
        ///   - Recommending the related brands<br/>
        ///   - Recommending the related artists<br/>
        /// You need to set the used Segmentation the Admin UI in the [Scenario settings](https://docs.recombee.com/scenarios) prior to using this endpoint.<br/>
        /// The returned segments are sorted by relevance (first segment being the most relevant).<br/>
        /// It is also possible to use POST HTTP method (for example in case of very long ReQL filter) - query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="targetUserId">
        /// ID of the user who will see the recommendations.<br/>
        /// Specifying the *targetUserId* is beneficial because:<br/>
        /// * It makes the recommendations personalized<br/>
        /// * Allows the calculation of Actions and Conversions<br/>
        ///   in the graphical user interface,<br/>
        ///   as Recombee can pair the user who got recommendations<br/>
        ///   and who afterward viewed/purchased an item.<br/>
        /// If you insist on not specifying the user, pass `null`<br/>
        /// (`None`, `nil`, `NULL` etc., depending on the language) to *targetUserId*.<br/>
        /// Do not create some special dummy user for getting recommendations,<br/>
        /// as it could mislead the recommendation models,<br/>
        /// and result in wrong recommendations.<br/>
        /// For anonymous/unregistered users, it is possible to use, for example, their session ID.
        /// </param>
        /// <param name="count">
        /// Number of item segments to be recommended (N for the top-N recommendation).
        /// </param>
        /// <param name="scenario">
        /// Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">
        /// If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that user, as the user will be already known to the system.
        /// </param>
        /// <param name="filter">
        /// Boolean-returning [ReQL](https://docs.recombee.com/reql) expression which allows you to filter recommended segments based on the `segmentationId`.
        /// </param>
        /// <param name="booster">
        /// Number-returning [ReQL](https://docs.recombee.com/reql) expression which allows you to boost recommendation rate of some segments based on the `segmentationId`.
        /// </param>
        /// <param name="logic"></param>
        /// <param name="expertSettings">
        /// Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">
        /// If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </param>
        /// <param name="reqlExpressions">
        /// A dictionary of [ReQL](https://docs.recombee.com/reql) expressions that will be executed for each recommended Item Segment.<br/>
        /// This can be used to compute additional properties of the recommended Item Segments.<br/>
        /// The keys are the names of the expressions, and the values are the actual ReQL expressions.<br/>
        /// Example request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "reqlExpressions": {<br/>
        ///     "countItems": "size(segment_items(\"categories\", 'segmentId'))"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Example response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "recommId": "a7ac55a4-8d6e-4f19-addc-abac4164d8a8",<br/>
        ///   "recomms": <br/>
        ///     [<br/>
        ///       {<br/>
        ///         "id": "category-fantasy-books",<br/>
        ///         "reqlEvaluations": {<br/>
        ///           "countItems": 486<br/>
        ///         }<br/>
        ///       },<br/>
        ///       {<br/>
        ///         "id": "category-sci-fi-costumes",<br/>
        ///         "reqlEvaluations": {<br/>
        ///           "countItems": 19<br/>
        ///         }<br/>
        ///       }<br/>
        ///     ],<br/>
        ///    "numberNextRecommsCalls": 0<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync(
            string databaseId,
            string itemId,
            string targetUserId,
            int count,
            string? scenario = default,
            bool? cascadeCreate = default,
            string? filter = default,
            string? booster = default,
            global::Recombee.Logic? logic = default,
            object? expertSettings = default,
            bool? returnAbGroup = default,
            global::System.Collections.Generic.Dictionary<string, string>? reqlExpressions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}