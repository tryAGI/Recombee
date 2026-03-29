#nullable enable

namespace Recombee
{
    public partial interface IItemPropertiesClient
    {
        /// <summary>
        /// Add Item Property<br/>
        /// Adding an item property is somewhat equivalent to adding a column to the table of items. The items may be characterized by various properties of different types.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="propertyName"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdItemsPropertiesByPropertyNameAsync(
            string databaseId,
            string propertyName,
            global::Recombee.PutItemsPropertiesType type,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}