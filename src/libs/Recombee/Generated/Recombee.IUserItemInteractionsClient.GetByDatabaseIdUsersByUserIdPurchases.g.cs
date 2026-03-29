#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// List User Purchases<br/>
        /// Lists all the purchases ever made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.Purchase>> GetByDatabaseIdUsersByUserIdPurchasesAsync(
            string databaseId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}