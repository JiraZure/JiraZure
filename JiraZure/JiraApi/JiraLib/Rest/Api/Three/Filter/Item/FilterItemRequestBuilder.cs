// <auto-generated/>
using JiraLib.Models;
using JiraLib.Rest.Api.Three.Filter.Item.Columns;
using JiraLib.Rest.Api.Three.Filter.Item.Favourite;
using JiraLib.Rest.Api.Three.Filter.Item.Owner;
using JiraLib.Rest.Api.Three.Filter.Item.Permission;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Filter.Item {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\filter\{id}
    /// </summary>
    public class FilterItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The columns property</summary>
        public ColumnsRequestBuilder Columns
        {
            get => new ColumnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The favourite property</summary>
        public FavouriteRequestBuilder Favourite
        {
            get => new FavouriteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The owner property</summary>
        public OwnerRequestBuilder Owner
        {
            get => new OwnerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The permission property</summary>
        public PermissionRequestBuilder Permission
        {
            get => new PermissionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="FilterItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FilterItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/filter/{id}{?expand*,overrideSharePermissions*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="FilterItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FilterItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/filter/{id}{?expand*,overrideSharePermissions*}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a filter.**[Permissions](#permissions) required:** Permission to access Jira, however filters can only be deleted by the creator of the filter or a user with *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a filter.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None, however, the filter is only returned where it is: *  owned by the user. *  shared with a group that the user is a member of. *  shared with a private project that the user has *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for. *  shared with a public project. *  shared with the public.
        /// </summary>
        /// <returns>A <see cref="JiraLib.Models.Filter"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraLib.Models.Filter?> GetAsync(Action<RequestConfiguration<FilterItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<JiraLib.Models.Filter> GetAsync(Action<RequestConfiguration<FilterItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<JiraLib.Models.Filter>(requestInfo, JiraLib.Models.Filter.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates a filter. Use this operation to update a filter&apos;s name, description, JQL, or sharing.**[Permissions](#permissions) required:** Permission to access Jira, however the user must own the filter.
        /// </summary>
        /// <returns>A <see cref="JiraLib.Models.Filter"/></returns>
        /// <param name="body">Details about a filter.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraLib.Models.Filter?> PutAsync(JiraLib.Models.Filter body, Action<RequestConfiguration<FilterItemRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<JiraLib.Models.Filter> PutAsync(JiraLib.Models.Filter body, Action<RequestConfiguration<FilterItemRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<JiraLib.Models.Filter>(requestInfo, JiraLib.Models.Filter.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a filter.**[Permissions](#permissions) required:** Permission to access Jira, however filters can only be deleted by the creator of the filter or a user with *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a filter.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None, however, the filter is only returned where it is: *  owned by the user. *  shared with a group that the user is a member of. *  shared with a private project that the user has *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for. *  shared with a public project. *  shared with the public.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<FilterItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<FilterItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Updates a filter. Use this operation to update a filter&apos;s name, description, JQL, or sharing.**[Permissions](#permissions) required:** Permission to access Jira, however the user must own the filter.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Details about a filter.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(JiraLib.Models.Filter body, Action<RequestConfiguration<FilterItemRequestBuilderPutQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(JiraLib.Models.Filter body, Action<RequestConfiguration<FilterItemRequestBuilderPutQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="FilterItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public FilterItemRequestBuilder WithUrl(string rawUrl)
        {
            return new FilterItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class FilterItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Returns a filter.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None, however, the filter is only returned where it is: *  owned by the user. *  shared with a group that the user is a member of. *  shared with a private project that the user has *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for. *  shared with a public project. *  shared with the public.
        /// </summary>
        public class FilterItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Use [expand](#expansion) to include additional information about filter in the response. This parameter accepts a comma-separated list. Expand options include: *  `sharedUsers` Returns the users that the filter is shared with. This includes users that can browse projects that the filter is shared with. If you don&apos;t specify `sharedUsers`, then the `sharedUsers` object is returned but it doesn&apos;t list any users. The list of users returned is limited to 1000, to access additional users append `[start-index:end-index]` to the expand request. For example, to access the next 1000 users, use `?expand=sharedUsers[1001:2000]`. *  `subscriptions` Returns the users that are subscribed to the filter. If you don&apos;t specify `subscriptions`, the `subscriptions` object is returned but it doesn&apos;t list any subscriptions. The list of subscriptions returned is limited to 1000, to access additional subscriptions append `[start-index:end-index]` to the expand request. For example, to access the next 1000 subscriptions, use `?expand=subscriptions[1001:2000]`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>EXPERIMENTAL: Whether share permissions are overridden to enable filters with any share permissions to be returned. Available to users with *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).</summary>
            [QueryParameter("overrideSharePermissions")]
            public bool? OverrideSharePermissions { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class FilterItemRequestBuilderGetRequestConfiguration : RequestConfiguration<FilterItemRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Updates a filter. Use this operation to update a filter&apos;s name, description, JQL, or sharing.**[Permissions](#permissions) required:** Permission to access Jira, however the user must own the filter.
        /// </summary>
        public class FilterItemRequestBuilderPutQueryParameters 
        {
            /// <summary>Use [expand](#expansion) to include additional information about filter in the response. This parameter accepts a comma-separated list. Expand options include: *  `sharedUsers` Returns the users that the filter is shared with. This includes users that can browse projects that the filter is shared with. If you don&apos;t specify `sharedUsers`, then the `sharedUsers` object is returned but it doesn&apos;t list any users. The list of users returned is limited to 1000, to access additional users append `[start-index:end-index]` to the expand request. For example, to access the next 1000 users, use `?expand=sharedUsers[1001:2000]`. *  `subscriptions` Returns the users that are subscribed to the filter. If you don&apos;t specify `subscriptions`, the `subscriptions` object is returned but it doesn&apos;t list any subscriptions. The list of subscriptions returned is limited to 1000, to access additional subscriptions append `[start-index:end-index]` to the expand request. For example, to access the next 1000 subscriptions, use `?expand=subscriptions[1001:2000]`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>EXPERIMENTAL: Whether share permissions are overridden to enable the addition of any share permissions to filters. Available to users with *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).</summary>
            [QueryParameter("overrideSharePermissions")]
            public bool? OverrideSharePermissions { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class FilterItemRequestBuilderPutRequestConfiguration : RequestConfiguration<FilterItemRequestBuilderPutQueryParameters> 
        {
        }
    }
}
