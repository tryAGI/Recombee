#nullable enable

namespace Recombee
{
    public partial interface ISegmentationsDefinitionClient
    {
        /// <summary>
        /// Delete Manual ReQL Segment<br/>
        /// Delete a Segment from a Manual ReQL Segmentation.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="segmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdSegmentationsManualReqlBySegmentationIdSegmentsBySegmentIdAsync(
            string databaseId,
            string segmentationId,
            string segmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}