// <auto-generated/>
using JiraLib.Models;
using JiraLib.Rest.Api.Three.Issuetypescreenscheme.Item;
using JiraLib.Rest.Api.Three.Issuetypescreenscheme.Mapping;
using JiraLib.Rest.Api.Three.Issuetypescreenscheme.Project;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Issuetypescreenscheme {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\issuetypescreenscheme
    /// </summary>
    public class IssuetypescreenschemeRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The mapping property</summary>
        public MappingRequestBuilder Mapping
        {
            get => new MappingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The project property</summary>
        public ProjectRequestBuilder Project
        {
            get => new ProjectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the JiraLib.rest.api.Three.issuetypescreenscheme.item collection</summary>
        /// <param name="position">The ID of the issue type screen scheme.</param>
        /// <returns>A <see cref="WithIssueTypeScreenSchemeItemRequestBuilder"/></returns>
        public WithIssueTypeScreenSchemeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("issueTypeScreenSchemeId", position);
                return new WithIssueTypeScreenSchemeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="IssuetypescreenschemeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssuetypescreenschemeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issuetypescreenscheme{?expand*,id*,maxResults*,orderBy*,queryString*,startAt*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="IssuetypescreenschemeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssuetypescreenschemeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issuetypescreenscheme{?expand*,id*,maxResults*,orderBy*,queryString*,startAt*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of issue type screen schemes.Only issue type screen schemes used in classic projects are returned.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="PageBeanIssueTypeScreenScheme"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanIssueTypeScreenScheme?> GetAsync(Action<RequestConfiguration<IssuetypescreenschemeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PageBeanIssueTypeScreenScheme> GetAsync(Action<RequestConfiguration<IssuetypescreenschemeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<PageBeanIssueTypeScreenScheme>(requestInfo, PageBeanIssueTypeScreenScheme.CreateFromDiscriminatorValue, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates an issue type screen scheme.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="IssueTypeScreenSchemeId"/></returns>
        /// <param name="body">The details of an issue type screen scheme.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<IssueTypeScreenSchemeId?> PostAsync(IssueTypeScreenSchemeDetails body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<IssueTypeScreenSchemeId> PostAsync(IssueTypeScreenSchemeDetails body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<IssueTypeScreenSchemeId>(requestInfo, IssueTypeScreenSchemeId.CreateFromDiscriminatorValue, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of issue type screen schemes.Only issue type screen schemes used in classic projects are returned.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<IssuetypescreenschemeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<IssuetypescreenschemeRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates an issue type screen scheme.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The details of an issue type screen scheme.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(IssueTypeScreenSchemeDetails body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(IssueTypeScreenSchemeDetails body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="IssuetypescreenschemeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public IssuetypescreenschemeRequestBuilder WithUrl(string rawUrl)
        {
            return new IssuetypescreenschemeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of issue type screen schemes.Only issue type screen schemes used in classic projects are returned.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class IssuetypescreenschemeRequestBuilderGetQueryParameters 
        {
            /// <summary>Use [expand](#expansion) to include additional information in the response. This parameter accepts `projects` that, for each issue type screen schemes, returns information about the projects the issue type screen scheme is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>The list of issue type screen scheme IDs. To include multiple IDs, provide an ampersand-separated list. For example, `id=10000&amp;id=10001`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("id")]
            public long?[]? Id { get; set; }
#nullable restore
#else
            [QueryParameter("id")]
            public long?[] Id { get; set; }
#endif
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResults")]
            public int? MaxResults { get; set; }
            /// <summary>[Order](#ordering) the results by a field: *  `name` Sorts by issue type screen scheme name. *  `id` Sorts by issue type screen scheme ID.</summary>
            [Obsolete("This property is deprecated, use OrderByAsGetOrderByQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("orderBy")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("orderBy")]
            public string OrderBy { get; set; }
#endif
            /// <summary>[Order](#ordering) the results by a field: *  `name` Sorts by issue type screen scheme name. *  `id` Sorts by issue type screen scheme ID.</summary>
            [QueryParameter("orderBy")]
            public GetOrderByQueryParameterType? OrderByAsGetOrderByQueryParameterType { get; set; }
            /// <summary>String used to perform a case-insensitive partial match with issue type screen scheme name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("queryString")]
            public string? QueryString { get; set; }
#nullable restore
#else
            [QueryParameter("queryString")]
            public string QueryString { get; set; }
#endif
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public long? StartAt { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class IssuetypescreenschemeRequestBuilderGetRequestConfiguration : RequestConfiguration<IssuetypescreenschemeRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class IssuetypescreenschemeRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
