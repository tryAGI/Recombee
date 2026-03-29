
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSearchSynonymsResponse
    {
        /// <summary>
        /// List of synonyms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synonyms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Recombee.SearchSynonym> Synonyms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSearchSynonymsResponse" /> class.
        /// </summary>
        /// <param name="synonyms">
        /// List of synonyms
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSearchSynonymsResponse(
            global::System.Collections.Generic.IList<global::Recombee.SearchSynonym> synonyms)
        {
            this.Synonyms = synonyms ?? throw new global::System.ArgumentNullException(nameof(synonyms));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSearchSynonymsResponse" /> class.
        /// </summary>
        public ListSearchSynonymsResponse()
        {
        }
    }
}