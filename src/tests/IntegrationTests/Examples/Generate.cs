/*
order: 10
title: Recommendations
slug: recommendations

Example showing how to get personalized item recommendations for a user.
*/

namespace Recombee.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_RecommendItemsToUser()
    {
        //// Create an authenticated client
        using var client = GetAuthenticatedClient();
        var databaseId = GetDatabaseId();

        //// Get personalized recommendations for a user
        var response = await client.Recommendations.CreateByDatabaseIdRecommsUsersByUserIdItemsAsync(
            databaseId: databaseId,
            userId: "test-user-1",
            count: 5,
            cascadeCreate: true,
            returnProperties: true);

        //// The response contains a recommendation ID and list of recommended items
        response.RecommId.Should().NotBeNullOrEmpty();
        response.Recomms.Should().NotBeNull();
    }
}
