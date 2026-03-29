# Microsoft.Extensions.AI Integration

The Recombee SDK provides `AIFunction` tools that can be used with any `IChatClient` via [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/ai-extensions).

## Available Tools

| Tool | Description |
|------|-------------|
| `AsRecommendItemsTool()` | Get personalized item recommendations for a user |
| `AsSearchItemsTool()` | Search items with personalized full-text search |
| `AsAddInteractionTool()` | Record user interactions (view, purchase, rating, bookmark, cart) |
| `AsListItemsTool()` | List items in the catalog with optional ReQL filter |

## Usage

```csharp
using Recombee;
using Microsoft.Extensions.AI;

// Create Recombee client
var client = new RecombeeClient(
    apiKey: privateToken,
    baseUri: new Uri("https://rapi-us-west.recombee.com"));

var databaseId = "my-database";

// Create tools
var tools = new[]
{
    client.AsRecommendItemsTool(databaseId),
    client.AsSearchItemsTool(databaseId),
    client.AsAddInteractionTool(databaseId),
    client.AsListItemsTool(databaseId),
};

// Use with any IChatClient
var chatOptions = new ChatOptions { Tools = [.. tools] };
```
