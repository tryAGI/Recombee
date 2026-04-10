#nullable enable

namespace Recombee
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Delete All Search Synonyms<br/>
        /// Deletes all synonyms defined in the database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdSynonymsItemsAsync(
            string databaseId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}