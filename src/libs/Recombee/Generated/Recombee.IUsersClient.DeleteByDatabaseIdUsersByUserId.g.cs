#nullable enable

namespace Recombee
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete User<br/>
        /// Deletes a user of the given *userId* from the database.<br/>
        /// If there are any purchases, ratings, bookmarks, cart additions or detail views made by the user present in the database, they will be deleted in cascade as well.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdUsersByUserIdAsync(
            string databaseId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}