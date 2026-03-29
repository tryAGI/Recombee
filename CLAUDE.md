# CLAUDE.md -- Recombee SDK

## Overview

Auto-generated C# SDK for [Recombee](https://recombee.com/) -- AI-powered real-time recommendation engine for personalized content, products, and search.
OpenAPI spec from `https://docs.recombee.com/openapi.yaml` (3.0.0, v4.1.0).

## Build & Test

```bash
dotnet build Recombee.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

HMAC-SHA1 signature authentication. Constructor takes a private token (used as HMAC key):

```csharp
var client = new RecombeeClient(
    apiKey: privateToken,
    baseUri: new Uri("https://rapi-us-west.recombee.com"));
```

Environment variables for tests:
- `RECOMBEE_API_KEY` -- Private token for HMAC signing
- `RECOMBEE_DATABASE_ID` -- Database ID (used as path parameter in every request)
- `RECOMBEE_REGION` -- API region (default: `us-west`; options: `us-west`, `ca-east`, `eu-west`, `ap-se`)

## Key Files

- `src/libs/Recombee/openapi.yaml` -- Downloaded and patched OpenAPI 3 spec
- `src/libs/Recombee/generate.sh` -- Downloads spec, fixes servers/auth, runs autosdk
- `src/libs/Recombee/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Recombee/Extensions/RecombeeClient.PrepareRequest.cs` -- HMAC-SHA1 auth hook (computes hmac_timestamp + hmac_sign query params)
- `src/libs/Recombee/Extensions/RecombeeClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new RecombeeClient(apiKey, baseUri: new Uri("https://rapi-us-west.recombee.com"));
var dbId = "my-database";

// Recommendations
client.Recommendations.CreateByDatabaseIdRecommsUsersByUserIdItemsAsync(dbId, userId, ...)
client.Recommendations.CreateByDatabaseIdRecommsItemsByItemIdItemsAsync(dbId, itemId, ...)

// Search
client.Search.CreateByDatabaseIdSearchUsersByUserIdItemsAsync(dbId, userId, ...)

// Items
client.Items.PutByDatabaseIdItemsByItemIdAsync(dbId, itemId)
client.Items.GetByDatabaseIdItemsListAsync(dbId, ...)

// Users
client.Users.PutByDatabaseIdUsersByUserIdAsync(dbId, userId)

// Interactions
client.UserItemInteractions.CreateByDatabaseIdDetailviewsAsync(dbId, ...)
client.UserItemInteractions.CreateByDatabaseIdPurchasesAsync(dbId, ...)
client.UserItemInteractions.CreateByDatabaseIdRatingsAsync(dbId, ...)

// Batch
client.Miscellaneous.CreateByDatabaseIdBatchAsync(dbId, ...)
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsRecommendItemsTool(databaseId)` -- Get personalized item recommendations for a user
- `AsSearchItemsTool(databaseId)` -- Search items with personalized full-text search
- `AsAddInteractionTool(databaseId)` -- Record user interaction (view/purchase/rating/bookmark/cart)
- `AsListItemsTool(databaseId)` -- List items in the catalog with optional filter

## Auth Notes

- Recombee uses HMAC-SHA1 query parameter authentication (not header-based)
- `PrepareRequest` hook intercepts every request to compute and append `hmac_timestamp` and `hmac_sign` query parameters
- The `apiKey` constructor parameter is the Recombee private token used as the HMAC-SHA1 key
- Signatures have a 30-second lifetime; server clocks must be NTP-synchronized
- `--security-scheme Http:Header:Bearer` is used only for constructor generation; the Authorization header is removed at runtime

## Spec Notes

- Base URL is region-dependent (e.g., `rapi-us-west.recombee.com`, `rapi-eu-west.recombee.com`)
- Every endpoint path starts with `/{databaseId}/`
- `generate.sh` patches spec with proper server URL and bearer security scheme
- 405 generated files covering items, users, interactions, recommendations, search, series, segmentations, batch
