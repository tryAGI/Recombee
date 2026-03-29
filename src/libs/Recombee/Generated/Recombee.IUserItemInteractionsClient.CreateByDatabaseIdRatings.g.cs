#nullable enable

namespace Recombee
{
    public partial interface IUserItemInteractionsClient
    {
        /// <summary>
        /// Add Rating<br/>
        /// Adds a rating of the given item made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdRatingsAsync(
            string databaseId,

            global::Recombee.Rating request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Rating<br/>
        /// Adds a rating of the given item made by the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId">
        /// User who submitted the rating
        /// </param>
        /// <param name="itemId">
        /// Rated item
        /// </param>
        /// <param name="timestamp">
        /// UTC timestamp of the rating as ISO8601-1 pattern or UTC epoch time. The default value is the current time.
        /// </param>
        /// <param name="rating1">
        /// Rating rescaled to interval [-1.0,1.0], where -1.0 means the worst rating possible, 0.0 means neutral, and 1.0 means absolutely positive rating. For example, in the case of 5-star evaluations, rating = (numStars-3)/2 formula may be used for the conversion.
        /// </param>
        /// <param name="cascadeCreate">
        /// Sets whether the given user/item should be created if not present in the database.
        /// </param>
        /// <param name="recommId">
        /// If this rating is based on a recommendation request, `recommId` is the id of the clicked recommendation.
        /// </param>
        /// <param name="additionalData">
        /// A dictionary of additional data for the interaction.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdRatingsAsync(
            string databaseId,
            string userId,
            string itemId,
            double rating1,
            global::Recombee.OneOf<string, double?>? timestamp = default,
            bool? cascadeCreate = default,
            string? recommId = default,
            object? additionalData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}