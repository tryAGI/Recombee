
#nullable enable

namespace Recombee
{
    public partial class RecommendationsClient
    {


        private static readonly global::Recombee.EndPointSecurityRequirement s_CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsSecurityRequirement0 =
            new global::Recombee.EndPointSecurityRequirement
            {
                Authorizations = new global::Recombee.EndPointAuthorizationRequirement[]
                {                    new global::Recombee.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Recombee.EndPointSecurityRequirement[] s_CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsSecurityRequirements =
            new global::Recombee.EndPointSecurityRequirement[]
            {                s_CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsSecurityRequirement0,
            };
        partial void PrepareCreateByDatabaseIdRecommsItemsByItemIdItemSegmentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string databaseId,
            ref string itemId,
            global::Recombee.RecommendItemSegmentsToItemParameters request);
        partial void PrepareCreateByDatabaseIdRecommsItemsByItemIdItemSegmentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string databaseId,
            string itemId,
            global::Recombee.RecommendItemSegmentsToItemParameters request);
        partial void ProcessCreateByDatabaseIdRecommsItemsByItemIdItemSegmentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateByDatabaseIdRecommsItemsByItemIdItemSegmentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Recommend Item Segments to Item<br/>
        /// Recommends Segments from a [Segmentation](https://docs.recombee.com/segmentations) that are the most relevant to a particular item.<br/>
        /// Based on the used Segmentation, this endpoint can be used for example for:<br/>
        ///   - Recommending the related categories<br/>
        ///   - Recommending the related genres<br/>
        ///   - Recommending the related brands<br/>
        ///   - Recommending the related artists<br/>
        /// You need to set the used Segmentation the Admin UI in the [Scenario settings](https://docs.recombee.com/scenarios) prior to using this endpoint.<br/>
        /// The returned segments are sorted by relevance (first segment being the most relevant).<br/>
        /// It is also possible to use POST HTTP method (for example in case of very long ReQL filter) - query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync(
            string databaseId,
            string itemId,

            global::Recombee.RecommendItemSegmentsToItemParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsResponseAsync(
                databaseId: databaseId,
                itemId: itemId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Recommend Item Segments to Item<br/>
        /// Recommends Segments from a [Segmentation](https://docs.recombee.com/segmentations) that are the most relevant to a particular item.<br/>
        /// Based on the used Segmentation, this endpoint can be used for example for:<br/>
        ///   - Recommending the related categories<br/>
        ///   - Recommending the related genres<br/>
        ///   - Recommending the related brands<br/>
        ///   - Recommending the related artists<br/>
        /// You need to set the used Segmentation the Admin UI in the [Scenario settings](https://docs.recombee.com/scenarios) prior to using this endpoint.<br/>
        /// The returned segments are sorted by relevance (first segment being the most relevant).<br/>
        /// It is also possible to use POST HTTP method (for example in case of very long ReQL filter) - query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recombee.AutoSDKHttpResponse<global::Recombee.RecommendationResponse>> CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsResponseAsync(
            string databaseId,
            string itemId,

            global::Recombee.RecommendItemSegmentsToItemParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateByDatabaseIdRecommsItemsByItemIdItemSegmentsArguments(
                httpClient: HttpClient,
                databaseId: ref databaseId,
                itemId: ref itemId,
                request: request);


            var __authorizations = global::Recombee.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsSecurityRequirements,
                operationName: "CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync");

