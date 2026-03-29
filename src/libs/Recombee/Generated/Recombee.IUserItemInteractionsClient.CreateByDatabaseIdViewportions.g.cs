#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// Set View Portion<br/>
        /// Sets viewed portion of an item (for example a video or article) by a user (at a session).<br/>
        /// If you send a new request with the same (`userId`, `itemId`, `sessionId`), the portion gets updated.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdViewportionsAsync(
            string databaseId,

            global::Recombee.ViewPortion request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set View Portion<br/>
        /// Sets viewed portion of an item (for example a video or article) by a user (at a session).<br/>
        /// If you send a new request with the same (`userId`, `itemId`, `sessionId`), the portion gets updated.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId">
        /// User who viewed a portion of the item
        /// </param>
        /// <param name="itemId">
        /// Viewed item
        /// </param>
        /// <param name="portion">
        /// Viewed portion of the item (number between 0.0 (viewed nothing) and 1.0 (viewed full item) ). It should be the actual viewed part of the item, no matter the seeking. For example, if the user seeked immediately to half of the item and then viewed 10% of the item, the `portion` should still be `0.1`.
        /// </param>
        /// <param name="sessionId">
        /// ID of the session in which the user viewed the item. Default is `null` (`None`, `nil`, `NULL` etc., depending on the language).
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the view portion as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="recommId">
        /// If this view portion is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
        /// <param name="autoPresented">
        /// Indicates whether the item was automatically presented to the user (e.g., in a swiping feed) or explicitly requested by the user (e.g., by clicking on a link). Defaults to `false`.
        /// </param>
        /// <param name="timeSpent">
        /// The duration (in seconds) that the user viewed the item. In update requests, this value may only increase and is required only if it has changed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdViewportionsAsync(
            string databaseId,
            string userId,
            string itemId,
            double portion,
            string? sessionId = default,
            global::Recombee.OneOf<string, double?>? timestamp = default,
            bool? cascadeCreate = default,
            string? recommId = default,
            object? additionalData = default,
            bool? autoPresented = default,
            double? timeSpent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}