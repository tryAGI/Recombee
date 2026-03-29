namespace Recombee.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static RecombeeClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("RECOMBEE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("RECOMBEE_API_KEY environment variable is not found.");

        // Region-based base URL (e.g., rapi-us-west.recombee.com, rapi-eu-west.recombee.com)
        var region =
            Environment.GetEnvironmentVariable("RECOMBEE_REGION") is { Length: > 0 } regionValue
                ? regionValue
                : "us-west";

        var baseUri = new Uri($"https://rapi-{region}.recombee.com");

        var client = new RecombeeClient(
            apiKey: apiKey,
            baseUri: baseUri);

        return client;
    }

    private static string GetDatabaseId()
    {
        return Environment.GetEnvironmentVariable("RECOMBEE_DATABASE_ID") is { Length: > 0 } dbId
            ? dbId
            : throw new AssertInconclusiveException("RECOMBEE_DATABASE_ID environment variable is not found.");
    }
}