            using var __timeoutCancellationTokenSource = global::Recombee.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Recombee.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Recombee.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Recombee.PathBuilder(
                                path: $"/{databaseId}/recomms/items/{itemId}/item-segments/",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Recombee.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Recombee.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateByDatabaseIdRecommsItemsByItemIdItemSegmentsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    databaseId: databaseId!,
                    itemId: itemId!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Recombee.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createByDatabaseIdRecommsItemsByItemIdItemSegments",
                                methodName: "CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/items/{itemId}/item-segments/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Recombee.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Recombee.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createByDatabaseIdRecommsItemsByItemIdItemSegments",
                                methodName: "CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/items/{itemId}/item-segments/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Recombee.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Recombee.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Recombee.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Recombee.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createByDatabaseIdRecommsItemsByItemIdItemSegments",
                                methodName: "CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/items/{itemId}/item-segments/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Recombee.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateByDatabaseIdRecommsItemsByItemIdItemSegmentsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Recombee.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createByDatabaseIdRecommsItemsByItemIdItemSegments",
                                methodName: "CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/items/{itemId}/item-segments/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Recombee.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createByDatabaseIdRecommsItemsByItemIdItemSegments",
                                methodName: "CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/items/{itemId}/item-segments/\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            //
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Recombee.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Recombee.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateByDatabaseIdRecommsItemsByItemIdItemSegmentsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Recombee.RecommendationResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Recombee.AutoSDKHttpResponse<global::Recombee.RecommendationResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Recombee.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Recombee.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Recombee.RecommendationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Recombee.AutoSDKHttpResponse<global::Recombee.RecommendationResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Recombee.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Recombee.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Recommend Item Segments to Item<br/>
        /// Recommends Segments from a [Segmentation](https://docs.recombee.com/segmentations) that are the most relevant to a particular item.<br/>
        /// Based on the used Segmentation, this endpoint can be used for example for:<br/>
        ///   - Recommending the related categories<br/>
        ///   - Recommending the related genres<br/>
        ///   - Recommending the related brands<br/>
        ///   - Recommending the related artists<br/>
        /// You need to set the used Segmentation the Admin UI in the [Scenario settings](https://docs.recombee.com/scenarios) prior to using this endpoint.<br/>
        /// The returned segments are sorted by relevance (first segment being the most relevant).<br/>
        /// It is also possible to use POST HTTP method (for example in case of very long ReQL filter) - query parameters then become body parameters.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="itemId"></param>
        /// <param name="targetUserId">
        /// ID of the user who will see the recommendations.<br/>
        /// Specifying the *targetUserId* is beneficial because:<br/>
        /// * It makes the recommendations personalized<br/>
        /// * Allows the calculation of Actions and Conversions<br/>
        ///   in the graphical user interface,<br/>
        ///   as Recombee can pair the user who got recommendations<br/>
        ///   and who afterward viewed/purchased an item.<br/>
        /// If you insist on not specifying the user, pass `null`<br/>
        /// (`None`, `nil`, `NULL` etc., depending on the language) to *targetUserId*.<br/>
        /// Do not create some special dummy user for getting recommendations,<br/>
        /// as it could mislead the recommendation models,<br/>
        /// and result in wrong recommendations.<br/>
        /// For anonymous/unregistered users, it is possible to use, for example, their session ID.
        /// </param>
        /// <param name="count">
        /// Number of item segments to be recommended (N for the top-N recommendation).
        /// </param>
        /// <param name="scenario">
        /// Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="cascadeCreate">
        /// If the user does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that user, as the user will be already known to the system.
        /// </param>
        /// <param name="filter">
        /// Boolean-returning [ReQL](https://docs.recombee.com/reql) expression which allows you to filter recommended segments based on the `segmentationId`.
        /// </param>
        /// <param name="booster">
        /// Number-returning [ReQL](https://docs.recombee.com/reql) expression which allows you to boost recommendation rate of some segments based on the `segmentationId`.
        /// </param>
        /// <param name="logic"></param>
        /// <param name="expertSettings">
        /// Dictionary of custom options.
        /// </param>
        /// <param name="returnAbGroup">
        /// If there is a custom AB-testing running, return the name of the group to which the request belongs.
        /// </param>
        /// <param name="reqlExpressions">
        /// A dictionary of [ReQL](https://docs.recombee.com/reql) expressions that will be executed for each recommended Item Segment.<br/>
        /// This can be used to compute additional properties of the recommended Item Segments.<br/>
        /// The keys are the names of the expressions, and the values are the actual ReQL expressions.<br/>
        /// Example request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "reqlExpressions": {<br/>
        ///     "countItems": "size(segment_items(\"categories\", 'segmentId'))"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// Example response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "recommId": "a7ac55a4-8d6e-4f19-addc-abac4164d8a8",<br/>
        ///   "recomms": <br/>
        ///     [<br/>
        ///       {<br/>
        ///         "id": "category-fantasy-books",<br/>
        ///         "reqlEvaluations": {<br/>
        ///           "countItems": 486<br/>
        ///         }<br/>
        ///       },<br/>
        ///       {<br/>
        ///         "id": "category-sci-fi-costumes",<br/>
        ///         "reqlEvaluations": {<br/>
        ///           "countItems": 19<br/>
        ///         }<br/>
        ///       }<br/>
        ///     ],<br/>
        ///    "numberNextRecommsCalls": 0<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync(
            string databaseId,
            string itemId,
            string targetUserId,
            int count,
            string? scenario = default,
            bool? cascadeCreate = default,
            string? filter = default,
            string? booster = default,
            global::Recombee.Logic? logic = default,
            object? expertSettings = default,
            bool? returnAbGroup = default,
            global::System.Collections.Generic.Dictionary<string, string>? reqlExpressions = default,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Recombee.RecommendItemSegmentsToItemParameters
            {
                TargetUserId = targetUserId,
                Count = count,
                Scenario = scenario,
                CascadeCreate = cascadeCreate,
                Filter = filter,
                Booster = booster,
                Logic = logic,
                ExpertSettings = expertSettings,
                ReturnAbGroup = returnAbGroup,
                ReqlExpressions = reqlExpressions,
            };

            return await CreateByDatabaseIdRecommsItemsByItemIdItemSegmentsAsync(
                databaseId: databaseId,
                itemId: itemId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}