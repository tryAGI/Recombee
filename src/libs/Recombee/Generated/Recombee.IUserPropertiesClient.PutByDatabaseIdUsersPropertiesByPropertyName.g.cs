#nullable enable

namespace Recombee
{
    public partial interface IUserPropertiesClient
    {
        /// <summary>
        /// Add User Property<br/>
        /// Adding a user property is somewhat equivalent to adding a column to the table of users. The users may be characterized by various properties of different types.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdUsersPropertiesByPropertyNameAsync(
            string databaseId,
            string propertyName,
            global::Recombee.PutUsersPropertiesType type,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}