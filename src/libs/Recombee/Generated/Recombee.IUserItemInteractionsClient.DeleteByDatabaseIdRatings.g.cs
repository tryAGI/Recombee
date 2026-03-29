#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// Delete Rating<br/>
        /// Deletes an existing rating specified by (`userId`, `itemId`, `timestamp`) from the database or all the ratings with the given `userId` and `itemId` if `timestamp` is omitted.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="itemId"></param>
        /// <param name="timestamp"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdRatingsAsync(
            string databaseId,
            string userId,
            string itemId,
            double? timestamp = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}