#nullable enable

namespace Recombee
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Add Search Synonym<br/>
        /// Adds a new synonym for the [Search items](https://docs.recombee.com/api#search-items).<br/>
        /// When the `term` is used in the search query, the `synonym` is also used for the full-text search.<br/>
        /// Unless `oneWay=true`, it works also in the opposite way (`synonym` -&gt; `term`).<br/>
        /// An example of a synonym can be `science fiction` for the term `sci-fi`.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.SearchSynonym> CreateByDatabaseIdSynonymsItemsAsync(
            string databaseId,

            global::Recombee.SearchSynonymParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Search Synonym<br/>
        /// Adds a new synonym for the [Search items](https://docs.recombee.com/api#search-items).<br/>
        /// When the `term` is used in the search query, the `synonym` is also used for the full-text search.<br/>
        /// Unless `oneWay=true`, it works also in the opposite way (`synonym` -&gt; `term`).<br/>
        /// An example of a synonym can be `science fiction` for the term `sci-fi`.
        /// </summary>
        /// <param name="databaseId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.SearchSynonym> CreateByDatabaseIdSynonymsItemsAsync(
            string databaseId,
            string term,
            string synonym,
            bool? oneWay = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}