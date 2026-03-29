#nullable enable

namespace Recombee
{
    public partial interface IRecommendationsClient
    {
        /// <summary>
        /// Recommend Users to User<br/>
        /// Gets users similar to the given user, based on the user's past interactions (purchases, ratings, etc.) and values of properties.<br/>
        /// It is also possible to use POST HTTP method (for example in the case of a very long ReQL filter) - query parameters then become body parameters.<br/>
        /// The returned users are sorted by similarity (the first user being the most similar).
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsUsersByUserIdUsersAsync(
            string databaseId,
            string userId,

            global::Recombee.RecommendUsersToUserParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recommend Users to User<br/>
        /// Gets users similar to the given user, based on the user's past interactions (purchases, ratings, etc.) and values of properties.<br/>
        /// It is also possible to use POST HTTP method (for example in the case of a very long ReQL filter) - query parameters then become body parameters.<br/>
        /// The returned users are sorted by similarity (the first user being the most similar).
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="count">
        /// Number of users to be recommended (N for the top-N recommendation).
        /// </param>
        /// <param name="scenario">
        /// Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">
        /// If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that user, as the user will be already known to the system.
        /// </param>
        /// <param name="returnProperties">
        /// With `returnProperties=true`, property values of the recommended users are returned along with their IDs in a JSON dictionary. The acquired property values can be used to easily display the recommended users. <br/>
        /// Example response:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "9cb9c55d-50ba-4478-84fd-ab456136156e",<br/>
        ///     "recomms": <br/>
        ///       [<br/>
        ///         {<br/>
        ///           "id": "user-17",<br/>
        ///           "values": {<br/>
        ///             "country": "US",<br/>
        ///             "sex": "F"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "id": "user-2",<br/>
        ///           "values": {<br/>
        ///             "country": "CAN",<br/>
        ///             "sex": "M"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     "numberNextRecommsCalls": 0<br/>
        ///   }<br/>
        /// ```
        /// </param>
        /// <param name="includedProperties">
        /// Allows specifying which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list.<br/>
        /// Example response for `includedProperties=country`:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "b326d82d-5d57-4b45-b362-c9d6f0895855",<br/>
        ///     "recomms":<br/>
        ///       [<br/>
        ///         {<br/>
        ///           "id": "user-17",<br/>
        ///           "values": {<br/>
        ///             "country": "US"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "id": "user-2",<br/>
        ///           "values": {<br/>
        ///             "country": "CAN"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     "numberNextRecommsCalls": 0<br/>
        ///   }<br/>
        /// ```
        /// </param>
        /// <param name="filter">
        /// Boolean-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to filter recommended users based on the values of their attributes.<br/>
        /// Filters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="booster">
        /// Number-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to boost the recommendation rate of some users based on the values of their attributes.<br/>
        /// Boosters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="logic"></param>
        /// <param name="reqlExpressions">
        /// A dictionary of [ReQL](https://docs.recombee.com/reql) expressions that will be executed for each recommended user.<br/>
        /// This can be used to compute additional properties of the recommended users that are not stored in the database.<br/>
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
        /// <param name="diversity">
        /// **Expert option:** Real number from [0.0, 1.0], which determines how mutually dissimilar the recommended users should be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </param>
        /// <param name="minRelevance">
        /// **Expert option:** Specifies the threshold of how relevant must the recommended users be. Possible values one of: "low", "medium", "high".
        /// </param>
        /// <param name="rotationRate">
        /// **Expert option:** If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per request in a backward fashion. You may penalize a user for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example, `rotationRate=0.2` for only slight rotation of recommended users.
        /// </param>
        /// <param name="rotationTime">
        /// **Expert option:** Taking *rotationRate* into account, specifies how long it takes for a user to recover from the penalization. For example, `rotationTime=7200.0` means that users recommended less than 2 hours ago are penalized.
        /// </param>
        /// <param name="expertSettings">
        /// Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">
        /// If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsUsersByUserIdUsersAsync(
            string databaseId,
            string userId,
            int count,
            string? scenario = default,
            bool? cascadeCreate = default,
            bool? returnProperties = default,
            global::System.Collections.Generic.IList<string>? includedProperties = default,
            string? filter = default,
            string? booster = default,
            global::Recombee.Logic? logic = default,
            global::System.Collections.Generic.Dictionary<string, string>? reqlExpressions = default,
            double? diversity = default,
            global::Recombee.RecommendUsersToUserParametersMinRelevance? minRelevance = default,
            double? rotationRate = default,
            double? rotationTime = default,
            object? expertSettings = default,
            bool? returnAbGroup = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}