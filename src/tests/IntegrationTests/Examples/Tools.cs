/*
order: 40
title: MEAI Tools
slug: meai-tools

Example showing how to use Recombee as MEAI AIFunction tools with any IChatClient.
*/

namespace Recombee.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_MeaiTools()
    {
        //// Create an authenticated client
        using var client = GetAuthenticatedClient();
        var databaseId = GetDatabaseId();

        //// Create AIFunction tools for use with any IChatClient
        var recommendTool = client.AsRecommendItemsTool(databaseId);
        var searchTool = client.AsSearchItemsTool(databaseId);
        var interactionTool = client.AsAddInteractionTool(databaseId);
        var listItemsTool = client.AsListItemsTool(databaseId);

        //// Verify tools are created with correct names
        recommendTool.Name.Should().Be("RecommendItems");
        searchTool.Name.Should().Be("SearchItems");
        interactionTool.Name.Should().Be("AddInteraction");
        listItemsTool.Name.Should().Be("ListItems");
    }
}
