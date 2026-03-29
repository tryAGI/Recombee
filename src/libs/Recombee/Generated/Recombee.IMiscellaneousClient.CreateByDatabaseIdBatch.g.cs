#nullable enable

namespace Recombee
{
    public partial interface IMiscellaneousClient
    {
        /// <summary>
        /// Batch<br/>
        /// Batch processing allows you to submit arbitrary sequence of requests within a single HTTPS request.<br/>
        /// Any type of request from the above documentation may be used in the Batch, and the Batch may combine different types of requests arbitrarily as well.<br/>
        /// Using Batch requests is beneficial for example, when synchronizing the catalog of items or uploading historical interaction data, as sending the data in Batch is considerably faster than sending the individual requests (thanks to optimizations and  reducing network and HTTPS overhead).
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdBatchAsync(
            string databaseId,

            global::Recombee.Batch request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch<br/>
        /// Batch processing allows you to submit arbitrary sequence of requests within a single HTTPS request.<br/>
        /// Any type of request from the above documentation may be used in the Batch, and the Batch may combine different types of requests arbitrarily as well.<br/>
        /// Using Batch requests is beneficial for example, when synchronizing the catalog of items or uploading historical interaction data, as sending the data in Batch is considerably faster than sending the individual requests (thanks to optimizations and  reducing network and HTTPS overhead).
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="requests">
        /// JSON array containing the requests.
        /// </param>
        /// <param name="distinctRecomms">
        /// Makes all the recommended items for a certain user distinct among multiple recommendation requests in the batch.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdBatchAsync(
            string databaseId,
            global::System.Collections.Generic.IList<object> requests,
            bool? distinctRecomms = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}