#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// List Item Purchases<br/>
        /// Lists all the ever-made purchases of the given item.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.Purchase>> GetByDatabaseIdItemsByItemIdPurchasesAsync(
            string databaseId,
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}