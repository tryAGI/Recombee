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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.ListSegmentationsResponse> GetByDatabaseIdSegmentationsListAsync(
            string databaseId,
            string sourceType,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Segmentations<br/>
        /// Return all existing items Segmentations.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="sourceType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.AutoSDKHttpResponse<global::Recombee.ListSegmentationsResponse>> GetByDatabaseIdSegmentationsListAsResponseAsync(
            string databaseId,
            string sourceType,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}