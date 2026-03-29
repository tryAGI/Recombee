/*
order: 50
title: Items
slug: items

Example showing how to manage items in the catalog.
*/

namespace Recombee.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_AddItem()
    {
        //// Create an authenticated client
        using var client = GetAuthenticatedClient();
        var databaseId = GetDatabaseId();

        //// Add an item to the catalog
        await client.Items.PutByDatabaseIdItemsByItemIdAsync(
            databaseId: databaseId,
            itemId: "test-item-sdk-1");
    }

    [TestMethod]
    public async Task Example_ListItems()
    {
        //// Create an authenticated client
        using var client = GetAuthenticatedClient();
        var databaseId = GetDatabaseId();

        //// List items from the catalog
        var items = await client.Items.GetByDatabaseIdItemsListAsync(
            databaseId: databaseId,
            count: 10,
            returnProperties: true);

        //// The response contains a list of items
        items.Should().NotBeNull();
    }
}
