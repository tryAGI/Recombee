
#nullable enable

namespace Recombee
{
    public partial class RecommendationsClient
    {
        partial void PrepareCreateByDatabaseIdRecommsUsersByUserIdItemsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string databaseId,
            ref string userId,
            global::Recombee.RecommendItemsToUserParameters request);
        partial void PrepareCreateByDatabaseIdRecommsUsersByUserIdItemsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string databaseId,
            string userId,
            global::Recombee.RecommendItemsToUserParameters request);
        partial void ProcessCreateByDatabaseIdRecommsUsersByUserIdItemsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateByDatabaseIdRecommsUsersByUserIdItemsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Recommend Items to User<br/>
        /// Based on the user's past interactions (purchases, ratings, etc.) with the items, recommends top-N items that are most likely to be of high value for the given user.<br/>
        /// The most typical use cases are recommendations on the homepage, in some "Picked just for you" section, or in email.<br/>
        /// The returned items are sorted by relevance (the first item being the most relevant).<br/>
        /// Besides the recommended items, also a unique `recommId` is returned in the response. It can be used to:<br/>
        /// - Let Recombee know that this recommendation was successful (e.g., user clicked one of the recommended items). See [Reported metrics](https://docs.recombee.com/admin_ui#reported-metrics).<br/>
        /// - Get subsequent recommended items when the user scrolls down (*infinite scroll*) or goes to the next page. See [Recommend Next Items](https://docs.recombee.com/api#recommend-next-items).<br/>
        /// It is also possible to use POST HTTP method (for example in the case of a very long ReQL filter) - query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsUsersByUserIdItemsAsync(
            string databaseId,
            string userId,

            global::Recombee.RecommendItemsToUserParameters request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateByDatabaseIdRecommsUsersByUserIdItemsArguments(
                httpClient: HttpClient,
                databaseId: ref databaseId,
                userId: ref userId,
                request: request);

            var __pathBuilder = new global::Recombee.PathBuilder(
                path: $"/{databaseId}/recomms/users/{userId}/items/",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateByDatabaseIdRecommsUsersByUserIdItemsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                databaseId: databaseId,
                userId: userId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateByDatabaseIdRecommsUsersByUserIdItemsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Recombee.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Recombee.ApiException(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateByDatabaseIdRecommsUsersByUserIdItemsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Recombee.RecommendationResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Recombee.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Recombee.RecommendationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Recombee.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Recommend Items to User<br/>
        /// Based on the user's past interactions (purchases, ratings, etc.) with the items, recommends top-N items that are most likely to be of high value for the given user.<br/>
        /// The most typical use cases are recommendations on the homepage, in some "Picked just for you" section, or in email.<br/>
        /// The returned items are sorted by relevance (the first item being the most relevant).<br/>
        /// Besides the recommended items, also a unique `recommId` is returned in the response. It can be used to:<br/>
        /// - Let Recombee know that this recommendation was successful (e.g., user clicked one of the recommended items). See [Reported metrics](https://docs.recombee.com/admin_ui#reported-metrics).<br/>
        /// - Get subsequent recommended items when the user scrolls down (*infinite scroll*) or goes to the next page. See [Recommend Next Items](https://docs.recombee.com/api#recommend-next-items).<br/>
        /// It is also possible to use POST HTTP method (for example in the case of a very long ReQL filter) - query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="userId"></param>
        /// <param name="count">
        /// Number of items to be recommended (N for the top-N recommendation).
        /// </param>
        /// <param name="scenario">
        /// Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">
        /// If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that user, as the user will be already known to the system.
        /// </param>
        /// <param name="returnProperties">
        /// With `returnProperties=true`, property values of the recommended items are returned along with their IDs in a JSON dictionary. The acquired property values can be used to easily display the recommended items to the user. <br/>
        /// Example response:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "ce52ada4-e4d9-4885-943c-407db2dee837",<br/>
        ///     "recomms": <br/>
        ///       [<br/>
        ///         {<br/>
        ///           "id": "tv-178",<br/>
        ///           "values": {<br/>
        ///             "description": "4K TV with 3D feature",<br/>
        ///             "categories":   ["Electronics", "Televisions"],<br/>
        ///             "price": 342,<br/>
        ///             "url": "myshop.com/tv-178"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "id": "mixer-42",<br/>
        ///           "values": {<br/>
        ///             "description": "Stainless Steel Mixer",<br/>
        ///             "categories":   ["Home &amp; Kitchen"],<br/>
        ///             "price": 39,<br/>
        ///             "url": "myshop.com/mixer-42"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///      "numberNextRecommsCalls": 0<br/>
        ///   }<br/>
        /// ```
        /// </param>
        /// <param name="includedProperties">
        /// Allows specifying which properties should be returned when `returnProperties=true` is set. The properties are given as a comma-separated list.<br/>
        /// Example response for `includedProperties=description,price`:<br/>
        /// ```json<br/>
        ///   {<br/>
        ///     "recommId": "a86ee8d5-cd8e-46d1-886c-8b3771d0520b",<br/>
        ///     "recomms":<br/>
        ///       [<br/>
        ///         {<br/>
        ///           "id": "tv-178",<br/>
        ///           "values": {<br/>
        ///             "description": "4K TV with 3D feature",<br/>
        ///             "price": 342<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "id": "mixer-42",<br/>
        ///           "values": {<br/>
        ///             "description": "Stainless Steel Mixer",<br/>
        ///             "price": 39<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     "numberNextRecommsCalls": 0<br/>
        ///   }<br/>
        /// ```
        /// </param>
        /// <param name="filter">
        /// Boolean-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to filter recommended items based on the values of their attributes.<br/>
        /// Filters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="booster">
        /// Number-returning [ReQL](https://docs.recombee.com/reql) expression, which allows you to boost the recommendation rate of some items based on the values of their attributes.<br/>
        /// Boosters can also be assigned to a [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com).
        /// </param>
        /// <param name="logic"></param>
        /// <param name="reqlExpressions">
        /// A dictionary of [ReQL](https://docs.recombee.com/reql) expressions that will be executed for each recommended item.<br/>
        /// This can be used to compute additional properties of the recommended items that are not stored in the database.<br/>
        /// The keys are the names of the expressions, and the values are the actual ReQL expressions.<br/>
        /// Example request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "reqlExpressions": {<br/>
        ///     "isInUsersCity": "context_user[\"city\"] in 'cities'",<br/>
        ///     "distanceToUser": "earth_distance('location', context_user[\"location\"])"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Example response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "recommId": "ce52ada4-e4d9-4885-943c-407db2dee837",<br/>
        ///   "recomms": <br/>
        ///     [<br/>
        ///       {<br/>
        ///         "id": "restaurant-178",<br/>
        ///         "reqlEvaluations": {<br/>
        ///           "isInUsersCity": true,<br/>
        ///           "distanceToUser": 5200.2<br/>
        ///         }<br/>
        ///       },<br/>
        ///       {<br/>
        ///         "id": "bar-42",<br/>
        ///         "reqlEvaluations": {<br/>
        ///           "isInUsersCity": false,<br/>
        ///           "distanceToUser": 2516.0<br/>
        ///         }<br/>
        ///       }<br/>
        ///     ],<br/>
        ///    "numberNextRecommsCalls": 0<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="diversity">
        /// **Expert option:** Real number from [0.0, 1.0], which determines how mutually dissimilar the recommended items should be. The default value is 0.0, i.e., no diversification. Value 1.0 means maximal diversification.
        /// </param>
        /// <param name="minRelevance">
        /// **Expert option:** Specifies the threshold of how relevant must the recommended items be to the user. Possible values one of: "low", "medium", "high". The default value is "low", meaning that the system attempts to recommend a number of items equal to *count* at any cost. If there is not enough data (such as interactions or item properties), this may even lead to bestseller-based recommendations to be appended to reach the full *count*. This behavior may be suppressed by using "medium" or "high" values. In such a case, the system only recommends items of at least the requested relevance and may return less than *count* items when there is not enough data to fulfill it.
        /// </param>
        /// <param name="rotationRate">
        /// **Expert option:** If your users browse the system in real-time, it may easily happen that you wish to offer them recommendations multiple times. Here comes the question: how much should the recommendations change? Should they remain the same, or should they rotate? Recombee API allows you to control this per request in a backward fashion. You may penalize an item for being recommended in the near past. For the specific user, `rotationRate=1` means maximal rotation, `rotationRate=0` means absolutely no rotation. You may also use, for example, `rotationRate=0.2` for only slight rotation of recommended items. Default: `0`.
        /// </param>
        /// <param name="rotationTime">
        /// **Expert option:** Taking *rotationRate* into account, specifies how long it takes for an item to recover from the penalization. For example, `rotationTime=7200.0` means that items recommended less than 2 hours ago are penalized. Default: `7200.0`.
        /// </param>
        /// <param name="expertSettings">
        /// Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">
        /// If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsUsersByUserIdItemsAsync(
            string databaseId,
            string userId,
            int count,
            string? scenario = default,
            bool? cascadeCreate = default,
            bool? returnProperties = default,
            global::System.Collections.Generic.IList<string>? includedProperties = default,
            string? filter = default,
            string? booster = default,
            global::Recombee.Logic? logic = default,
            global::System.Collections.Generic.Dictionary<string, string>? reqlExpressions = default,
            double? diversity = default,
            global::Recombee.RecommendItemsToUserParametersMinRelevance? minRelevance = default,
            double? rotationRate = default,
            double? rotationTime = default,
            object? expertSettings = default,
            bool? returnAbGroup = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Recombee.RecommendItemsToUserParameters
            {
                Count = count,
                Scenario = scenario,
                CascadeCreate = cascadeCreate,
                ReturnProperties = returnProperties,
                IncludedProperties = includedProperties,
                Filter = filter,
                Booster = booster,
                Logic = logic,
                ReqlExpressions = reqlExpressions,
                Diversity = diversity,
                MinRelevance = minRelevance,
                RotationRate = rotationRate,
                RotationTime = rotationTime,
                ExpertSettings = expertSettings,
                ReturnAbGroup = returnAbGroup,
            };

            return await CreateByDatabaseIdRecommsUsersByUserIdItemsAsync(
                databaseId: databaseId,
                userId: userId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}