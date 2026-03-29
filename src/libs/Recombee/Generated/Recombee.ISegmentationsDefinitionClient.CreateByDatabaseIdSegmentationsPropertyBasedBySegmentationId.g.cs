#nullable enable

namespace Recombee
{
    public partial interface ISegmentationsDefinitionClient
    {
        /// <summary>
        /// Update Property Based Segmentation<br/>
        /// Updates a Property Based Segmentation
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdSegmentationsPropertyBasedBySegmentationIdAsync(
            string databaseId,
            string segmentationId,

            global::Recombee.UpdatePropertyBasedSegmentationParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Property Based Segmentation<br/>
        /// Updates a Property Based Segmentation
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="propertyName">
        /// Name of the property on which the Segmentation should be based
        /// </param>
        /// <param name="title">
        /// Human-readable name that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="description">
        /// Description that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdSegmentationsPropertyBasedBySegmentationIdAsync(
            string databaseId,
            string segmentationId,
            string? propertyName = default,
            string? title = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}