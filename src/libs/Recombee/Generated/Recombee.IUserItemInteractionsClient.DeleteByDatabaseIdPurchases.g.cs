#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// Delete Purchase<br/>
        /// Deletes an existing purchase uniquely specified by `userId`, `itemId`, and `timestamp` or all the purchases with the given `userId` and `itemId` if `timestamp` is omitted.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="itemId"></param>
        /// <param name="timestamp"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdPurchasesAsync(
            string databaseId,
            string userId,
            string itemId,
            double? timestamp = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}