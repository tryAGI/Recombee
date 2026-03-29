#nullable enable

namespace Recombee
{
    public partial interface IItemPropertiesClient
    {
        /// <summary>
        /// Set Item Values<br/>
        /// Sets/updates (some) property values of the given item. The properties (columns) must be previously created by [Add item property](https://docs.recombee.com/api#add-item-property).
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="cascadeCreate"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdItemsByItemIdAsync(
            string databaseId,
            string itemId,

            string request,
            bool? cascadeCreate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}