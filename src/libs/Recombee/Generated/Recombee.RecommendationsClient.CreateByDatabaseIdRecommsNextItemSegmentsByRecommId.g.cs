
#nullable enable

namespace Recombee
{
    public partial class RecommendationsClient
    {


        private static readonly global::Recombee.EndPointSecurityRequirement s_CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdSecurityRequirement0 =
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
        private static readonly global::Recombee.EndPointSecurityRequirement[] s_CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdSecurityRequirements =
            new global::Recombee.EndPointSecurityRequirement[]
            {                s_CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdSecurityRequirement0,
            };
        partial void PrepareCreateByDatabaseIdRecommsNextItemSegmentsByRecommIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string databaseId,
            ref string recommId,
            global::Recombee.RecommendNextItemSegmentsParameters request);
        partial void PrepareCreateByDatabaseIdRecommsNextItemSegmentsByRecommIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string databaseId,
            string recommId,
            global::Recombee.RecommendNextItemSegmentsParameters request);
        partial void ProcessCreateByDatabaseIdRecommsNextItemSegmentsByRecommIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateByDatabaseIdRecommsNextItemSegmentsByRecommIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Recommend Next Item Segments<br/>
        /// Returns [Item Segments](https://docs.recombee.com/segmentations) to be shown as the next recommendations when a user scrolls (e.g., within a carousel or feed of Item Segments such as brands, artists, topics, or categories).<br/>
        /// The request requires the `recommId` of a base recommendation request and the number of Segments to return (`count`).<br/>
        /// The base request can be one of:<br/>
        ///   - [Recommend Item Segments to Item](https://docs.recombee.com/api#recommend-item-segments-to-item)<br/>
        ///   - [Recommend Item Segments to User](https://docs.recombee.com/api#recommend-item-segments-to-user)<br/>
        ///   - [Recommend Item Segments to Item Segment](https://docs.recombee.com/api#recommend-item-segments-to-item-segment)<br/>
        ///   - [Search Item Segments](https://docs.recombee.com/api#search-item-segments)<br/>
        /// All other parameters are inherited from the base request associated with the provided `recommId`.<br/>
        /// This endpoint can be called multiple times for a single `recommId`. Each call returns different Item Segments that have not been recommended in previous calls.<br/>
        /// The number of calls made so far is returned in the `numberNextRecommsCalls` field.<br/>
        /// Requests can be made up to 30 minutes after the base request or the most recent Recommend Next Item Segments call.<br/>
        /// For billing purposes, each call to this endpoint is counted as a separate recommendation request.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="recommId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync(
            string databaseId,
            string recommId,

            global::Recombee.RecommendNextItemSegmentsParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateByDatabaseIdRecommsNextItemSegmentsByRecommIdArguments(
                httpClient: HttpClient,
                databaseId: ref databaseId,
                recommId: ref recommId,
                request: request);


            var __authorizations = global::Recombee.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdSecurityRequirements,
                operationName: "CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync");

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
                                path: $"/{databaseId}/recomms/next/item-segments/{recommId}",
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
                PrepareCreateByDatabaseIdRecommsNextItemSegmentsByRecommIdRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    databaseId: databaseId,
                    recommId: recommId,
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
                                operationId: "createByDatabaseIdRecommsNextItemSegmentsByRecommId",
                                methodName: "CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/next/item-segments/{recommId}\"",
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
                                operationId: "createByDatabaseIdRecommsNextItemSegmentsByRecommId",
                                methodName: "CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/next/item-segments/{recommId}\"",
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
                                operationId: "createByDatabaseIdRecommsNextItemSegmentsByRecommId",
                                methodName: "CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/next/item-segments/{recommId}\"",
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
                ProcessCreateByDatabaseIdRecommsNextItemSegmentsByRecommIdResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Recombee.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createByDatabaseIdRecommsNextItemSegmentsByRecommId",
                                methodName: "CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/next/item-segments/{recommId}\"",
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
                                operationId: "createByDatabaseIdRecommsNextItemSegmentsByRecommId",
                                methodName: "CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync",
                                pathTemplate: "$\"/{databaseId}/recomms/next/item-segments/{recommId}\"",
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
                                ProcessCreateByDatabaseIdRecommsNextItemSegmentsByRecommIdResponseContent(
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
                                        __effectiveCancellationToken
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
        /// Recommend Next Item Segments<br/>
        /// Returns [Item Segments](https://docs.recombee.com/segmentations) to be shown as the next recommendations when a user scrolls (e.g., within a carousel or feed of Item Segments such as brands, artists, topics, or categories).<br/>
        /// The request requires the `recommId` of a base recommendation request and the number of Segments to return (`count`).<br/>
        /// The base request can be one of:<br/>
        ///   - [Recommend Item Segments to Item](https://docs.recombee.com/api#recommend-item-segments-to-item)<br/>
        ///   - [Recommend Item Segments to User](https://docs.recombee.com/api#recommend-item-segments-to-user)<br/>
        ///   - [Recommend Item Segments to Item Segment](https://docs.recombee.com/api#recommend-item-segments-to-item-segment)<br/>
        ///   - [Search Item Segments](https://docs.recombee.com/api#search-item-segments)<br/>
        /// All other parameters are inherited from the base request associated with the provided `recommId`.<br/>
        /// This endpoint can be called multiple times for a single `recommId`. Each call returns different Item Segments that have not been recommended in previous calls.<br/>
        /// The number of calls made so far is returned in the `numberNextRecommsCalls` field.<br/>
        /// Requests can be made up to 30 minutes after the base request or the most recent Recommend Next Item Segments call.<br/>
        /// For billing purposes, each call to this endpoint is counted as a separate recommendation request.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="recommId"></param>
        /// <param name="count">
        /// Number of item segments to be recommended
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recombee.RecommendationResponse> CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync(
            string databaseId,
            string recommId,
            int count,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Recombee.RecommendNextItemSegmentsParameters
            {
                Count = count,
            };

            return await CreateByDatabaseIdRecommsNextItemSegmentsByRecommIdAsync(
                databaseId: databaseId,
                recommId: recommId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}