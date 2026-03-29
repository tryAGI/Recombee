#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// List User View Portions<br/>
        /// Lists all the view portions ever submitted by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.ViewPortion>> GetByDatabaseIdUsersByUserIdViewportionsAsync(
            string databaseId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}