#nullable enable

namespace Recombee
{
    public partial interface IUserPropertiesClient
    {
        /// <summary>
        /// List User Properties<br/>
        /// Gets the list of all the user properties in your database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.PropertyInfo>> GetByDatabaseIdUsersPropertiesListAsync(
            string databaseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}