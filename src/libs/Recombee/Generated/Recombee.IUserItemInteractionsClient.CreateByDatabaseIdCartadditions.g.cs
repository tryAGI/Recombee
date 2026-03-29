#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// Add Cart Addition<br/>
        /// Adds a cart addition of the given item made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdCartadditionsAsync(
            string databaseId,

            global::Recombee.CartAddition request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Cart Addition<br/>
        /// Adds a cart addition of the given item made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId">
        /// User who added the item to the cart
        /// </param>
        /// <param name="itemId">
        /// Item added to the cart
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the cart addition as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="amount">
        /// Amount (number) added to cart. The default is 1. For example, if `user-x` adds two `item-y` during a single order (session...), the `amount` should equal 2.
        /// </param>
        /// <param name="price">
        /// Price of the added item. If `amount` is greater than 1, the sum of prices of all the items should be given.
        /// </param>
        /// <param name="recommId">
        /// If this cart addition is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdCartadditionsAsync(
            string databaseId,
            string userId,
            string itemId,
            global::Recombee.OneOf<string, double?>? timestamp = default,
            bool? cascadeCreate = default,
            double? amount = default,
            double? price = default,
            string? recommId = default,
            object? additionalData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}