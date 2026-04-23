#nullable enable

namespace Recombee
{
    public partial interface IRecommendationsClient
    {
        /// <summary>
        /// Recommend Next Item Segments<br/>
        /// Returns [Item Segments](https://docs.recombee.com/segmentations) to be shown as the next recommendations when a user scrolls (e.g., within a carousel or feed of Item Segments such as brands, artists, topics, or categories).<br/>
        /// The request requires the `recommId` of a base recommendation request and the number of Segments to return (`count`).<br/>
        /// The base request can be one of:<br/>
        ///   - [Recommend Item Segments to Item](https://docs.recombee.com/api#recommend-item-segments-to-item)<br/>
        ///   - [Recommend Item Segments to User](https://docs.recombee.com/api#recommend-item-segments-to-user)<br/>
        ///   - [Recommend Item Segments to Item Segment](https://docs.recombee.com/api#recommend-item-segments-to-item-segment)<br/>
        ///   - [Search Item Segments](https://docs.recombee.com/api#search-item-segments)<br/>
        /// All other parameters are inherited from the base request associated with the provided `recommId`.<br/>
        /// This endpoint can be called multiple times for a single `recommId`. Each call returns different Item Segments that have not been recommended in previous calls.<br/>
        /// The number of calls made so far is returned in the `numberNextRecommsCalls` field.<br/>
        /// Requests can be made up to 30 minutes after the base request or the most recent Recommend Next Item Segments call.<br/>
        /// For billing purposes, each call to this endpoint is counted as a separate recommendation request.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="recommId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync(
            string databaseId,
            string recommId,

            global::Recombee.RecommendNextItemSegmentsParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recommend Next Item Segments<br/>
        /// Returns [Item Segments](https://docs.recombee.com/segmentations) to be shown as the next recommendations when a user scrolls (e.g., within a carousel or feed of Item Segments such as brands, artists, topics, or categories).<br/>
        /// The request requires the `recommId` of a base recommendation request and the number of Segments to return (`count`).<br/>
        /// The base request can be one of:<br/>
        ///   - [Recommend Item Segments to Item](https://docs.recombee.com/api#recommend-item-segments-to-item)<br/>
        ///   - [Recommend Item Segments to User](https://docs.recombee.com/api#recommend-item-segments-to-user)<br/>
        ///   - [Recommend Item Segments to Item Segment](https://docs.recombee.com/api#recommend-item-segments-to-item-segment)<br/>
        ///   - [Search Item Segments](https://docs.recombee.com/api#search-item-segments)<br/>
        /// All other parameters are inherited from the base request associated with the provided `recommId`.<br/>
        /// This endpoint can be called multiple times for a single `recommId`. Each call returns different Item Segments that have not been recommended in previous calls.<br/>
        /// The number of calls made so far is returned in the `numberNextRecommsCalls` field.<br/>
        /// Requests can be made up to 30 minutes after the base request or the most recent Recommend Next Item Segments call.<br/>
        /// For billing purposes, each call to this endpoint is counted as a separate recommendation request.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="recommId"></param>
        /// <param name="count">
        /// Number of item segments to be recommended
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync(
            string databaseId,
            string recommId,
            int count,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}