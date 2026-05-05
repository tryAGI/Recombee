#nullable enable

namespace Recombee
{
    public partial interface IItemPropertiesClient
    {
        /// <summary>
        /// List Item Properties<br/>
        /// Gets the list of all the item properties in your database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.PropertyInfo>> GetByDatabaseIdItemsPropertiesListAsync(
            string databaseId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Item Properties<br/>
        /// Gets the list of all the item properties in your database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Recombee.PropertyInfo>>> GetByDatabaseIdItemsPropertiesListAsResponseAsync(
            string databaseId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}