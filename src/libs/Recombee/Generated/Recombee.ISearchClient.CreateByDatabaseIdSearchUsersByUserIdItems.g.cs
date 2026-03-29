#nullable enable

namespace Recombee
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search Items<br/>
        /// Full-text personalized search. The results are based on the provided `searchQuery` and also on the user's past interactions (purchases, ratings, etc.) with the items (items more suitable for the user are preferred in the results).<br/>
        /// All the string and set item properties are indexed by the search engine.<br/>
        /// This endpoint should be used in a search box on your website/app. It can be called multiple times as the user is typing the query in order to get the most viable suggestions based on the current state of the query, or once after submitting the whole query. <br/>
        /// The returned items are sorted by relevance (the first item being the most relevant).<br/>
        /// Besides the recommended items, also a unique `recommId` is returned in the response. It can be used to:<br/>
        /// - Let Recombee know that this search was successful (e.g., user clicked one of the recommended items). See [Reported metrics](https://docs.recombee.com/admin_ui#reported-metrics).<br/>
        /// - Get subsequent search results when the user scrolls down or goes to the next page. See [Recommend Next Items](https://docs.recombee.com/api#recommend-next-items).<br/>
        /// It is also possible to use POST HTTP method (for example in the case of a very long ReQL filter) - query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.SearchResponse> CreateByDatabaseIdSearchUsersByUserIdItemsAsync(
            string databaseId,
            string userId,

            global::Recombee.SearchItemsParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Items<br/>
        /// Full-text personalized search. The results are based on the provided `searchQuery` and also on the user's past interactions (purchases, ratings, etc.) with the items (items more suitable for the user are preferred in the results).<br/>
        /// All the string and set item properties are indexed by the search engine.<br/>
        /// This endpoint should be used in a search box on your website/app. It can be called multiple times as the user is typing the query in order to get the most viable suggestions based on the current state of the query, or once after submitting the whole query. <br/>
        /// The returned items are sorted by relevance (the first item being the most relevant).<br/>
        /// Besides the recommended items, also a unique `recommId` is returned in the response. It can be used to:<br/>
        /// - Let Recombee know that this search was successful (e.g., user clicked one of the recommended items). See [Reported metrics](https://docs.recombee.com/admin_ui#reported-metrics).<br/>
        /// - Get subsequent search results when the user scrolls down or goes to the next page. See [Recommend Next Items](https://docs.recombee.com/api#recommend-next-items).<br/>
        /// It is also possible to use POST HTTP method (for example in the case of a very long ReQL filter) - query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="searchQuery">
        /// Search query provided by the user. It is used for the full-text search.
        /// </param>
        /// <param name="count">
        /// Number of items to be returned (N for the top-N results).
        /// </param>
        /// <param name="scenario">
        /// Scenario defines a particular search field in your user interface.<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each field performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately, or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">
        /// If the user does not exist in the database, returns a list of non-personalized search results and creates the user in the database. This allows, for example, rotations in the following recommendations for that user, as the user will be already known to the system.
        /// </param>
        /// <param name="returnProperties">
        /// With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used to easily display the recommended items to the user. <br/>
        /// Example response:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "ce52ada4-e4d9-4885-943c-407db2dee837",<br/>
        ///     "recomms": <br/>
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
        ///     "recommId": "a86ee8d5-cd8e-46d1-886c-8b3771d0520b",<br/>
        ///     "recomms":<br/>
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
        /// <param name="expertSettings">
        /// Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">
        /// If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.SearchResponse> CreateByDatabaseIdSearchUsersByUserIdItemsAsync(
            string databaseId,
            string userId,
            string searchQuery,
            int count,
            string? scenario = default,
            bool? cascadeCreate = default,
            bool? returnProperties = default,
            global::System.Collections.Generic.IList<string>? includedProperties = default,
            string? filter = default,
            string? booster = default,
            global::Recombee.Logic? logic = default,
            global::System.Collections.Generic.Dictionary<string, string>? reqlExpressions = default,
            object? expertSettings = default,
            bool? returnAbGroup = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}