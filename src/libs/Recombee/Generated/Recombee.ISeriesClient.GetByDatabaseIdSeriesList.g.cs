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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.Series>> GetByDatabaseIdSeriesListAsync(
            string databaseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}