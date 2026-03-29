# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Recombee SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Recombee's personalized item recommendations, search, interaction recording, and catalog browsing.

## Installation

```bash
dotnet add package Recombee
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsRecommendItemsTool(databaseId)` | `RecommendItems` | Get personalized item recommendations for a user |
| `AsSearchItemsTool(databaseId)` | `SearchItems` | Search items with personalized full-text search |
| `AsAddInteractionTool(databaseId)` | `AddInteraction` | Record user interactions (view, purchase, rating, bookmark, cart) |
| `AsListItemsTool(databaseId)` | `ListItems` | List items in the catalog with optional filter |

## Usage

```csharp
using Recombee;
using Microsoft.Extensions.AI;

var recombeeClient = new RecombeeClient(
    apiKey: Environment.GetEnvironmentVariable("RECOMBEE_API_KEY")!,
    baseUri: new Uri("https://rapi-us-west.recombee.com"));

var databaseId = Environment.GetEnvironmentVariable("RECOMBEE_DATABASE_ID")!;

var options = new ChatOptions
{
    Tools =
    [
        recombeeClient.AsRecommendItemsTool(databaseId),
        recombeeClient.AsSearchItemsTool(databaseId),
        recombeeClient.AsAddInteractionTool(databaseId),
        recombeeClient.AsListItemsTool(databaseId),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Get personalized recommendations for user 'user-123' and search for 'wireless headphones'."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
