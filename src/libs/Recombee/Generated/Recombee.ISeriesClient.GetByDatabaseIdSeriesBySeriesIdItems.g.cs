#nullable enable

namespace Recombee
{
    public partial interface ISeriesClient
    {
        /// <summary>
        /// List Series Items<br/>
        /// Lists all the items present in the given series, sorted according to their time index values.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="seriesId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.SeriesItem>> GetByDatabaseIdSeriesBySeriesIdItemsAsync(
            string databaseId,
            string seriesId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}