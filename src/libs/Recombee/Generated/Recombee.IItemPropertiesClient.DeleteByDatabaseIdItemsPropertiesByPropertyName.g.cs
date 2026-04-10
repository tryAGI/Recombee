#nullable enable

namespace Recombee
{
    public partial interface IItemPropertiesClient
    {
        /// <summary>
        /// Delete Item Property<br/>
        /// Deleting an item property is roughly equivalent to removing a column from the table of items.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteByDatabaseIdItemsPropertiesByPropertyNameAsync(
            string databaseId,
            string propertyName,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}