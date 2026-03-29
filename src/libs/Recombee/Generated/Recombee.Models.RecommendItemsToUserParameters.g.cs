
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendItemsToUserParameters
    {
        /// <summary>
        /// Number of items to be recommended (N for the top-N recommendation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenario")]
        public string? Scenario { get; set; }

        /// <summary>
        /// If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that user, as the user will be already known to the system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascadeCreate")]
        public bool? CascadeCreate { get; set; }

        /// <summary>
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
        ///      "numberNextRecommsCalls": 0<br/>
        ///   }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnProperties")]
        public bool? ReturnProperties { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedProperties")]
        public global::System.Collections.Generic.IList<string>? IncludedProperties { get; set; }

        /// <summary>
        /// Boolean-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to filter recommended items based on the values of their attributes.<br/>
        /// Filters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Number-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to boost the recommendation rate of some items based on the values of their attributes.<br/>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reqlExpressions")]
        public global::System.Collections.Generic.Dictionary<string, string>? ReqlExpressions { get; set; }

        /// <summary>
        /// **Expert option:** Real number from [0.0, 1.0], which determines how mutually dissimilar the recommended items should be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diversity")]
        public double? Diversity { get; set; }

        /// <summary>
        /// **Expert option:** Specifies the threshold of how relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations to be appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such a case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minRelevance")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Recombee.JsonConverters.RecommendItemsToUserParametersMinRelevanceJsonConverter))]
        public global::Recombee.RecommendItemsToUserParametersMinRelevance? MinRelevance { get; set; }

        /// <summary>
        /// **Expert option:** If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per request in a backward fashion. You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example, `rotationRate=0.2` for only slight rotation of recommended items. Default: `0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotationRate")]
        public double? RotationRate { get; set; }

        /// <summary>
        /// **Expert option:** Taking *rotationRate* into account, specifies how long it takes for an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized. Default: `7200.0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotationTime")]
        public double? RotationTime { get; set; }

        /// <summary>
        /// Dictionary of custom options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expertSettings")]
        public object? ExpertSettings { get; set; }

        /// <summary>
        /// If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnAbGroup")]
        public bool? ReturnAbGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendItemsToUserParameters" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of items to be recommended (N for the top-N recommendation).
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
        ///      "numberNextRecommsCalls": 0<br/>
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
        /// <param name="diversity">
        /// **Expert option:** Real number from [0.0, 1.0], which determines how mutually dissimilar the recommended items should be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </param>
        /// <param name="minRelevance">
        /// **Expert option:** Specifies the threshold of how relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations to be appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such a case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </param>
        /// <param name="rotationRate">
        /// **Expert option:** If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per request in a backward fashion. You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example, `rotationRate=0.2` for only slight rotation of recommended items. Default: `0`.
        /// </param>
        /// <param name="rotationTime">
        /// **Expert option:** Taking *rotationRate* into account, specifies how long it takes for an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized. Default: `7200.0`.
        /// </param>
        /// <param name="expertSettings">
        /// Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">
        /// If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendItemsToUserParameters(
            int count,
            string? scenario,
            bool? cascadeCreate,
            bool? returnProperties,
            global::System.Collections.Generic.IList<string>? includedProperties,
            string? filter,
            string? booster,
            global::Recombee.Logic? logic,
            global::System.Collections.Generic.Dictionary<string, string>? reqlExpressions,
            double? diversity,
            global::Recombee.RecommendItemsToUserParametersMinRelevance? minRelevance,
            double? rotationRate,
            double? rotationTime,
            object? expertSettings,
            bool? returnAbGroup)
        {
            this.Count = count;
            this.Scenario = scenario;
            this.CascadeCreate = cascadeCreate;
            this.ReturnProperties = returnProperties;
            this.IncludedProperties = includedProperties;
            this.Filter = filter;
            this.Booster = booster;
            this.Logic = logic;
            this.ReqlExpressions = reqlExpressions;
            this.Diversity = diversity;
            this.MinRelevance = minRelevance;
            this.RotationRate = rotationRate;
            this.RotationTime = rotationTime;
            this.ExpertSettings = expertSettings;
            this.ReturnAbGroup = returnAbGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendItemsToUserParameters" /> class.
        /// </summary>
        public RecommendItemsToUserParameters()
        {
        }
    }
}