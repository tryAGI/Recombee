#nullable enable

namespace Recombee
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Delete Search Synonym<br/>
        /// Deletes synonym of the given `id`. This synonym is no longer taken into account in the [Search items](https://docs.recombee.com/api#search-items).
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdSynonymsItemsByIdAsync(
            string databaseId,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}