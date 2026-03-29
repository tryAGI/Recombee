#nullable enable

namespace Recombee
{
    public partial interface ISegmentationsDefinitionClient
    {
        /// <summary>
        /// List Segmentations<br/>
        /// Return all existing items Segmentations.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="sourceType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.ListSegmentationsResponse> GetByDatabaseIdSegmentationsListAsync(
            string databaseId,
            string sourceType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}