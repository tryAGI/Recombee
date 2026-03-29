#nullable enable

namespace Recombee
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// Delete More Items<br/>
        /// Deletes all the items that pass the filter.<br/>
        /// If an item becomes obsolete/no longer available, it is meaningful to **keep it in the catalog** (along with all the interaction data, which are very useful) and **only exclude the item from recommendations**. In such a case, use [ReQL filter](https://docs.recombee.com/reql) instead of deleting the item completely.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.DeleteMoreItemsResponse> DeleteByDatabaseIdMoreItemsAsync(
            string databaseId,

            global::Recombee.DeleteMoreItemsParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete More Items<br/>
        /// Deletes all the items that pass the filter.<br/>
        /// If an item becomes obsolete/no longer available, it is meaningful to **keep it in the catalog** (along with all the interaction data, which are very useful) and **only exclude the item from recommendations**. In such a case, use [ReQL filter](https://docs.recombee.com/reql) instead of deleting the item completely.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="filter">
        /// A [ReQL](https://docs.recombee.com/reql) expression, which returns `true` for the items that shall be updated.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.DeleteMoreItemsResponse> DeleteByDatabaseIdMoreItemsAsync(
            string databaseId,
            string filter,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}