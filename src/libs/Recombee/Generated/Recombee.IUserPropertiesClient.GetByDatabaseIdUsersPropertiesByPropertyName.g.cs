#nullable enable

namespace Recombee
{
    public partial interface IUserPropertiesClient
    {
        /// <summary>
        /// Get User Property Info<br/>
        /// Gets information about specified user property.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.PropertyInfo> GetByDatabaseIdUsersPropertiesByPropertyNameAsync(
            string databaseId,
            string propertyName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}