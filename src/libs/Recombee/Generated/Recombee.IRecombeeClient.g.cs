
#nullable enable

namespace Recombee
{
    /// <summary>
    /// This is the documentation for Recombee Recommendation API (https://docs.recombee.com/api)<br/>
    ///     <br/>
    /// Authentication details need to be provided with every request to Recombee API. Please refer to [Authentication (HMAC) document](https://docs.recombee.com/authentication) for more information.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IRecombeeClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Recombee.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ItemPropertiesClient ItemProperties { get; }

        /// <summary>
        /// 
        /// </summary>
        public ItemsClient Items { get; }

        /// <summary>
        /// 
        /// </summary>
        public MiscellaneousClient Miscellaneous { get; }

        /// <summary>
        /// 
        /// </summary>
        public RecommendationsClient Recommendations { get; }

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// 
        /// </summary>
        public SegmentationsDefinitionClient SegmentationsDefinition { get; }

        /// <summary>
        /// 
        /// </summary>
        public SeriesClient Series { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserItemInteractionsClient UserItemInteractions { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserPropertiesClient UserProperties { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

    }
}