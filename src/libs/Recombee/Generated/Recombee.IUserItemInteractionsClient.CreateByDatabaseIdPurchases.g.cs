#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// Add Purchase<br/>
        /// Adds a purchase of the given item made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdPurchasesAsync(
            string databaseId,

            global::Recombee.Purchase request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Purchase<br/>
        /// Adds a purchase of the given item made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId">
        /// User who purchased the item
        /// </param>
        /// <param name="itemId">
        /// Purchased item
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the purchase as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="amount">
        /// Amount (number) of purchased items. The default is 1. For example, if `user-x` purchases two `item-y` during a single order (session...), the `amount` should equal 2.
        /// </param>
        /// <param name="price">
        /// Price paid by the user for the item. If `amount` is greater than 1, the sum of prices of all the items should be given.
        /// </param>
        /// <param name="profit">
        /// Your profit from the purchased item. The profit is natural in the e-commerce domain (for example, if `user-x` purchases `item-y` for $100 and the gross margin is 30 %, then the profit is $30) but is also applicable in other domains (for example, at a news company it may be income from a displayed advertisement on article page). If `amount` is greater than 1, the sum of profit of all the items should be given.
        /// </param>
        /// <param name="recommId">
        /// If this purchase is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdPurchasesAsync(
            string databaseId,
            string userId,
            string itemId,
            global::Recombee.OneOf<string, double?>? timestamp = default,
            bool? cascadeCreate = default,
            double? amount = default,
            double? price = default,
            double? profit = default,
            string? recommId = default,
            object? additionalData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}