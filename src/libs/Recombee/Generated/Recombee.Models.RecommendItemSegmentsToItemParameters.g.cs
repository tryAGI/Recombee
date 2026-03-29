
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendItemSegmentsToItemParameters
    {
        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetUserId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetUserId { get; set; }

        /// <summary>
        /// Number of item segments to be recommended (N for the top-N recommendation).
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
        /// Boolean-returning [ReQL](https://docs.recombee.com/reql) expression which allows you to filter recommended segments based on the `segmentationId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Number-returning [ReQL](https://docs.recombee.com/reql) expression which allows you to boost recommendation rate of some segments based on the `segmentationId`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("booster")]
        public string? Booster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logic")]
        public global::Recombee.Logic? Logic { get; set; }

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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reqlExpressions")]
        public global::System.Collections.Generic.Dictionary<string, string>? ReqlExpressions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendItemSegmentsToItemParameters" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendItemSegmentsToItemParameters(
            string targetUserId,
            int count,
            string? scenario,
            bool? cascadeCreate,
            string? filter,
            string? booster,
            global::Recombee.Logic? logic,
            object? expertSettings,
            bool? returnAbGroup,
            global::System.Collections.Generic.Dictionary<string, string>? reqlExpressions)
        {
            this.TargetUserId = targetUserId ?? throw new global::System.ArgumentNullException(nameof(targetUserId));
            this.Count = count;
            this.Scenario = scenario;
            this.CascadeCreate = cascadeCreate;
            this.Filter = filter;
            this.Booster = booster;
            this.Logic = logic;
            this.ExpertSettings = expertSettings;
            this.ReturnAbGroup = returnAbGroup;
            this.ReqlExpressions = reqlExpressions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendItemSegmentsToItemParameters" /> class.
        /// </summary>
        public RecommendItemSegmentsToItemParameters()
        {
        }
    }
}