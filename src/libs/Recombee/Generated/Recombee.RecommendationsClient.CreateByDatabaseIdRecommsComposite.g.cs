
#nullable enable

namespace Recombee
{
    public partial class RecommendationsClient
    {


        private static readonly global::Recombee.EndPointSecurityRequirement s_CreateByDatabaseIdRecommsCompositeSecurityRequirement0 =
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
        private static readonly global::Recombee.EndPointSecurityRequirement[] s_CreateByDatabaseIdRecommsCompositeSecurityRequirements =
            new global::Recombee.EndPointSecurityRequirement[]
            {                s_CreateByDatabaseIdRecommsCompositeSecurityRequirement0,
            };
        partial void PrepareCreateByDatabaseIdRecommsCompositeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string databaseId,
            global::Recombee.CompositeRecommendationParameters request);
        partial void PrepareCreateByDatabaseIdRecommsCompositeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string databaseId,
            global::Recombee.CompositeRecommendationParameters request);
        partial void ProcessCreateByDatabaseIdRecommsCompositeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateByDatabaseIdRecommsCompositeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Composite Recommendation<br/>
        /// Composite Recommendation returns both a *source entity* (e.g., an Item or [Item Segment](https://docs.recombee.com/segmentations.html)) and a list of related recommendations in a single response.<br/>
        /// It is ideal for use cases such as personalized homepage sections (*Articles from &lt;category&gt;*), *Because You Watched &lt;movie&gt;*, or *Artists Related to Your Favorite Artist &lt;artist&gt;*.<br/>
        /// See detailed **examples and configuration guidance** in the [Composite Scenarios documentation](https://docs.recombee.com/scenarios#composite-recommendations).<br/>
        /// **Structure**<br/>
        /// The endpoint operates in two stages:<br/>
        /// 1. Recommends the *source* (e.g., an Item Segment or item) to the user.<br/>
        /// 2. Recommends *results* (items or Item Segments) related to that *source*.<br/>
        /// For example, *Articles from &lt;category&gt;* can be decomposed into:<br/>
        ///   - [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-item-segments-to-user) to find the category.<br/>
        ///   - [Recommend Items To Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment) to recommend articles from that category.<br/>
        /// Since the first step uses [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-items-to-user), you must include the `userId` parameter in the *Composite Recommendation* request.<br/>
        /// Each *Composite Recommendation* counts as a single recommendation API request for billing.<br/>
        /// **Stage-specific Parameters**<br/>
        /// Additional parameters can be supplied via [sourceSettings](https://docs.recombee.com/api#composite-recommendation-param-sourceSettings) and [resultSettings](https://docs.recombee.com/api#composite-recommendation-param-resultSettings).<br/>
        /// In the example above:<br/>
        ///   - `sourceSettings` may include any parameter valid for [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-items-to-user) (e.g., `filter`, `booster`).<br/>
        ///   - `resultSettings` may include any parameter valid for [Recommend Items To Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment).<br/>
        /// See [this example](https://docs.recombee.com/api#composite-recommendation-example-setting-parameters-for-individual-stages) for more details.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recombee.CompositeRecommendationResponse> CreateByDatabaseIdRecommsCompositeAsync(
            string databaseId,

            global::Recombee.CompositeRecommendationParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateByDatabaseIdRecommsCompositeArguments(
                httpClient: HttpClient,
                databaseId: ref databaseId,
                request: request);


            var __authorizations = global::Recombee.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateByDatabaseIdRecommsCompositeSecurityRequirements,
                operationName: "CreateByDatabaseIdRecommsCompositeAsync");

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
                                path: $"/{databaseId}/recomms/composite/",
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
                PrepareCreateByDatabaseIdRecommsCompositeRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    databaseId: databaseId,
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
                                operationId: "createByDatabaseIdRecommsComposite",
                                methodName: "CreateByDatabaseIdRecommsCompositeAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/composite/\"",
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Recombee.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createByDatabaseIdRecommsComposite",
                                methodName: "CreateByDatabaseIdRecommsCompositeAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/composite/\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Recombee.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Recombee.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Recombee.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createByDatabaseIdRecommsComposite",
                                methodName: "CreateByDatabaseIdRecommsCompositeAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/composite/\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Recombee.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessCreateByDatabaseIdRecommsCompositeResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Recombee.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createByDatabaseIdRecommsComposite",
                                methodName: "CreateByDatabaseIdRecommsCompositeAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/composite/\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Recombee.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createByDatabaseIdRecommsComposite",
                                methodName: "CreateByDatabaseIdRecommsCompositeAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/composite/\"",
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
                                ProcessCreateByDatabaseIdRecommsCompositeResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Recombee.CompositeRecommendationResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Recombee.CompositeRecommendationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Composite Recommendation<br/>
        /// Composite Recommendation returns both a *source entity* (e.g., an Item or [Item Segment](https://docs.recombee.com/segmentations.html)) and a list of related recommendations in a single response.<br/>
        /// It is ideal for use cases such as personalized homepage sections (*Articles from &lt;category&gt;*), *Because You Watched &lt;movie&gt;*, or *Artists Related to Your Favorite Artist &lt;artist&gt;*.<br/>
        /// See detailed **examples and configuration guidance** in the [Composite Scenarios documentation](https://docs.recombee.com/scenarios#composite-recommendations).<br/>
        /// **Structure**<br/>
        /// The endpoint operates in two stages:<br/>
        /// 1. Recommends the *source* (e.g., an Item Segment or item) to the user.<br/>
        /// 2. Recommends *results* (items or Item Segments) related to that *source*.<br/>
        /// For example, *Articles from &lt;category&gt;* can be decomposed into:<br/>
        ///   - [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-item-segments-to-user) to find the category.<br/>
        ///   - [Recommend Items To Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment) to recommend articles from that category.<br/>
        /// Since the first step uses [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-items-to-user), you must include the `userId` parameter in the *Composite Recommendation* request.<br/>
        /// Each *Composite Recommendation* counts as a single recommendation API request for billing.<br/>
        /// **Stage-specific Parameters**<br/>
        /// Additional parameters can be supplied via [sourceSettings](https://docs.recombee.com/api#composite-recommendation-param-sourceSettings) and [resultSettings](https://docs.recombee.com/api#composite-recommendation-param-resultSettings).<br/>
        /// In the example above:<br/>
        ///   - `sourceSettings` may include any parameter valid for [Recommend Item Segments To User](https://docs.recombee.com/api#recommend-items-to-user) (e.g., `filter`, `booster`).<br/>
        ///   - `resultSettings` may include any parameter valid for [Recommend Items To Item Segment](https://docs.recombee.com/api#recommend-items-to-item-segment).<br/>
        /// See [this example](https://docs.recombee.com/api#composite-recommendation-example-setting-parameters-for-individual-stages) for more details.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="scenario">
        /// Scenario defines a particular application of recommendations. It can be, for example, "homepage", "cart", or "emailing".<br/>
        /// You can set various settings to the [scenario](https://docs.recombee.com/scenarios) in the [Admin UI](https://admin.recombee.com). You can also see the performance of each scenario in the Admin UI separately, so you can check how well each application performs.<br/>
        /// The AI that optimizes models to get the best results may optimize different scenarios separately or even use different models in each of the scenarios.
        /// </param>
        /// <param name="count">
        /// Number of items to be recommended (N for the top-N recommendation).
        /// </param>
        /// <param name="itemId">
        /// ID of the item for which the recommendations are to be generated.
        /// </param>
        /// <param name="userId">
        /// ID of the user for which the recommendations are to be generated.
        /// </param>
        /// <param name="logic"></param>
        /// <param name="segmentId">
        /// ID of the segment from `contextSegmentationId` for which the recommendations are to be generated.
        /// </param>
        /// <param name="cascadeCreate">
        /// If the entity for the source recommendation does not exist in the database, returns a list of non-personalized recommendations and creates the user in the database. This allows, for example, rotations in the following recommendations for that entity, as the entity will be already known to the system.
        /// </param>
        /// <param name="sourceSettings">
        /// Parameters applied for recommending the *Source* stage. The accepted parameters correspond with the recommendation sub-endpoint used to recommend the *Source*.
        /// </param>
        /// <param name="resultSettings">
        /// Parameters applied for recommending the *Result* stage. The accepted parameters correspond with the recommendation sub-endpoint used to recommend the *Result*.
        /// </param>
        /// <param name="expertSettings">
        /// Dictionary of custom options.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recombee.CompositeRecommendationResponse> CreateByDatabaseIdRecommsCompositeAsync(
            string databaseId,
            string scenario,
            int count,
            string? itemId = default,
            string? userId = default,
            global::Recombee.Logic? logic = default,
            string? segmentId = default,
            bool? cascadeCreate = default,
            object? sourceSettings = default,
            object? resultSettings = default,
            object? expertSettings = default,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Recombee.CompositeRecommendationParameters
            {
                Scenario = scenario,
                Count = count,
                ItemId = itemId,
                UserId = userId,
                Logic = logic,
                SegmentId = segmentId,
                CascadeCreate = cascadeCreate,
                SourceSettings = sourceSettings,
                ResultSettings = resultSettings,
                ExpertSettings = expertSettings,
            };

            return await CreateByDatabaseIdRecommsCompositeAsync(
                databaseId: databaseId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}