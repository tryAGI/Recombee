#nullable enable

namespace Recombee
{
    public partial interface IRecommendationsClient
    {
        /// <summary>
        /// Recommend Items to Item Segment<br/>
        /// Recommends Items that are the most relevant to a particular Segment from a context [Segmentation](https://docs.recombee.com/segmentations).<br/>
        /// Based on the used Segmentation, this endpoint can be used for example for:<br/>
        /// - Recommending articles related to a particular topic<br/>
        /// - Recommending songs belonging to a particular genre<br/>
        /// - Recommending products produced by a particular brand<br/>
        /// You need to set the used context Segmentation in the Admin UI in the [Scenario settings](https://docs.recombee.com/scenarios) prior to using this endpoint.<br/>
        /// The returned items are sorted by relevance (the first item being the most relevant).<br/>
        /// It is also possible to use the POST HTTP method (for example, in the case of a very long ReQL filter) — query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsItemSegmentsItemsAsync(
            string databaseId,

            global::Recombee.RecommendItemsToItemSegmentParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recommend Items to Item Segment<br/>
        /// Recommends Items that are the most relevant to a particular Segment from a context [Segmentation](https://docs.recombee.com/segmentations).<br/>
        /// Based on the used Segmentation, this endpoint can be used for example for:<br/>
        /// - Recommending articles related to a particular topic<br/>
        /// - Recommending songs belonging to a particular genre<br/>
        /// - Recommending products produced by a particular brand<br/>
        /// You need to set the used context Segmentation in the Admin UI in the [Scenario settings](https://docs.recombee.com/scenarios) prior to using this endpoint.<br/>
        /// The returned items are sorted by relevance (the first item being the most relevant).<br/>
        /// It is also possible to use the POST HTTP method (for example, in the case of a very long ReQL filter) — query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="contextSegmentId">
        /// ID of the segment from `contextSegmentationId` for which the recommendations are to be generated.
        /// </param>
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
        /// Number of items to be recommended (N for the top-N recommendation).
        /// </param>
        /// <param name="scenario">
        /// Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">
        /// If a user of the given *targetUserId* doesn't exist in the database, it creates this user and returns some (non-personalized) recommendations. This allows, for example, rotations in the following recommendations for the user of the given *targetUserId*, as the user will be already known to the system.
        /// </param>
        /// <param name="returnProperties">
        /// With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used to easily display the recommended items to the user. <br/>
        /// Example response:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "0c6189e7-dc1a-429a-b613-192696309361",<br/>
        ///     "recomms":<br/>
        ///       [<br/>
        ///         {<br/>
        ///           "id": "tv-178",<br/>
        ///           "values": {<br/>
        ///             "description": "4K TV with 3D feature",<br/>
        ///             "categories":   ["Electronics", "Televisions"],<br/>
        ///             "price": 342,<br/>
        ///             "url": "myshop.com/tv-178"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "id": "mixer-42",<br/>
        ///           "values": {<br/>
        ///             "description": "Stainless Steel Mixer",<br/>
        ///             "categories":   ["Home &amp; Kitchen"],<br/>
        ///             "price": 39,<br/>
        ///             "url": "myshop.com/mixer-42"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     "numberNextRecommsCalls": 0<br/>
        ///   }<br/>
        /// ```
        /// </param>
        /// <param name="includedProperties">
        /// Allows specifying which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list.<br/>
        /// Example response for `includedProperties=description,price`:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "6842c725-a79f-4537-a02c-f34d668a3f80",<br/>
        ///     "recomms": <br/>
        ///       [<br/>
        ///         {<br/>
        ///           "id": "tv-178",<br/>
        ///           "values": {<br/>
        ///             "description": "4K TV with 3D feature",<br/>
        ///             "price": 342<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "id": "mixer-42",<br/>
        ///           "values": {<br/>
        ///             "description": "Stainless Steel Mixer",<br/>
        ///             "price": 39<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     "numberNextRecommsCalls": 0<br/>
        ///   }<br/>
        /// ```
        /// </param>
        /// <param name="filter">
        /// Boolean-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to filter recommended items based on the values of their attributes.<br/>
        /// Filters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="booster">
        /// Number-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to boost the recommendation rate of some items based on the values of their attributes.<br/>
        /// Boosters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="logic"></param>
        /// <param name="reqlExpressions">
        /// A dictionary of [ReQL](https://docs.recombee.com/reql) expressions that will be executed for each recommended item.<br/>
        /// This can be used to compute additional properties of the recommended items that are not stored in the database.<br/>
        /// The keys are the names of the expressions, and the values are the actual ReQL expressions.<br/>
        /// Example request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "reqlExpressions": {<br/>
        ///     "isInUsersCity": "context_user[\"city\"] in 'cities'",<br/>
        ///     "distanceToUser": "earth_distance('location', context_user[\"location\"])"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Example response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "recommId": "ce52ada4-e4d9-4885-943c-407db2dee837",<br/>
        ///   "recomms": <br/>
        ///     [<br/>
        ///       {<br/>
        ///         "id": "restaurant-178",<br/>
        ///         "reqlEvaluations": {<br/>
        ///           "isInUsersCity": true,<br/>
        ///           "distanceToUser": 5200.2<br/>
        ///         }<br/>
        ///       },<br/>
        ///       {<br/>
        ///         "id": "bar-42",<br/>
        ///         "reqlEvaluations": {<br/>
        ///           "isInUsersCity": false,<br/>
        ///           "distanceToUser": 2516.0<br/>
        ///         }<br/>
        ///       }<br/>
        ///     ],<br/>
        ///    "numberNextRecommsCalls": 0<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="minRelevance">
        /// **Expert option:** If the *targetUserId* is provided:  Specifies the threshold of how relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations being appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </param>
        /// <param name="rotationRate">
        /// **Expert option:** If the *targetUserId* is provided: If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per request in a backward fashion. You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example, `rotationRate=0.2` for only slight rotation of recommended items.
        /// </param>
        /// <param name="rotationTime">
        /// **Expert option:** If the *targetUserId* is provided: Taking *rotationRate* into account, specifies how long it takes for an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized.
        /// </param>
        /// <param name="expertSettings">
        /// Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">
        /// If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsItemSegmentsItemsAsync(
            string databaseId,
            string contextSegmentId,
            string targetUserId,
            int count,
            string? scenario = default,
            bool? cascadeCreate = default,
            bool? returnProperties = default,
            global::System.Collections.Generic.IList<string>? includedProperties = default,
            string? filter = default,
            string? booster = default,
            global::Recombee.Logic? logic = default,
            global::System.Collections.Generic.Dictionary<string, string>? reqlExpressions = default,
            global::Recombee.RecommendItemsToItemSegmentParametersMinRelevance? minRelevance = default,
            double? rotationRate = default,
            double? rotationTime = default,
            object? expertSettings = default,
            bool? returnAbGroup = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}