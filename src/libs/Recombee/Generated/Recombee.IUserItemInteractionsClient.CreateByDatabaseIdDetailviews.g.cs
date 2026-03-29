#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// Add Detail View<br/>
        /// Adds a detail view of the given item made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdDetailviewsAsync(
            string databaseId,

            global::Recombee.DetailView request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Detail View<br/>
        /// Adds a detail view of the given item made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId">
        /// User who viewed the item
        /// </param>
        /// <param name="itemId">
        /// Viewed item
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the view as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="duration">
        /// Duration of the view
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="recommId">
        /// If this detail view is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
        /// <param name="autoPresented">
        /// Indicates whether the item was automatically presented to the user (e.g., in a swiping feed) or explicitly requested by the user (e.g., by clicking on a link). Defaults to `false`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdDetailviewsAsync(
            string databaseId,
            string userId,
            string itemId,
            global::Recombee.OneOf<string, double?>? timestamp = default,
            int? duration = default,
            bool? cascadeCreate = default,
            string? recommId = default,
            object? additionalData = default,
            bool? autoPresented = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}