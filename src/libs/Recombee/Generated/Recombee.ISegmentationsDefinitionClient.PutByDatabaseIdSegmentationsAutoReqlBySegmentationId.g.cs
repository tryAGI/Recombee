#nullable enable

namespace Recombee
{
    public partial interface ISegmentationsDefinitionClient
    {
        /// <summary>
        /// Create Auto ReQL Segmentation<br/>
        /// Segment the items using a [ReQL](https://docs.recombee.com/reql) expression.<br/>
        /// For each item, the expression should return a set that contains IDs of segments to which the item belongs to.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync(
            string databaseId,
            string segmentationId,

            global::Recombee.CreateAutoReQLSegmentationParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Auto ReQL Segmentation<br/>
        /// Segment the items using a [ReQL](https://docs.recombee.com/reql) expression.<br/>
        /// For each item, the expression should return a set that contains IDs of segments to which the item belongs to.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="sourceType">
        /// What type of data should be segmented. Currently only `items` are supported.
        /// </param>
        /// <param name="expression">
        /// ReQL expression that returns for each item a set with IDs of segments to which the item belongs
        /// </param>
        /// <param name="title">
        /// Human-readable name that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="description">
        /// Description that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync(
            string databaseId,
            string segmentationId,
            string sourceType,
            string expression,
            string? title = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}