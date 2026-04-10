#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// List User Ratings<br/>
        /// Lists all the ratings ever submitted by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.Rating>> GetByDatabaseIdUsersByUserIdRatingsAsync(
            string databaseId,
            string userId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}