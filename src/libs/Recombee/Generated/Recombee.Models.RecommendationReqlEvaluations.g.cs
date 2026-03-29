
#nullable enable

namespace Recombee
{
    /// <summary>
    /// Dictionary of evaluated ReQL expressions specified in the request and calculated for the recommended item.<br/>
    /// The keys are the names of the ReQL expressions, and the values are the results of the evaluations.
    /// </summary>
    public sealed partial class RecommendationReqlEvaluations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}