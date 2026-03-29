#nullable enable

namespace Recombee
{
    public partial interface IRecommendationsClient
    {
        /// <summary>
        /// Recommend Next Items<br/>
        /// Returns items that shall be shown to a user as next recommendations when the user e.g. scrolls the page down (*infinite scroll*) or goes to the next page.<br/>
        /// It accepts `recommId` of a base recommendation request (e.g., request from the first page) and the number of items that shall be returned (`count`).<br/>
        /// The base request can be one of:<br/>
        ///   - [Recommend Items to Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
        ///   - [Recommend Items to User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
        ///   - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
        ///   - [Search Items](https://docs.recombee.com/api#search-items)<br/>
        /// All the other parameters are inherited from the base request.<br/>
        /// *Recommend next items* can be called many times for a single `recommId` and each call returns different (previously not recommended) items.<br/>
        /// The number of *Recommend next items* calls performed so far is returned in the `numberNextRecommsCalls` field.<br/>
        /// *Recommend next items* can be requested up to 30 minutes after the base request or a previous *Recommend next items* call.<br/>
        /// For billing purposes, each call to *Recommend next items* is counted as a separate recommendation request.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="recommId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsNextItemsByRecommIdAsync(
            string databaseId,
            string recommId,

            global::Recombee.RecommendNextItemsParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recommend Next Items<br/>
        /// Returns items that shall be shown to a user as next recommendations when the user e.g. scrolls the page down (*infinite scroll*) or goes to the next page.<br/>
        /// It accepts `recommId` of a base recommendation request (e.g., request from the first page) and the number of items that shall be returned (`count`).<br/>
        /// The base request can be one of:<br/>
        ///   - [Recommend Items to Item](https://docs.recombee.com/api#recommend-items-to-item)<br/>
        ///   - [Recommend Items to User](https://docs.recombee.com/api#recommend-items-to-user)<br/>
        ///   - [Recommend Items to Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment)<br/>
        ///   - [Search Items](https://docs.recombee.com/api#search-items)<br/>
        /// All the other parameters are inherited from the base request.<br/>
        /// *Recommend next items* can be called many times for a single `recommId` and each call returns different (previously not recommended) items.<br/>
        /// The number of *Recommend next items* calls performed so far is returned in the `numberNextRecommsCalls` field.<br/>
        /// *Recommend next items* can be requested up to 30 minutes after the base request or a previous *Recommend next items* call.<br/>
        /// For billing purposes, each call to *Recommend next items* is counted as a separate recommendation request.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="recommId"></param>
        /// <param name="count">
        /// Number of items to be recommended
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsNextItemsByRecommIdAsync(
            string databaseId,
            string recommId,
            int count,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}