
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchSynonym
    {
        /// <summary>
        /// Id of the synonym record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A word to which the `synonym` is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Term { get; set; }

        /// <summary>
        /// A word that should be considered equal to `term` by the full-text search engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synonym")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Synonym { get; set; }

        /// <summary>
        /// If set to `true`, only `term` -&gt; `synonym` is considered. I set to `false`, also `synonym` -&gt; `term` works.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneWay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OneWay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynonym" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the synonym record
        /// </param>
        /// <param name="term">
        /// A word to which the `synonym` is specified.
        /// </param>
        /// <param name="synonym">
        /// A word that should be considered equal to `term` by the full-text search engine.
        /// </param>
        /// <param name="oneWay">
        /// If set to `true`, only `term` -&gt; `synonym` is considered. I set to `false`, also `synonym` -&gt; `term` works.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchSynonym(
            string id,
            string term,
            string synonym,
            bool oneWay)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Term = term ?? throw new global::System.ArgumentNullException(nameof(term));
            this.Synonym = synonym ?? throw new global::System.ArgumentNullException(nameof(synonym));
            this.OneWay = oneWay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynonym" /> class.
        /// </summary>
        public SearchSynonym()
        {
        }
    }
}