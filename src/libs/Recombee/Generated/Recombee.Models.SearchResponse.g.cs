
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResponse
    {
        /// <summary>
        /// Id of the personalized search request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecommId { get; set; }

        /// <summary>
        /// Results of the personalized search
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
        /// Name of AB-testing group to which the request belongs if there is a custom AB-testing running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abGroup")]
        public string? AbGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="recommId">
        /// Id of the personalized search request
        /// </param>
        /// <param name="recomms">
        /// Results of the personalized search
        /// </param>
        /// <param name="numberNextRecommsCalls">
        /// How many times *Recommend Next Items* have been called for this `recommId`
        /// </param>
        /// <param name="abGroup">
        /// Name of AB-testing group to which the request belongs if there is a custom AB-testing running.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponse(
            string recommId,
            global::System.Collections.Generic.IList<global::Recombee.Recommendation> recomms,
            int? numberNextRecommsCalls,
            string? abGroup)
        {
            this.RecommId = recommId ?? throw new global::System.ArgumentNullException(nameof(recommId));
            this.Recomms = recomms ?? throw new global::System.ArgumentNullException(nameof(recomms));
            this.NumberNextRecommsCalls = numberNextRecommsCalls;
            this.AbGroup = abGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        public SearchResponse()
        {
        }
    }
}