
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Recommendation
    {
        /// <summary>
        /// Id of the recommended item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Property values of the recommended item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public object? Values { get; set; }

        /// <summary>
        /// Dictionary of evaluated ReQL expressions specified in the request and calculated for the recommended item.<br/>
        /// The keys are the names of the ReQL expressions, and the values are the results of the evaluations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reqlEvaluations")]
        public object? ReqlEvaluations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Recommendation" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the recommended item
        /// </param>
        /// <param name="values">
        /// Property values of the recommended item
        /// </param>
        /// <param name="reqlEvaluations">
        /// Dictionary of evaluated ReQL expressions specified in the request and calculated for the recommended item.<br/>
        /// The keys are the names of the ReQL expressions, and the values are the results of the evaluations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Recommendation(
            string id,
            object? values,
            object? reqlEvaluations)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Values = values;
            this.ReqlEvaluations = reqlEvaluations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Recommendation" /> class.
        /// </summary>
        public Recommendation()
        {
        }
    }
}