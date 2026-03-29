#nullable enable

namespace Recombee
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Merge Users<br/>
        /// Merges interactions (purchases, ratings, bookmarks, detail views ...) of two different users under a single user ID. This is especially useful for online e-commerce applications working with anonymous users identified by unique tokens such as the session ID. In such applications, it may often happen that a user owns a persistent account, yet accesses the system anonymously while, e.g., putting items into a shopping cart. At some point in time, such as when the user wishes to confirm the purchase, (s)he logs into the system using his/her username and password. The interactions made under anonymous session ID then become connected with the persistent account, and merging these two becomes desirable.<br/>
        /// Merging happens between two users referred to as the *target* and the *source*. After the merge, all the interactions of the source user are attributed to the target user, and the source user is **deleted**.<br/>
        /// By default, the *Merge Users* request is only available from server-side integrations for security reasons, to prevent potential abuse.<br/>
        /// If you need to call this request from a client-side environment (such as a web or mobile app), please contact our support and request access to enable this feature for your database.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="targetUserId"></param>
        /// <param name="sourceUserId"></param>
        /// <param name="cascadeCreate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        global::System.Threading.Tasks.Task PutByDatabaseIdUsersByTargetUserIdMergeBySourceUserIdAsync(
            string databaseId,
            string targetUserId,
            string sourceUserId,
            bool? cascadeCreate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}