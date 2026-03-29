#nullable enable

namespace Recombee
{
    public partial interface ISegmentationsDefinitionClient
    {
        /// <summary>
        /// Create Property Based Segmentation<br/>
        /// Creates a Segmentation that splits the items into segments based on values of a particular item property.<br/>
        /// A segment is created for each unique value of the property.<br/>
        /// In case of `set` properties, a segment is created for each value in the set. Item belongs to all these segments.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdSegmentationsPropertyBasedBySegmentationIdAsync(
            string databaseId,
            string segmentationId,

            global::Recombee.CreatePropertyBasedSegmentationParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Property Based Segmentation<br/>
        /// Creates a Segmentation that splits the items into segments based on values of a particular item property.<br/>
        /// A segment is created for each unique value of the property.<br/>
        /// In case of `set` properties, a segment is created for each value in the set. Item belongs to all these segments.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="sourceType">
        /// What type of data should be segmented. Currently only `items` are supported.
        /// </param>
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
        global::System.Threading.Tasks.Task PutByDatabaseIdSegmentationsPropertyBasedBySegmentationIdAsync(
            string databaseId,
            string segmentationId,
            string sourceType,
            string propertyName,
            string? title = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}