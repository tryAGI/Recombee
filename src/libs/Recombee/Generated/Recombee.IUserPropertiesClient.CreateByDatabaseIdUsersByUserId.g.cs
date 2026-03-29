#nullable enable

namespace Recombee
{
    public partial interface IUserPropertiesClient
    {
        /// <summary>
        /// Set User Values<br/>
        /// Sets/updates (some) property values of the given user. The properties (columns) must be previously created by [Add user property](https://docs.recombee.com/api#add-user-property).
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="cascadeCreate"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateByDatabaseIdUsersByUserIdAsync(
            string databaseId,
            string userId,

            string request,
            bool? cascadeCreate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}