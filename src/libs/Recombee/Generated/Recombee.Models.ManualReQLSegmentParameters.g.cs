
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManualReQLSegmentParameters
    {
        /// <summary>
        /// ReQL filter that returns `true` for items that belong to this Segment. Otherwise returns `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filter { get; set; }

        /// <summary>
        /// Human-readable name of the Segment that is shown in the Recombee Admin UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualReQLSegmentParameters" /> class.
        /// </summary>
        /// <param name="filter">
        /// ReQL filter that returns `true` for items that belong to this Segment. Otherwise returns `false`.
        /// </param>
        /// <param name="title">
        /// Human-readable name of the Segment that is shown in the Recombee Admin UI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManualReQLSegmentParameters(
            string filter,
            string? title)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualReQLSegmentParameters" /> class.
        /// </summary>
        public ManualReQLSegmentParameters()
        {
        }
    }
}