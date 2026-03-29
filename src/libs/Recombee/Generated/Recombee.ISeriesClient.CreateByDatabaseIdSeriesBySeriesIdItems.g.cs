#nullable enable

namespace Recombee
{
    public partial interface ISeriesClient
    {
        /// <summary>
        /// Insert to Series<br/>
        /// Inserts an existing item/series into a series of the given seriesId at a position determined by time.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="seriesId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdSeriesBySeriesIdItemsAsync(
            string databaseId,
            string seriesId,

            global::Recombee.SeriesItem request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert to Series<br/>
        /// Inserts an existing item/series into a series of the given seriesId at a position determined by time.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="seriesId"></param>
        /// <param name="itemType">
        /// `item` iff the regular item from the catalog is to be inserted, `series` iff series is inserted as the item.
        /// </param>
        /// <param name="itemId">
        /// ID of the item iff `itemType` is `item`. ID of the series iff `itemType` is `series`.
        /// </param>
        /// <param name="time">
        /// Time index used for sorting items in the series. According to time, items are sorted within series in ascending order. In the example of TV show episodes, the episode number is a natural choice to be passed as time.
        /// </param>
        /// <param name="cascadeCreate">
        /// Indicates that any non-existing entity specified within the request should be created (as if corresponding PUT requests were invoked). This concerns both the `seriesId` and the `itemId`. If `cascadeCreate` is set to true, the behavior also depends on the `itemType`. In case of `item`, an item is created, in case of `series` a series + corresponding item with the same ID is created.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdSeriesBySeriesIdItemsAsync(
            string databaseId,
            string seriesId,
            string itemType,
            string itemId,
            double time,
            bool? cascadeCreate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}