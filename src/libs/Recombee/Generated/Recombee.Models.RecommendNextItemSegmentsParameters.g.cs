
#nullable enable

namespace Recombee
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RecommendNextItemSegmentsParameters
    {
        /// <summary>
        /// Number of item segments to be recommended
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendNextItemSegmentsParameters" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of item segments to be recommended
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendNextItemSegmentsParameters(
            int count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendNextItemSegmentsParameters" /> class.
        /// </summary>
        public RecommendNextItemSegmentsParameters()
        {
        }

    }
}