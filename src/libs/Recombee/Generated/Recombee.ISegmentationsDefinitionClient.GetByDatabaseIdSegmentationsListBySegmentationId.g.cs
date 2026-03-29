#nullable enable

namespace Recombee
{
    public partial interface ISegmentationsDefinitionClient
    {
        /// <summary>
        /// Get Segmentation<br/>
        /// Get existing Segmentation.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.Segmentation> GetByDatabaseIdSegmentationsListBySegmentationIdAsync(
            string databaseId,
            string segmentationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}