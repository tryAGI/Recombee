#nullable enable

namespace Recombee
{
    public partial interface IItemPropertiesClient
    {
        /// <summary>
        /// Get Item Property Info<br/>
        /// Gets information about specified item property.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.PropertyInfo> GetByDatabaseIdItemsPropertiesByPropertyNameAsync(
            string databaseId,
            string propertyName,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Item Property Info<br/>
        /// Gets information about specified item property.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.AutoSDKHttpResponse<global::Recombee.PropertyInfo>> GetByDatabaseIdItemsPropertiesByPropertyNameAsResponseAsync(
            string databaseId,
            string propertyName,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}