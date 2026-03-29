
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateManualReQLSegmentationParameters
    {
        /// <summary>
        /// What type of data should be segmented. Currently only `items` are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceType { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateManualReQLSegmentationParameters" /> class.
        /// </summary>
        /// <param name="sourceType">
        /// What type of data should be segmented. Currently only `items` are supported.
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
        public CreateManualReQLSegmentationParameters(
            string sourceType,
            string? title,
            string? description)
        {
            this.SourceType = sourceType ?? throw new global::System.ArgumentNullException(nameof(sourceType));
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManualReQLSegmentationParameters" /> class.
        /// </summary>
        public CreateManualReQLSegmentationParameters()
        {
        }
    }
}