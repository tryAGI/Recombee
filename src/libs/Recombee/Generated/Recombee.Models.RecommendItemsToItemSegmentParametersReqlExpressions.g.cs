
#nullable enable

namespace Recombee
{
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
    public sealed partial class RecommendItemsToItemSegmentParametersReqlExpressions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}