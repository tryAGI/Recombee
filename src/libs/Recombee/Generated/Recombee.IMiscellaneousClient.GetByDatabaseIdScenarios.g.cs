#nullable enable

namespace Recombee
{
    public partial interface IMiscellaneousClient
    {
        /// <summary>
        /// List Scenarios<br/>
        /// Get all [Scenarios](https://docs.recombee.com/scenarios) of the given database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Recombee.Scenario>> GetByDatabaseIdScenariosAsync(
            string databaseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}