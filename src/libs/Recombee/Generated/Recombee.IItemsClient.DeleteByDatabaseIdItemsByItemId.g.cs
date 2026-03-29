#nullable enable

namespace Recombee
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// Delete Item<br/>
        /// Deletes an item of the given `itemId` from the catalog.<br/>
        /// If there are any *purchases*, *ratings*, *bookmarks*, *cart additions*, or *detail views* of the item present in the database, they will be deleted in cascade as well. Also, if the item is present in some *series*, it will be removed from all the *series* where present.<br/>
        /// If an item becomes obsolete/no longer available, it is meaningful to keep it in the catalog (along with all the interaction data, which are very useful), and **only exclude the item from recommendations**. In such a case, use [ReQL filter](https://docs.recombee.com/reql) instead of deleting the item completely.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdItemsByItemIdAsync(
            string databaseId,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}