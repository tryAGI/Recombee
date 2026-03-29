/*
order: 20
title: Interactions
slug: interactions

Example showing how to record user interactions (views, purchases, ratings).
*/

namespace Recombee.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_AddDetailView()
    {
        //// Create an authenticated client
        using var client = GetAuthenticatedClient();
        var databaseId = GetDatabaseId();

        //// Record a detail view interaction
        await client.UserItemInteractions.CreateByDatabaseIdDetailviewsAsync(
            databaseId: databaseId,
            userId: "test-user-1",
            itemId: "test-item-1",
            cascadeCreate: true);
    }

    [TestMethod]
    public async Task Example_AddPurchase()
    {
        //// Create an authenticated client
        using var client = GetAuthenticatedClient();
        var databaseId = GetDatabaseId();

        //// Record a purchase interaction
        await client.UserItemInteractions.CreateByDatabaseIdPurchasesAsync(
            databaseId: databaseId,
            userId: "test-user-1",
            itemId: "test-item-1",
            cascadeCreate: true,
            amount: 1.0,
            price: 29.99);
    }
}
