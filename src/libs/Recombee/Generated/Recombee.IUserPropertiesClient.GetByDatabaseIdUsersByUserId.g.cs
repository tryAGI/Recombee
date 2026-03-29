#nullable enable

namespace Recombee
{
    public partial interface IUserPropertiesClient
    {
        /// <summary>
        /// Get User Values<br/>
        /// Gets all the current property values of the given user.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetByDatabaseIdUsersByUserIdAsync(
            string databaseId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}