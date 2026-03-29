#nullable enable

namespace Recombee
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// Add Item<br/>
        /// Adds new item of the given `itemId` to the items catalog.<br/>
        /// All the item properties for the newly created items are set to null.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdItemsByItemIdAsync(
            string databaseId,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}