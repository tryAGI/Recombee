
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Series
    {
        /// <summary>
        /// Id of the series
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seriesId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SeriesId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Series" /> class.
        /// </summary>
        /// <param name="seriesId">
        /// Id of the series
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Series(
            string seriesId)
        {
            this.SeriesId = seriesId ?? throw new global::System.ArgumentNullException(nameof(seriesId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Series" /> class.
        /// </summary>
        public Series()
        {
        }
    }
}