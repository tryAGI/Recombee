#nullable enable

namespace Recombee
{
    public partial interface ISegmentationsDefinitionClient
    {
        /// <summary>
        /// Create Manual ReQL Segmentation<br/>
        /// Segment the items using multiple [ReQL](https://docs.recombee.com/reql) filters.<br/>
        /// Use the Add Manual ReQL Items Segment endpoint to create the individual segments.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdSegmentationsManualReqlBySegmentationIdAsync(
            string databaseId,
            string segmentationId,

            global::Recombee.CreateManualReQLSegmentationParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Manual ReQL Segmentation<br/>
        /// Segment the items using multiple [ReQL](https://docs.recombee.com/reql) filters.<br/>
        /// Use the Add Manual ReQL Items Segment endpoint to create the individual segments.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="sourceType">
        /// What type of data should be segmented. Currently only `items` are supported.
        /// </param>
        /// <param name="title">
        /// Human-readable name that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="description">
        /// Description that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdSegmentationsManualReqlBySegmentationIdAsync(
            string databaseId,
            string segmentationId,
            string sourceType,
            string? title = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}