
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Batch
    {
        /// <summary>
        /// JSON array containing the requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Requests { get; set; }

        /// <summary>
        /// Makes all the recommended items for a certain user distinct among multiple recommendation requests in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinctRecomms")]
        public bool? DistinctRecomms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        /// <param name="requests">
        /// JSON array containing the requests.
        /// </param>
        /// <param name="distinctRecomms">
        /// Makes all the recommended items for a certain user distinct among multiple recommendation requests in the batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Batch(
            global::System.Collections.Generic.IList<object> requests,
            bool? distinctRecomms)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.DistinctRecomms = distinctRecomms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        public Batch()
        {
        }
    }
}