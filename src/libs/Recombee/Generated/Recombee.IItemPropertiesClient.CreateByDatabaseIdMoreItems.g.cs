#nullable enable

namespace Recombee
{
    public partial interface IItemPropertiesClient
    {
        /// <summary>
        /// Update More Items<br/>
        /// Updates (some) property values of all the items that pass the filter.<br/>
        /// Example: *Setting all the items that are older than a week as unavailable*<br/>
        ///   ```json<br/>
        ///     {<br/>
        ///       "filter": "'releaseDate' &lt; now() - 7*24*3600",<br/>
        ///       "changes": {"available": false}<br/>
        ///     }<br/>
        ///   ```
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.UpdateMoreItemsResponse> CreateByDatabaseIdMoreItemsAsync(
            string databaseId,

            global::Recombee.UpdateMoreItemsParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update More Items<br/>
        /// Updates (some) property values of all the items that pass the filter.<br/>
        /// Example: *Setting all the items that are older than a week as unavailable*<br/>
        ///   ```json<br/>
        ///     {<br/>
        ///       "filter": "'releaseDate' &lt; now() - 7*24*3600",<br/>
        ///       "changes": {"available": false}<br/>
        ///     }<br/>
        ///   ```
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.AutoSDKHttpResponse<global::Recombee.UpdateMoreItemsResponse>> CreateByDatabaseIdMoreItemsAsResponseAsync(
            string databaseId,

            global::Recombee.UpdateMoreItemsParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update More Items<br/>
        /// Updates (some) property values of all the items that pass the filter.<br/>
        /// Example: *Setting all the items that are older than a week as unavailable*<br/>
        ///   ```json<br/>
        ///     {<br/>
        ///       "filter": "'releaseDate' &lt; now() - 7*24*3600",<br/>
        ///       "changes": {"available": false}<br/>
        ///     }<br/>
        ///   ```
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="filter">
        /// A [ReQL](https://docs.recombee.com/reql) expression, which returns `true` for the items that shall be updated.
        /// </param>
        /// <param name="changes">
        /// A dictionary where the keys are properties that shall be updated.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.UpdateMoreItemsResponse> CreateByDatabaseIdMoreItemsAsync(
            string databaseId,
            string filter,
            object changes,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}