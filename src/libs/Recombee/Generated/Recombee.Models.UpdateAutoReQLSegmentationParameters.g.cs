
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAutoReQLSegmentationParameters
    {
        /// <summary>
        /// ReQL expression that returns for each item a set with IDs of segments to which the item belongs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        public string? Expression { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateAutoReQLSegmentationParameters" /> class.
        /// </summary>
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
        public UpdateAutoReQLSegmentationParameters(
            string? expression,
            string? title,
            string? description)
        {
            this.Expression = expression;
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoReQLSegmentationParameters" /> class.
        /// </summary>
        public UpdateAutoReQLSegmentationParameters()
        {
        }
    }
}