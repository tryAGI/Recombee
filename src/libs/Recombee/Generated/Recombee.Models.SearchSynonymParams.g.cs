
#nullable enable

namespace Recombee
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchSynonymParams
    {
        /// <summary>
        /// A word to which the `synonym` is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Term { get; set; }

        /// <summary>
        /// A word that should be considered equal to the `term` by the full-text search engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("synonym")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Synonym { get; set; }

        /// <summary>
        /// If set to `true`, only `term` -&gt; `synonym` is considered. If set to `false`, also `synonym` -&gt; `term` works.<br/>
        /// Default: `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneWay")]
        public bool? OneWay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynonymParams" /> class.
        /// </summary>
        /// <param name="term">
        /// A word to which the `synonym` is specified.
        /// </param>
        /// <param name="synonym">
        /// A word that should be considered equal to the `term` by the full-text search engine.
        /// </param>
        /// <param name="oneWay">
        /// If set to `true`, only `term` -&gt; `synonym` is considered. If set to `false`, also `synonym` -&gt; `term` works.<br/>
        /// Default: `false`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchSynonymParams(
            string term,
            string synonym,
            bool? oneWay)
        {
            this.Term = term ?? throw new global::System.ArgumentNullException(nameof(term));
            this.Synonym = synonym ?? throw new global::System.ArgumentNullException(nameof(synonym));
            this.OneWay = oneWay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynonymParams" /> class.
        /// </summary>
        public SearchSynonymParams()
        {
        }
    }
}