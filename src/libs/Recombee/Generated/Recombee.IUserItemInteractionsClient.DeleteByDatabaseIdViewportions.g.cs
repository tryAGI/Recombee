#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// Delete View Portion<br/>
        /// Deletes an existing view portion specified by (`userId`, `itemId`, `sessionId`) from the database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="itemId"></param>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdViewportionsAsync(
            string databaseId,
            string userId,
            string itemId,
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}