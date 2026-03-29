#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// List User Cart Additions<br/>
        /// Lists all the cart additions ever made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.CartAddition>> GetByDatabaseIdUsersByUserIdCartadditionsAsync(
            string databaseId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}