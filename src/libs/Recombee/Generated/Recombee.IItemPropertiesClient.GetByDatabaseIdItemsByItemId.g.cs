#nullable enable

namespace Recombee
{
    public partial interface IItemPropertiesClient
    {
        /// <summary>
        /// Get Item Values<br/>
        /// Gets all the current property values of the given item.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetByDatabaseIdItemsByItemIdAsync(
            string databaseId,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}