#nullable enable

namespace Recombee
{
    public partial interface ISeriesClient
    {
        /// <summary>
        /// Delete Series<br/>
        /// Deletes the series of the given `seriesId` from the database.<br/>
        /// Deleting a series will only delete assignment of items to it, not the items themselves!
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="seriesId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdSeriesBySeriesIdAsync(
            string databaseId,
            string seriesId,

            global::Recombee.DeleteSeries request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Series<br/>
        /// Deletes the series of the given `seriesId` from the database.<br/>
        /// Deleting a series will only delete assignment of items to it, not the items themselves!
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="seriesId"></param>
        /// <param name="cascadeDelete">
        /// If set to `true`, item with the same ID as seriesId will be also deleted. Default is `false`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdSeriesBySeriesIdAsync(
            string databaseId,
            string seriesId,
            bool? cascadeDelete = default,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}