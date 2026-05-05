#nullable enable

namespace Recombee
{
    public partial interface ISeriesClient
    {
        /// <summary>
        /// List Series<br/>
        /// Gets the list of all the series currently present in the database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.Series>> GetByDatabaseIdSeriesListAsync(
            string databaseId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Series<br/>
        /// Gets the list of all the series currently present in the database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Recombee.Series>>> GetByDatabaseIdSeriesListAsResponseAsync(
            string databaseId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}