
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAutoReQLSegmentationParameters
    {
        /// <summary>
        /// What type of data should be segmented. Currently only `items` are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceType { get; set; }

        /// <summary>
        /// ReQL expression that returns for each item a set with IDs of segments to which the item belongs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expression { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateAutoReQLSegmentationParameters" /> class.
        /// </summary>
        /// <param name="sourceType">
        /// What type of data should be segmented. Currently only `items` are supported.
        /// </param>
        /// <param name="expression">
        /// ReQL expression that returns for each item a set with IDs of segments to which the item belongs
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
        public CreateAutoReQLSegmentationParameters(
            string sourceType,
            string expression,
            string? title,
            string? description)
        {
            this.SourceType = sourceType ?? throw new global::System.ArgumentNullException(nameof(sourceType));
            this.Expression = expression ?? throw new global::System.ArgumentNullException(nameof(expression));
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutoReQLSegmentationParameters" /> class.
        /// </summary>
        public CreateAutoReQLSegmentationParameters()
        {
        }
    }
}