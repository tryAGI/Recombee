#nullable enable

namespace Recombee
{
    public partial interface ISegmentationsDefinitionClient
    {
        /// <summary>
        /// Update Manual ReQL Segmentation<br/>
        /// Update an existing Segmentation.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdSegmentationsManualReqlBySegmentationIdAsync(
            string databaseId,
            string segmentationId,

            global::Recombee.UpdateManualReQLSegmentationParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Manual ReQL Segmentation<br/>
        /// Update an existing Segmentation.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="title">
        /// Human-readable name that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="description">
        /// Description that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdSegmentationsManualReqlBySegmentationIdAsync(
            string databaseId,
            string segmentationId,
            string? title = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}