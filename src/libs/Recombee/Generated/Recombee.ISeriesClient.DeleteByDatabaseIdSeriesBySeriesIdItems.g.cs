#nullable enable

namespace Recombee
{
    public partial interface ISeriesClient
    {
        /// <summary>
        /// Remove from Series<br/>
        /// Removes an existing series item from the series.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="seriesId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdSeriesBySeriesIdItemsAsync(
            string databaseId,
            string seriesId,

            global::Recombee.RemoveSeriesItem request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove from Series<br/>
        /// Removes an existing series item from the series.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="seriesId"></param>
        /// <param name="itemType">
        /// Type of the item to be removed.
        /// </param>
        /// <param name="itemId">
        /// ID of the item iff `itemType` is `item`. ID of the series iff `itemType` is `series`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdSeriesBySeriesIdItemsAsync(
            string databaseId,
            string seriesId,
            string itemType,
            string itemId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}