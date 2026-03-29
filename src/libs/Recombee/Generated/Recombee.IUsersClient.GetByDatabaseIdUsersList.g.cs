#nullable enable

namespace Recombee
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List Users<br/>
        /// Gets a list of IDs of users currently present in the catalog.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="filter"></param>
        /// <param name="count"></param>
        /// <param name="offset"></param>
        /// <param name="returnProperties"></param>
        /// <param name="includedProperties"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.User>> GetByDatabaseIdUsersListAsync(
            string databaseId,
            string? filter = default,
            int? count = default,
            int? offset = default,
            bool? returnProperties = default,
            global::System.Collections.Generic.IList<string>? includedProperties = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}