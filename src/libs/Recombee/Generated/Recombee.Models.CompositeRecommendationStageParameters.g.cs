
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompositeRecommendationStageParameters
    {
        /// <summary>
        /// With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used to easily display the recommended items to the user. <br/>
        /// Example response with `returnProperties` set in the `resultSettings`:<br/>
        /// ```json<br/>
        ///     {<br/>
        ///       "recommId": "ee94fa8b-efe7-4b35-abc6-2bc3456d66ed",<br/>
        ///       "source": {<br/>
        ///         "id": "category-sport"<br/>
        ///       },<br/>
        ///       "recomms": [<br/>
        ///         {<br/>
        ///           "id": "article-1024",<br/>
        ///           "values": {<br/>
        ///             "title": "Champions League: Stunning Comeback Secures Final Spot",<br/>
        ///             "categories": ["Sport", "Football"],<br/>
        ///             "author": "Jane Smith",<br/>
        ///             "url": "newsportal.com/articles/champions-league-comeback"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "id": "article-2031",<br/>
        ///           "values": {<br/>
        ///             "title": "Top 10 Moments from the Summer Olympics",<br/>
        ///             "categories": ["Sport", "Olympics"],<br/>
        ///             "author": "Mark Johnson",<br/>
        ///             "url": "newsportal.com/articles/olympic-top-moments"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "id": "article-3042",<br/>
        ///           "values": {<br/>
        ///             "title": "Rising Stars in Women's Tennis to Watch This Season",<br/>
        ///             "categories": ["Sport", "Tennis"],<br/>
        ///             "author": "Laura Chen",<br/>
        ///             "url": "newsportal.com/articles/womens-tennis-stars"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///       "numberNextRecommsCalls": 0<br/>
        ///     }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnProperties")]
        public bool? ReturnProperties { get; set; }

        /// <summary>
        /// Allows specifying which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list.<br/>
        /// Example response for  `returnProperties=true` and `includedProperties=title,url` set in `resultSettings`:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "ee94fa8b-efe7-4b35-abc6-2bc3456d66ed",<br/>
        ///     "source": {<br/>
        ///       "id": "category-sport"<br/>
        ///     },<br/>
        ///     "recomms": [<br/>
        ///       {<br/>
        ///         "id": "article-1024",<br/>
        ///         "values": {<br/>
        ///           "title": "Champions League: Stunning Comeback Secures Final Spot",<br/>
        ///           "url": "newsportal.com/articles/champions-league-comeback"<br/>
        ///         }<br/>
        ///       },<br/>
        ///       {<br/>
        ///         "id": "article-2031",<br/>
        ///         "values": {<br/>
        ///           "title": "Top 10 Moments from the Summer Olympics",<br/>
        ///           "url": "newsportal.com/articles/olympic-top-moments"<br/>
        ///         }<br/>
        ///       },<br/>
        ///       {<br/>
        ///         "id": "article-3042",<br/>
        ///         "values": {<br/>
        ///           "title": "Rising Stars in Women's Tennis to Watch This Season",<br/>
        ///           "url": "newsportal.com/articles/womens-tennis-stars"<br/>
        ///         }<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     "numberNextRecommsCalls": 0<br/>
        ///   }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedProperties")]
        public global::System.Collections.Generic.IList<string>? IncludedProperties { get; set; }

        /// <summary>
        /// Boolean-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to filter recommended entities based on the values of their attributes.<br/>
        /// Filters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Number-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to boost the recommendation rate of some entities based on the values of their attributes.<br/>
        /// Boosters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("booster")]
        public string? Booster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logic")]
        public global::Recombee.Logic? Logic { get; set; }

        /// <summary>
        /// Only usable if the stage corresponds to the one of these recommendation endpoints:<br/>
        /// - [Recommend Items To User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
        /// - [Recommend Items To Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
        /// - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
        /// - [Recommend Users to Item](https://docs.recombee.com/api#recommend-users-to-item)<br/>
        /// - [Recommend Users To User](https://docs.recombee.com/api#recommend-users-to-user)<br/>
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
        ///   "source": {<br/>
        ///     "id": "restaurant-123",<br/>
        ///     "reqlEvaluations": {<br/>
        ///       "isInUsersCity": true,<br/>
        ///       "distanceToUser": 3450.5<br/>
        ///     }<br/>
        ///   },<br/>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reqlExpressions")]
        public global::System.Collections.Generic.Dictionary<string, string>? ReqlExpressions { get; set; }

        /// <summary>
        /// **Expert option:** Only usable if the stage corresponds to the one of these recommendation endpoints:<br/>
        /// - [Recommend Items To User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
        /// - [Recommend Items To Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
        /// - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
        /// If the *userId* is provided:  Specifies the threshold of how relevant must the recommended items be to the user.<br/>
        /// Possible values one of: `"low"`, `"medium"`, `"high"`.<br/>
        /// The default value is `"low"`, meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations being appended to reach the full *count*.<br/>
        /// This behavior may be suppressed by using `"medium"` or `"high"` values. In such case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minRelevance")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recombee.JsonConverters.CompositeRecommendationStageParametersMinRelevanceJsonConverter))]
        public global::Recombee.CompositeRecommendationStageParametersMinRelevance? MinRelevance { get; set; }

        /// <summary>
        /// **Expert option:** Only usable if the stage corresponds to the one of these recommendation endpoints:<br/>
        /// - [Recommend Items To User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
        /// - [Recommend Items To Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
        /// - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
        /// - [Recommend Users To User](https://docs.recombee.com/api#recommend-users-to-user)<br/>
        /// If the *userId* is provided: If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per request in a backward fashion.<br/>
        /// You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example, `rotationRate=0.2` for only slight rotation of recommended items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotationRate")]
        public double? RotationRate { get; set; }

        /// <summary>
        /// **Expert option:** Only usable if the stage corresponds to the one of these recommendation endpoints:<br/>
        /// - [Recommend Items To User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
        /// - [Recommend Items To Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
        /// - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
        /// - [Recommend Users To User](https://docs.recombee.com/api#recommend-users-to-user)<br/>
        /// If the *userId* is provided: Taking *rotationRate* into account, specifies how long it takes for an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotationTime")]
        public double? RotationTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRecommendationStageParameters" /> class.
        /// </summary>
        /// <param name="returnProperties">
        /// With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used to easily display the recommended items to the user. <br/>
        /// Example response with `returnProperties` set in the `resultSettings`:<br/>
        /// ```json<br/>
        ///     {<br/>
        ///       "recommId": "ee94fa8b-efe7-4b35-abc6-2bc3456d66ed",<br/>
        ///       "source": {<br/>
        ///         "id": "category-sport"<br/>
        ///       },<br/>
        ///       "recomms": [<br/>
        ///         {<br/>
        ///           "id": "article-1024",<br/>
        ///           "values": {<br/>
        ///             "title": "Champions League: Stunning Comeback Secures Final Spot",<br/>
        ///             "categories": ["Sport", "Football"],<br/>
        ///             "author": "Jane Smith",<br/>
        ///             "url": "newsportal.com/articles/champions-league-comeback"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "id": "article-2031",<br/>
        ///           "values": {<br/>
        ///             "title": "Top 10 Moments from the Summer Olympics",<br/>
        ///             "categories": ["Sport", "Olympics"],<br/>
        ///             "author": "Mark Johnson",<br/>
        ///             "url": "newsportal.com/articles/olympic-top-moments"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "id": "article-3042",<br/>
        ///           "values": {<br/>
        ///             "title": "Rising Stars in Women's Tennis to Watch This Season",<br/>
        ///             "categories": ["Sport", "Tennis"],<br/>
        ///             "author": "Laura Chen",<br/>
        ///             "url": "newsportal.com/articles/womens-tennis-stars"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///       "numberNextRecommsCalls": 0<br/>
        ///     }<br/>
        /// ```
        /// </param>
        /// <param name="includedProperties">
        /// Allows specifying which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list.<br/>
        /// Example response for  `returnProperties=true` and `includedProperties=title,url` set in `resultSettings`:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "ee94fa8b-efe7-4b35-abc6-2bc3456d66ed",<br/>
        ///     "source": {<br/>
        ///       "id": "category-sport"<br/>
        ///     },<br/>
        ///     "recomms": [<br/>
        ///       {<br/>
        ///         "id": "article-1024",<br/>
        ///         "values": {<br/>
        ///           "title": "Champions League: Stunning Comeback Secures Final Spot",<br/>
        ///           "url": "newsportal.com/articles/champions-league-comeback"<br/>
        ///         }<br/>
        ///       },<br/>
        ///       {<br/>
        ///         "id": "article-2031",<br/>
        ///         "values": {<br/>
        ///           "title": "Top 10 Moments from the Summer Olympics",<br/>
        ///           "url": "newsportal.com/articles/olympic-top-moments"<br/>
        ///         }<br/>
        ///       },<br/>
        ///       {<br/>
        ///         "id": "article-3042",<br/>
        ///         "values": {<br/>
        ///           "title": "Rising Stars in Women's Tennis to Watch This Season",<br/>
        ///           "url": "newsportal.com/articles/womens-tennis-stars"<br/>
        ///         }<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     "numberNextRecommsCalls": 0<br/>
        ///   }<br/>
        /// ```
        /// </param>
        /// <param name="filter">
        /// Boolean-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to filter recommended entities based on the values of their attributes.<br/>
        /// Filters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="booster">
        /// Number-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to boost the recommendation rate of some entities based on the values of their attributes.<br/>
        /// Boosters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="logic"></param>
        /// <param name="reqlExpressions">
        /// Only usable if the stage corresponds to the one of these recommendation endpoints:<br/>
        /// - [Recommend Items To User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
        /// - [Recommend Items To Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
        /// - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
        /// - [Recommend Users to Item](https://docs.recombee.com/api#recommend-users-to-item)<br/>
        /// - [Recommend Users To User](https://docs.recombee.com/api#recommend-users-to-user)<br/>
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
        ///   "source": {<br/>
        ///     "id": "restaurant-123",<br/>
        ///     "reqlEvaluations": {<br/>
        ///       "isInUsersCity": true,<br/>
        ///       "distanceToUser": 3450.5<br/>
        ///     }<br/>
        ///   },<br/>
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
        /// **Expert option:** Only usable if the stage corresponds to the one of these recommendation endpoints:<br/>
        /// - [Recommend Items To User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
        /// - [Recommend Items To Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
        /// - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
        /// If the *userId* is provided:  Specifies the threshold of how relevant must the recommended items be to the user.<br/>
        /// Possible values one of: `"low"`, `"medium"`, `"high"`.<br/>
        /// The default value is `"low"`, meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations being appended to reach the full *count*.<br/>
        /// This behavior may be suppressed by using `"medium"` or `"high"` values. In such case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </param>
        /// <param name="rotationRate">
        /// **Expert option:** Only usable if the stage corresponds to the one of these recommendation endpoints:<br/>
        /// - [Recommend Items To User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
        /// - [Recommend Items To Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
        /// - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
        /// - [Recommend Users To User](https://docs.recombee.com/api#recommend-users-to-user)<br/>
        /// If the *userId* is provided: If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per request in a backward fashion.<br/>
        /// You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example, `rotationRate=0.2` for only slight rotation of recommended items.
        /// </param>
        /// <param name="rotationTime">
        /// **Expert option:** Only usable if the stage corresponds to the one of these recommendation endpoints:<br/>
        /// - [Recommend Items To User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
        /// - [Recommend Items To Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
        /// - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
        /// - [Recommend Users To User](https://docs.recombee.com/api#recommend-users-to-user)<br/>
        /// If the *userId* is provided: Taking *rotationRate* into account, specifies how long it takes for an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompositeRecommendationStageParameters(
            bool? returnProperties,
            global::System.Collections.Generic.IList<string>? includedProperties,
            string? filter,
            string? booster,
            global::Recombee.Logic? logic,
            global::System.Collections.Generic.Dictionary<string, string>? reqlExpressions,
            global::Recombee.CompositeRecommendationStageParametersMinRelevance? minRelevance,
            double? rotationRate,
            double? rotationTime)
        {
            this.ReturnProperties = returnProperties;
            this.IncludedProperties = includedProperties;
            this.Filter = filter;
            this.Booster = booster;
            this.Logic = logic;
            this.ReqlExpressions = reqlExpressions;
            this.MinRelevance = minRelevance;
            this.RotationRate = rotationRate;
            this.RotationTime = rotationTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRecommendationStageParameters" /> class.
        /// </summary>
        public CompositeRecommendationStageParameters()
        {
        }
    }
}