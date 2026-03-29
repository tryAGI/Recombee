#nullable enable

namespace Recombee
{
    public partial interface ISeriesClient
    {
        /// <summary>
        /// Add Series<br/>
        /// Creates a new series in the database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="seriesId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdSeriesBySeriesIdAsync(
            string databaseId,
            string seriesId,

            global::Recombee.AddSeries request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Series<br/>
        /// Creates a new series in the database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="seriesId"></param>
        /// <param name="cascadeCreate">
        /// If set to `true`, the item will be created with the same ID as the series. Default is `true`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdSeriesBySeriesIdAsync(
            string databaseId,
            string seriesId,
            bool? cascadeCreate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}