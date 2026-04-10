#nullable enable

namespace Recombee
{
    public partial interface ISegmentationsDefinitionClient
    {
        /// <summary>
        /// Delete Segmentation<br/>
        /// Delete existing Segmentation.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdSegmentationsBySegmentationIdAsync(
            string databaseId,
            string segmentationId,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}