#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// Add Bookmark<br/>
        /// Adds a bookmark of the given item made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdBookmarksAsync(
            string databaseId,

            global::Recombee.Bookmark request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Bookmark<br/>
        /// Adds a bookmark of the given item made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId">
        /// User who bookmarked the item
        /// </param>
        /// <param name="itemId">
        /// Bookmarked item
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the bookmark as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="recommId">
        /// If this bookmark is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdBookmarksAsync(
            string databaseId,
            string userId,
            string itemId,
            global::Recombee.OneOf<string, double?>? timestamp = default,
            bool? cascadeCreate = default,
            string? recommId = default,
            object? additionalData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}