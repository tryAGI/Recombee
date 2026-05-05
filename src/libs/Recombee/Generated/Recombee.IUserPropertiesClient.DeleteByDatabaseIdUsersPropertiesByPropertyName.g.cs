#nullable enable

namespace Recombee
{
    public partial interface IUserPropertiesClient
    {
        /// <summary>
        /// Delete User Property<br/>
        /// Deleting a user property is roughly equivalent to removing a column from the table of users.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdUsersPropertiesByPropertyNameAsync(
            string databaseId,
            string propertyName,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete User Property<br/>
        /// Deleting a user property is roughly equivalent to removing a column from the table of users.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.AutoSDKHttpResponse> DeleteByDatabaseIdUsersPropertiesByPropertyNameAsResponseAsync(
            string databaseId,
            string propertyName,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}