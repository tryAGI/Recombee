
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Segmentation
    {
        /// <summary>
        /// Id of the Segmentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SegmentationId { get; set; }

        /// <summary>
        /// Determines on which type of data (e.g. `items`) the Segmentation is based
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceType { get; set; }

        /// <summary>
        /// Determines the type of the segmentation (Property-based, Manual ReQL, Auto ReQL)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentationType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SegmentationType { get; set; }

        /// <summary>
        /// Title of the Segmentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the Segmentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentation" /> class.
        /// </summary>
        /// <param name="segmentationId">
        /// Id of the Segmentation
        /// </param>
        /// <param name="sourceType">
        /// Determines on which type of data (e.g. `items`) the Segmentation is based
        /// </param>
        /// <param name="segmentationType">
        /// Determines the type of the segmentation (Property-based, Manual ReQL, Auto ReQL)
        /// </param>
        /// <param name="title">
        /// Title of the Segmentation
        /// </param>
        /// <param name="description">
        /// Description of the Segmentation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Segmentation(
            string segmentationId,
            string sourceType,
            string segmentationType,
            string? title,
            string? description)
        {
            this.SegmentationId = segmentationId ?? throw new global::System.ArgumentNullException(nameof(segmentationId));
            this.SourceType = sourceType ?? throw new global::System.ArgumentNullException(nameof(sourceType));
            this.SegmentationType = segmentationType ?? throw new global::System.ArgumentNullException(nameof(segmentationType));
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segmentation" /> class.
        /// </summary>
        public Segmentation()
        {
        }
    }
}