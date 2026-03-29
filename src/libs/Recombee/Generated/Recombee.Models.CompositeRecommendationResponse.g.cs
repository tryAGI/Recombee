
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompositeRecommendationResponse
    {
        /// <summary>
        /// Id of the composite recommendation request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecommId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Recombee.Recommendation Source { get; set; }

        /// <summary>
        /// Obtained recommendations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recomms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Recombee.Recommendation> Recomms { get; set; }

        /// <summary>
        /// How many times *Recommend Next Items* have been called for this `recommId`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberNextRecommsCalls")]
        public int? NumberNextRecommsCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRecommendationResponse" /> class.
        /// </summary>
        /// <param name="recommId">
        /// Id of the composite recommendation request
        /// </param>
        /// <param name="source"></param>
        /// <param name="recomms">
        /// Obtained recommendations
        /// </param>
        /// <param name="numberNextRecommsCalls">
        /// How many times *Recommend Next Items* have been called for this `recommId`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompositeRecommendationResponse(
            string recommId,
            global::Recombee.Recommendation source,
            global::System.Collections.Generic.IList<global::Recombee.Recommendation> recomms,
            int? numberNextRecommsCalls)
        {
            this.RecommId = recommId ?? throw new global::System.ArgumentNullException(nameof(recommId));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Recomms = recomms ?? throw new global::System.ArgumentNullException(nameof(recomms));
            this.NumberNextRecommsCalls = numberNextRecommsCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeRecommendationResponse" /> class.
        /// </summary>
        public CompositeRecommendationResponse()
        {
        }
    }
}