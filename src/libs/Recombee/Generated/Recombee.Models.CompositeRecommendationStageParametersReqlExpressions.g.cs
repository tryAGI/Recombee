
#nullable enable

namespace Recombee
{
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
    public sealed partial class CompositeRecommendationStageParametersReqlExpressions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}