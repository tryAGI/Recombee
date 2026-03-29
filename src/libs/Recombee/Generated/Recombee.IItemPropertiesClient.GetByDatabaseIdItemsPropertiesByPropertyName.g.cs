#nullable enable

namespace Recombee
{
    public partial interface IItemPropertiesClient
    {
        /// <summary>
        /// Get Item Property Info<br/>
        /// Gets information about specified item property.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Recombee.PropertyInfo> GetByDatabaseIdItemsPropertiesByPropertyNameAsync(
            string databaseId,
            string propertyName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}