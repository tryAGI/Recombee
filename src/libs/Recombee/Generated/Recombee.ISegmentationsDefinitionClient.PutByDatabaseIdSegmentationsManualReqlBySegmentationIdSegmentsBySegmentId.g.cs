#nullable enable

namespace Recombee
{
    public partial interface ISegmentationsDefinitionClient
    {
        /// <summary>
        /// Add Manual ReQL Segment<br/>
        /// Adds a new Segment into a Manual ReQL Segmentation.<br/>
        /// The new Segment is defined by a [ReQL](https://docs.recombee.com/reql) filter that returns `true` for an item in case that this item belongs to the segment.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="segmentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdSegmentationsManualReqlBySegmentationIdSegmentsBySegmentIdAsync(
            string databaseId,
            string segmentationId,
            string segmentId,

            global::Recombee.ManualReQLSegmentParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Manual ReQL Segment<br/>
        /// Adds a new Segment into a Manual ReQL Segmentation.<br/>
        /// The new Segment is defined by a [ReQL](https://docs.recombee.com/reql) filter that returns `true` for an item in case that this item belongs to the segment.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="segmentId"></param>
        /// <param name="filter">
        /// ReQL filter that returns `true` for items that belong to this Segment. Otherwise returns `false`.
        /// </param>
        /// <param name="title">
        /// Human-readable name of the Segment that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdSegmentationsManualReqlBySegmentationIdSegmentsBySegmentIdAsync(
            string databaseId,
            string segmentationId,
            string segmentId,
            string filter,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}