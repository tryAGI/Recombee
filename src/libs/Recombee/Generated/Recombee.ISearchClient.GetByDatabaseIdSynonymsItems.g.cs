#nullable enable

namespace Recombee
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// List Search Synonyms<br/>
        /// Gives the list of synonyms defined in the database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.ListSearchSynonymsResponse> GetByDatabaseIdSynonymsItemsAsync(
            string databaseId,
            int? count = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}