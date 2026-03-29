#nullable enable

namespace Recombee
{
    public partial interface IMiscellaneousClient
    {
        /// <summary>
        /// Reset Database<br/>
        /// Completely erases all your data, including items, item properties, series, user database, purchases, ratings, detail views, and bookmarks. Make sure the request is never executed in the production environment! Resetting your database is irreversible.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdAsync(
            string databaseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}