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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdSegmentationsManualReqlBySegmentationIdSegmentsBySegmentIdAsync(
            string databaseId,
            string segmentationId,
            string segmentId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Manual ReQL Segment<br/>
        /// Delete a Segment from a Manual ReQL Segmentation.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="segmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.AutoSDKHttpResponse> DeleteByDatabaseIdSegmentationsManualReqlBySegmentationIdSegmentsBySegmentIdAsResponseAsync(
            string databaseId,
            string segmentationId,
            string segmentId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}