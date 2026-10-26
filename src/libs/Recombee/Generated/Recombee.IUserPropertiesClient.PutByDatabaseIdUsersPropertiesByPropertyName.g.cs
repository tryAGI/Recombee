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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdUsersPropertiesByPropertyNameAsync(
            string databaseId,
            string propertyName,

            global::Recombee.AddUserPropertyParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add User Property<br/>
        /// Adding a user property is somewhat equivalent to adding a column to the table of users. The users may be characterized by various properties of different types.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.AutoSDKHttpResponse> PutByDatabaseIdUsersPropertiesByPropertyNameAsResponseAsync(
            string databaseId,
            string propertyName,

            global::Recombee.AddUserPropertyParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add User Property<br/>
        /// Adding a user property is somewhat equivalent to adding a column to the table of users. The users may be characterized by various properties of different types.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="type">
        /// Value type of the user property to be created. One of: `int`, `double`, `string`, `boolean`, `timestamp`, `set`.<br/>
        /// * `int` - Signed integer number.<br/>
        /// * `double` - Floating point number. It uses 64-bit base-2 format (IEEE 754 standard).<br/>
        /// * `string` - UTF-8 string.<br/>
        /// * `boolean` - *true* / *false*<br/>
        /// * `timestamp` - Value representing date and time. ISO8601-1 pattern (string) or UTC epoch time (number).<br/>
        /// * `set` - Set of strings.
        /// </param>
        /// <param name="role"></param>
        /// <param name="metadata">
        /// List of [metadata](https://docs.recombee.com/api/property_roles_metadata#metadata) entries to assign to the property.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdUsersPropertiesByPropertyNameAsync(
            string databaseId,
            string propertyName,
            global::Recombee.AddUserPropertyParametersType type,
            global::Recombee.PropertyRole? role = default,
            global::System.Collections.Generic.IList<global::Recombee.PropertyMetadata>? metadata = default,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}