/*
order: 30
title: Search
slug: search

Example showing how to search items with personalized full-text search.
*/

namespace Recombee.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SearchItems()
    {
        //// Create an authenticated client
        using var client = GetAuthenticatedClient();
        var databaseId = GetDatabaseId();

        //// Search items with personalized full-text search
        var response = await client.Search.CreateByDatabaseIdSearchUsersByUserIdItemsAsync(
            databaseId: databaseId,
            userId: "test-user-1",
            searchQuery: "laptop",
            count: 5,
            cascadeCreate: true,
            returnProperties: true);

        //// The response contains a recommendation ID and ranked search results
        response.RecommId.Should().NotBeNullOrEmpty();
        response.Recomms.Should().NotBeNull();
    }
}
