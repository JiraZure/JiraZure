// <auto-generated/>
using JiraLib.Models;
using JiraLib.Rest.Api.Three.Permissionscheme.Item.Permission;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Permissionscheme.Item {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\permissionscheme\{schemeId}
    /// </summary>
    public class WithSchemeItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The permission property</summary>
        public PermissionRequestBuilder Permission
        {
            get => new PermissionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithSchemeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSchemeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/permissionscheme/{schemeId}{?expand*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithSchemeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSchemeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/permissionscheme/{schemeId}{?expand*}", rawUrl)
        {
        }
        /// <summary>
        /// Deletes a permission scheme.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
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
        /// Returns a permission scheme.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <returns>A <see cref="JiraLib.Models.PermissionScheme"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraLib.Models.PermissionScheme?> GetAsync(Action<RequestConfiguration<WithSchemeItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<JiraLib.Models.PermissionScheme> GetAsync(Action<RequestConfiguration<WithSchemeItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<JiraLib.Models.PermissionScheme>(requestInfo, JiraLib.Models.PermissionScheme.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates a permission scheme. Below are some important things to note when using this resource: *  If a permissions list is present in the request, then it is set in the permission scheme, overwriting *all existing* grants. *  If you want to update only the name and description, then do not send a permissions list in the request. *  Sending an empty list will remove all permission grants from the permission scheme.If you want to add or delete a permission grant instead of updating the whole list, see [Create permission grant](#api-rest-api-3-permissionscheme-schemeId-permission-post) or [Delete permission scheme entity](#api-rest-api-3-permissionscheme-schemeId-permission-permissionId-delete).See [About permission schemes and grants](../api-group-permission-schemes/#about-permission-schemes-and-grants) for more details.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="JiraLib.Models.PermissionScheme"/></returns>
        /// <param name="body">Details of a permission scheme.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraLib.Models.PermissionScheme?> PutAsync(JiraLib.Models.PermissionScheme body, Action<RequestConfiguration<WithSchemeItemRequestBuilderPutQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<JiraLib.Models.PermissionScheme> PutAsync(JiraLib.Models.PermissionScheme body, Action<RequestConfiguration<WithSchemeItemRequestBuilderPutQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<JiraLib.Models.PermissionScheme>(requestInfo, JiraLib.Models.PermissionScheme.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a permission scheme.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
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
        /// Returns a permission scheme.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithSchemeItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithSchemeItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Updates a permission scheme. Below are some important things to note when using this resource: *  If a permissions list is present in the request, then it is set in the permission scheme, overwriting *all existing* grants. *  If you want to update only the name and description, then do not send a permissions list in the request. *  Sending an empty list will remove all permission grants from the permission scheme.If you want to add or delete a permission grant instead of updating the whole list, see [Create permission grant](#api-rest-api-3-permissionscheme-schemeId-permission-post) or [Delete permission scheme entity](#api-rest-api-3-permissionscheme-schemeId-permission-permissionId-delete).See [About permission schemes and grants](../api-group-permission-schemes/#about-permission-schemes-and-grants) for more details.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Details of a permission scheme.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(JiraLib.Models.PermissionScheme body, Action<RequestConfiguration<WithSchemeItemRequestBuilderPutQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(JiraLib.Models.PermissionScheme body, Action<RequestConfiguration<WithSchemeItemRequestBuilderPutQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="WithSchemeItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithSchemeItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithSchemeItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithSchemeItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Returns a permission scheme.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        public class WithSchemeItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Use expand to include additional information in the response. This parameter accepts a comma-separated list. Note that permissions are included when you specify any value. Expand options include: *  `all` Returns all expandable information. *  `field` Returns information about the custom field granted the permission. *  `group` Returns information about the group that is granted the permission. *  `permissions` Returns all permission grants for each permission scheme. *  `projectRole` Returns information about the project role granted the permission. *  `user` Returns information about the user who is granted the permission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithSchemeItemRequestBuilderGetRequestConfiguration : RequestConfiguration<WithSchemeItemRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Updates a permission scheme. Below are some important things to note when using this resource: *  If a permissions list is present in the request, then it is set in the permission scheme, overwriting *all existing* grants. *  If you want to update only the name and description, then do not send a permissions list in the request. *  Sending an empty list will remove all permission grants from the permission scheme.If you want to add or delete a permission grant instead of updating the whole list, see [Create permission grant](#api-rest-api-3-permissionscheme-schemeId-permission-post) or [Delete permission scheme entity](#api-rest-api-3-permissionscheme-schemeId-permission-permissionId-delete).See [About permission schemes and grants](../api-group-permission-schemes/#about-permission-schemes-and-grants) for more details.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class WithSchemeItemRequestBuilderPutQueryParameters 
        {
            /// <summary>Use expand to include additional information in the response. This parameter accepts a comma-separated list. Note that permissions are always included when you specify any value. Expand options include: *  `all` Returns all expandable information. *  `field` Returns information about the custom field granted the permission. *  `group` Returns information about the group that is granted the permission. *  `permissions` Returns all permission grants for each permission scheme. *  `projectRole` Returns information about the project role granted the permission. *  `user` Returns information about the user who is granted the permission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithSchemeItemRequestBuilderPutRequestConfiguration : RequestConfiguration<WithSchemeItemRequestBuilderPutQueryParameters> 
        {
        }
    }
}
