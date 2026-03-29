#nullable enable

using System.Security.Cryptography;
using System.Text;

namespace Recombee;

public partial class RecombeeClient
{
    private string? _privateToken;

    /// <summary>
    /// After Bearer auth is set, capture the private token for HMAC signing.
    /// The token is stored and used to compute HMAC-SHA1 signatures on each request.
    /// </summary>
    partial void Authorized(System.Net.Http.HttpClient client)
    {
        _privateToken = Authorizations.FirstOrDefault()?.Value;

        // Remove the Authorization header — Recombee doesn't use Bearer auth
        client.DefaultRequestHeaders.Authorization = null;
    }

    /// <summary>
    /// Intercept every request to add HMAC-SHA1 authentication query parameters.
    /// Recombee authenticates via hmac_timestamp and hmac_sign query parameters
    /// computed from the request URI path + query string.
    /// </summary>
    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request)
    {
        if (_privateToken is not { Length: > 0 } || request.RequestUri is null)
        {
            return;
        }

        // Get the current UTC Unix timestamp
        var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        // Build the URI path + query string (without protocol and host)
        // e.g., /mydb/recomms/users/user1/items/?count=5
        var pathAndQuery = request.RequestUri.PathAndQuery;

        // Append hmac_timestamp to the path+query for signing
        var separator = pathAndQuery.Contains('?', StringComparison.Ordinal) ? "&" : "?";
        var signatureInput = $"{pathAndQuery}{separator}hmac_timestamp={timestamp}";

        // Compute HMAC-SHA1 signature (required by Recombee API)
#pragma warning disable CA5350 // HMAC-SHA1 is required by Recombee API authentication
        using var hmac = new HMACSHA1(Encoding.UTF8.GetBytes(_privateToken));
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(signatureInput));
        var signature = Convert.ToHexStringLower(hash);
#pragma warning restore CA5350

        // Build the new URI with hmac_timestamp and hmac_sign
        var newUri = $"{signatureInput}&hmac_sign={signature}";

        // Reconstruct full URI
        var baseUri = $"{request.RequestUri.Scheme}://{request.RequestUri.Host}";
        if (!request.RequestUri.IsDefaultPort)
        {
            baseUri += $":{request.RequestUri.Port}";
        }
        request.RequestUri = new Uri($"{baseUri}{newUri}", UriKind.Absolute);
    }
}
