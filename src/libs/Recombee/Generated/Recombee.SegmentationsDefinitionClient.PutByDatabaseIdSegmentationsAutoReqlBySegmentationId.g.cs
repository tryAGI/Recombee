
#nullable enable

namespace Recombee
{
    public partial class SegmentationsDefinitionClient
    {


        private static readonly global::Recombee.EndPointSecurityRequirement s_PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdSecurityRequirement0 =
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
        private static readonly global::Recombee.EndPointSecurityRequirement[] s_PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdSecurityRequirements =
            new global::Recombee.EndPointSecurityRequirement[]
            {                s_PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdSecurityRequirement0,
            };
        partial void PreparePutByDatabaseIdSegmentationsAutoReqlBySegmentationIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string databaseId,
            ref string segmentationId,
            global::Recombee.CreateAutoReQLSegmentationParameters request);
        partial void PreparePutByDatabaseIdSegmentationsAutoReqlBySegmentationIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string databaseId,
            string segmentationId,
            global::Recombee.CreateAutoReQLSegmentationParameters request);
        partial void ProcessPutByDatabaseIdSegmentationsAutoReqlBySegmentationIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create Auto ReQL Segmentation<br/>
        /// Segment the items using a [ReQL](https://docs.recombee.com/reql) expression.<br/>
        /// For each item, the expression should return a set that contains IDs of segments to which the item belongs to.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        public async global::System.Threading.Tasks.Task PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync(
            string databaseId,
            string segmentationId,

            global::Recombee.CreateAutoReQLSegmentationParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsResponseAsync(
                databaseId: databaseId,
                segmentationId: segmentationId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
        /// <summary>
        /// Create Auto ReQL Segmentation<br/>
        /// Segment the items using a [ReQL](https://docs.recombee.com/reql) expression.<br/>
        /// For each item, the expression should return a set that contains IDs of segments to which the item belongs to.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Recombee.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Recombee.AutoSDKHttpResponse> PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsResponseAsync(
            string databaseId,
            string segmentationId,

            global::Recombee.CreateAutoReQLSegmentationParameters request,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePutByDatabaseIdSegmentationsAutoReqlBySegmentationIdArguments(
                httpClient: HttpClient,
                databaseId: ref databaseId,
                segmentationId: ref segmentationId,
                request: request);


            var __authorizations = global::Recombee.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdSecurityRequirements,
                operationName: "PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync");

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
                                path: $"/{databaseId}/segmentations/auto-reql/{segmentationId}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Recombee.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
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
                PreparePutByDatabaseIdSegmentationsAutoReqlBySegmentationIdRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    databaseId: databaseId!,
                    segmentationId: segmentationId!,
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
                                operationId: "putByDatabaseIdSegmentationsAutoReqlBySegmentationId",
                                methodName: "PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync",
                                pathTemplate: "$\"/{databaseId}/segmentations/auto-reql/{segmentationId}\"",
                                httpMethod: "PUT",
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
                                operationId: "putByDatabaseIdSegmentationsAutoReqlBySegmentationId",
                                methodName: "PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync",
                                pathTemplate: "$\"/{databaseId}/segmentations/auto-reql/{segmentationId}\"",
                                httpMethod: "PUT",
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
                                operationId: "putByDatabaseIdSegmentationsAutoReqlBySegmentationId",
                                methodName: "PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync",
                                pathTemplate: "$\"/{databaseId}/segmentations/auto-reql/{segmentationId}\"",
                                httpMethod: "PUT",
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
                ProcessPutByDatabaseIdSegmentationsAutoReqlBySegmentationIdResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Recombee.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Recombee.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "putByDatabaseIdSegmentationsAutoReqlBySegmentationId",
                                methodName: "PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync",
                                pathTemplate: "$\"/{databaseId}/segmentations/auto-reql/{segmentationId}\"",
                                httpMethod: "PUT",
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
                                operationId: "putByDatabaseIdSegmentationsAutoReqlBySegmentationId",
                                methodName: "PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync",
                                pathTemplate: "$\"/{databaseId}/segmentations/auto-reql/{segmentationId}\"",
                                httpMethod: "PUT",
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

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                return new global::Recombee.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Recombee.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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
                                    return new global::Recombee.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::Recombee.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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
        /// Create Auto ReQL Segmentation<br/>
        /// Segment the items using a [ReQL](https://docs.recombee.com/reql) expression.<br/>
        /// For each item, the expression should return a set that contains IDs of segments to which the item belongs to.
        /// </summary>
        /// <param name="databaseId"></param>
        /// <param name="segmentationId"></param>
        /// <param name="sourceType">
        /// What type of data should be segmented. Currently only `items` are supported.
        /// </param>
        /// <param name="expression">
        /// ReQL expression that returns for each item a set with IDs of segments to which the item belongs
        /// </param>
        /// <param name="title">
        /// Human-readable name that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="description">
        /// Description that is shown in the Recombee Admin UI.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync(
            string databaseId,
            string segmentationId,
            string sourceType,
            string expression,
            string? title = default,
            string? description = default,
            global::Recombee.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Recombee.CreateAutoReQLSegmentationParameters
            {
                SourceType = sourceType,
                Expression = expression,
                Title = title,
                Description = description,
            };

            await PutByDatabaseIdSegmentationsAutoReqlBySegmentationIdAsync(
                databaseId: databaseId,
                segmentationId: segmentationId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}