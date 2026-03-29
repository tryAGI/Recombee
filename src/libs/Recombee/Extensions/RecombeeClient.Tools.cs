#pragma warning disable CS3002 // Return type is not CLS-compliant
using Microsoft.Extensions.AI;

namespace Recombee;

/// <summary>
/// Extensions for using RecombeeClient as MEAI tools with any IChatClient.
/// </summary>
public static class RecombeeToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps personalized item recommendations for a user,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Recombee client to use.</param>
    /// <param name="databaseId">The Recombee database ID.</param>
    /// <param name="count">Number of items to recommend (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsRecommendItemsTool(
        this RecombeeClient client,
        string databaseId,
        int count = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string userId, string? scenario, CancellationToken cancellationToken) =>
            {
                var response = await client.Recommendations.CreateByDatabaseIdRecommsUsersByUserIdItemsAsync(
                    databaseId: databaseId,
                    userId: userId,
                    count: count,
                    scenario: scenario,
                    cascadeCreate: true,
                    returnProperties: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatRecommendationResponse(response);
            },
            name: "RecommendItems",
            description: "Gets personalized item recommendations for a user based on their past interactions (views, purchases, ratings). Returns a ranked list of recommended items with their properties.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps personalized item search,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Recombee client to use.</param>
    /// <param name="databaseId">The Recombee database ID.</param>
    /// <param name="count">Number of search results to return (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsSearchItemsTool(
        this RecombeeClient client,
        string databaseId,
        int count = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string userId, string searchQuery, CancellationToken cancellationToken) =>
            {
                var response = await client.Search.CreateByDatabaseIdSearchUsersByUserIdItemsAsync(
                    databaseId: databaseId,
                    userId: userId,
                    searchQuery: searchQuery,
                    count: count,
                    cascadeCreate: true,
                    returnProperties: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSearchResponse(response);
            },
            name: "SearchItems",
            description: "Searches items in the catalog with full-text personalized search. Results are ranked by relevance and personalized based on the user's past interactions.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that records a user interaction (detail view),
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Recombee client to use.</param>
    /// <param name="databaseId">The Recombee database ID.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsAddInteractionTool(
        this RecombeeClient client,
        string databaseId)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string userId, string itemId, string? interactionType, CancellationToken cancellationToken) =>
            {
                interactionType ??= "view";

                switch (interactionType.ToUpperInvariant())
                {
                    case "PURCHASE":
                        await client.UserItemInteractions.CreateByDatabaseIdPurchasesAsync(
                            databaseId: databaseId,
                            userId: userId,
                            itemId: itemId,
                            cascadeCreate: true,
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        return $"Recorded purchase: user '{userId}' purchased item '{itemId}'.";

                    case "RATING":
                        await client.UserItemInteractions.CreateByDatabaseIdRatingsAsync(
                            databaseId: databaseId,
                            userId: userId,
                            itemId: itemId,
                            rating1: 1.0,
                            cascadeCreate: true,
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        return $"Recorded rating: user '{userId}' rated item '{itemId}'.";

                    case "BOOKMARK":
                        await client.UserItemInteractions.CreateByDatabaseIdBookmarksAsync(
                            databaseId: databaseId,
                            userId: userId,
                            itemId: itemId,
                            cascadeCreate: true,
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        return $"Recorded bookmark: user '{userId}' bookmarked item '{itemId}'.";

                    case "CART":
                        await client.UserItemInteractions.CreateByDatabaseIdCartadditionsAsync(
                            databaseId: databaseId,
                            userId: userId,
                            itemId: itemId,
                            cascadeCreate: true,
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        return $"Recorded cart addition: user '{userId}' added item '{itemId}' to cart.";

                    default: // "VIEW" or any other value
                        await client.UserItemInteractions.CreateByDatabaseIdDetailviewsAsync(
                            databaseId: databaseId,
                            userId: userId,
                            itemId: itemId,
                            cascadeCreate: true,
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                        return $"Recorded view: user '{userId}' viewed item '{itemId}'.";
                }
            },
            name: "AddInteraction",
            description: "Records a user interaction with an item. Supported interaction types: 'view' (default), 'purchase', 'rating', 'bookmark', 'cart'. Users and items are auto-created if they don't exist.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists items in the catalog,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Recombee client to use.</param>
    /// <param name="databaseId">The Recombee database ID.</param>
    /// <param name="count">Number of items to return (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListItemsTool(
        this RecombeeClient client,
        string databaseId,
        int count = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? filter, CancellationToken cancellationToken) =>
            {
                var items = await client.Items.GetByDatabaseIdItemsListAsync(
                    databaseId: databaseId,
                    filter: filter,
                    count: count,
                    returnProperties: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatItemsList(items);
            },
            name: "ListItems",
            description: "Lists items in the Recombee catalog with optional ReQL filter expression. Returns item IDs and their property values.");
    }

    private static string FormatRecommendationResponse(RecommendationResponse response)
    {
        var parts = new List<string>
        {
            $"Recommendation ID: {response.RecommId}",
            $"Results ({response.Recomms.Count} items):"
        };

        foreach (var item in response.Recomms)
        {
            var entry = $"- {item.Id}";
            if (item.Values is not null)
            {
                entry += $" (properties: {item.Values})";
            }

            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }

    private static string FormatSearchResponse(SearchResponse response)
    {
        var parts = new List<string>
        {
            $"Search ID: {response.RecommId}",
            $"Results ({response.Recomms.Count} items):"
        };

        foreach (var item in response.Recomms)
        {
            var entry = $"- {item.Id}";
            if (item.Values is not null)
            {
                entry += $" (properties: {item.Values})";
            }

            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }

    private static string FormatItemsList(IList<Item> items)
    {
        var parts = new List<string>
        {
            $"Items ({items.Count}):"
        };

        foreach (var item in items)
        {
            var entry = $"- {item.ItemId}";
            if (item.AdditionalProperties is { Count: > 0 })
            {
                var props = string.Join(", ", item.AdditionalProperties
                    .Where(kv => kv.Key != "itemId")
                    .Select(kv => $"{kv.Key}: {kv.Value}"));
                if (!string.IsNullOrWhiteSpace(props))
                {
                    entry += $" ({props})";
                }
            }

            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }
}
