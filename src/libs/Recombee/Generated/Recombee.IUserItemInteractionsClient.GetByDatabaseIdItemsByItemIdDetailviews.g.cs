#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// List Item Detail Views<br/>
        /// Lists all the detail views of the given item ever made by different users.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.DetailView>> GetByDatabaseIdItemsByItemIdDetailviewsAsync(
            string databaseId,
            string itemId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}