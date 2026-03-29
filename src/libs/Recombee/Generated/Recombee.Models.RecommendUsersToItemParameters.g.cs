
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendUsersToItemParameters
    {
        /// <summary>
        /// Number of users to be recommended (N for the top-N recommendation).
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
        /// If an item of the given *itemId* doesn't exist in the database, it creates the missing item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascadeCreate")]
        public bool? CascadeCreate { get; set; }

        /// <summary>
        /// With `returnProperties=true`, property values of the recommended users are returned along with their IDs in a JSON dictionary. The acquired property values can be used to easily display the recommended users. <br/>
        /// Example response:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "039b71dc-b9cc-4645-a84f-62b841eecfce",<br/>
        ///     "recomms":<br/>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnProperties")]
        public bool? ReturnProperties { get; set; }

        /// <summary>
        /// Allows specifying which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list.<br/>
        /// Example response for `includedProperties=country`:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "b2b355dd-972a-4728-9c6b-2dc229db0678",<br/>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includedProperties")]
        public global::System.Collections.Generic.IList<string>? IncludedProperties { get; set; }

        /// <summary>
        /// Boolean-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to filter recommended users based on the values of their attributes.<br/>
        /// Filters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Number-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to boost the recommendation rate of some users based on the values of their attributes.<br/>
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
        /// A dictionary of [ReQL](https://docs.recombee.com/reql) expressions that will be executed for each recommended user.<br/>
        /// This can be used to compute additional properties of the recommended users that are not stored in the database.<br/>
        /// The keys are the names of the expressions, and the values are the actual ReQL expressions.<br/>
        /// Example request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "reqlExpressions": {<br/>
        ///     "isInUsersCity": "context_user[\"city\"] in 'cities'",<br/>
        ///     "distanceToUser": "earth_distance('location', context_user[\"location\"])",<br/>
        ///     "isFromSameCompany": "'company' == context_item[\"company\"]"<br/>
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
        ///           "distanceToUser": 5200.2,<br/>
        ///           "isFromSameCompany": false<br/>
        ///         }<br/>
        ///       },<br/>
        ///       {<br/>
        ///         "id": "bar-42",<br/>
        ///         "reqlEvaluations": {<br/>
        ///           "isInUsersCity": false,<br/>
        ///           "distanceToUser": 2516.0,<br/>
        ///           "isFromSameCompany": true<br/>
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
        /// **Expert option:** Real number from [0.0, 1.0], which determines how mutually dissimilar the recommended users should be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diversity")]
        public double? Diversity { get; set; }

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
        /// Initializes a new instance of the <see cref="RecommendUsersToItemParameters" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of users to be recommended (N for the top-N recommendation).
        /// </param>
        /// <param name="scenario">
        /// Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">
        /// If an item of the given *itemId* doesn't exist in the database, it creates the missing item.
        /// </param>
        /// <param name="returnProperties">
        /// With `returnProperties=true`, property values of the recommended users are returned along with their IDs in a JSON dictionary. The acquired property values can be used to easily display the recommended users. <br/>
        /// Example response:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "039b71dc-b9cc-4645-a84f-62b841eecfce",<br/>
        ///     "recomms":<br/>
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
        ///     "recommId": "b2b355dd-972a-4728-9c6b-2dc229db0678",<br/>
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
        ///     "distanceToUser": "earth_distance('location', context_user[\"location\"])",<br/>
        ///     "isFromSameCompany": "'company' == context_item[\"company\"]"<br/>
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
        ///           "distanceToUser": 5200.2,<br/>
        ///           "isFromSameCompany": false<br/>
        ///         }<br/>
        ///       },<br/>
        ///       {<br/>
        ///         "id": "bar-42",<br/>
        ///         "reqlEvaluations": {<br/>
        ///           "isInUsersCity": false,<br/>
        ///           "distanceToUser": 2516.0,<br/>
        ///           "isFromSameCompany": true<br/>
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
        /// <param name="expertSettings">
        /// Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">
        /// If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendUsersToItemParameters(
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
            this.ExpertSettings = expertSettings;
            this.ReturnAbGroup = returnAbGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendUsersToItemParameters" /> class.
        /// </summary>
        public RecommendUsersToItemParameters()
        {
        }
    }
}