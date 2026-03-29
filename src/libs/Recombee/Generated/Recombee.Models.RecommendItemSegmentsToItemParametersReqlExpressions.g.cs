
#nullable enable

namespace Recombee
{
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
    public sealed partial class RecommendItemSegmentsToItemParametersReqlExpressions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}