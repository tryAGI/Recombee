
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSegmentationsResponse
    {
        /// <summary>
        /// Array of existing Segmentations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Recombee.Segmentation> Segmentations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSegmentationsResponse" /> class.
        /// </summary>
        /// <param name="segmentations">
        /// Array of existing Segmentations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSegmentationsResponse(
            global::System.Collections.Generic.IList<global::Recombee.Segmentation> segmentations)
        {
            this.Segmentations = segmentations ?? throw new global::System.ArgumentNullException(nameof(segmentations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSegmentationsResponse" /> class.
        /// </summary>
        public ListSegmentationsResponse()
        {
        }
    }
}