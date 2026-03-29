
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePropertyBasedSegmentationParameters
    {
        /// <summary>
        /// Name of the property on which the Segmentation should be based
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propertyName")]
        public string? PropertyName { get; set; }

        /// <summary>
        /// Human-readable name that is shown in the Recombee Admin UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description that is shown in the Recombee Admin UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePropertyBasedSegmentationParameters" /> class.
        /// </summary>
        /// <param name="propertyName">
        /// Name of the property on which the Segmentation should be based
        /// </param>
        /// <param name="title">
        /// Human-readable name that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="description">
        /// Description that is shown in the Recombee Admin UI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePropertyBasedSegmentationParameters(
            string? propertyName,
            string? title,
            string? description)
        {
            this.PropertyName = propertyName;
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePropertyBasedSegmentationParameters" /> class.
        /// </summary>
        public UpdatePropertyBasedSegmentationParameters()
        {
        }
    }
}