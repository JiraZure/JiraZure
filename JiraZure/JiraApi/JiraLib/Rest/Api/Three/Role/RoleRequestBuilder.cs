// <auto-generated/>
using JiraLib.Models;
using JiraLib.Rest.Api.Three.Role.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Role {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\role
    /// </summary>
    public class RoleRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the JiraLib.rest.api.Three.role.item collection</summary>
        /// <param name="position">The ID of the project role to delete. Use [Get all project roles](#api-rest-api-3-role-get) to get a list of project role IDs.</param>
        /// <returns>A <see cref="RoleItemRequestBuilder"/></returns>
        public RoleItemRequestBuilder this[long position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new RoleItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the JiraLib.rest.api.Three.role.item collection</summary>
        /// <param name="position">The ID of the project role to delete. Use [Get all project roles](#api-rest-api-3-role-get) to get a list of project role IDs.</param>
        /// <returns>A <see cref="RoleItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public RoleItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new RoleItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="RoleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RoleRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/role", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="RoleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RoleRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/role", rawUrl)
        {
        }
        /// <summary>
        /// Gets a list of all project roles, complete with project role details and default actors.### About project roles ###[Project roles](https://support.atlassian.com/jira-cloud-administration/docs/manage-project-roles/) are a flexible way to to associate users and groups with projects. In Jira Cloud, the list of project roles is shared globally with all projects, but each project can have a different set of actors associated with it (unlike groups, which have the same membership throughout all Jira applications).Project roles are used in [permission schemes](#api-rest-api-3-permissionscheme-get), [email notification schemes](#api-rest-api-3-notificationscheme-get), [issue security levels](#api-rest-api-3-issuesecurityschemes-get), [comment visibility](#api-rest-api-3-comment-list-post), and workflow conditions.#### Members and actors ####In the Jira REST API, a member of a project role is called an *actor*. An *actor* is a group or user associated with a project role.Actors may be set as [default members](https://support.atlassian.com/jira-cloud-administration/docs/manage-project-roles/#Specifying-&apos;default-members&apos;-for-a-project-role) of the project role or set at the project level: *  Default actors: Users and groups that are assigned to the project role for all newly created projects. The default actors can be removed at the project level later if desired. *  Actors: Users and groups that are associated with a project role for a project, which may differ from the default actors. This enables you to assign a user to different roles in different projects.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A List&lt;ProjectRole&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<ProjectRole>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<ProjectRole>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<ProjectRole>(requestInfo, ProjectRole.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Creates a new project role with no [default actors](#api-rest-api-3-resolution-get). You can use the [Add default actors to project role](#api-rest-api-3-role-id-actors-post) operation to add default actors to the project role after creating it.*Note that although a new project role is available to all projects upon creation, any default actors that are associated with the project role are not added to projects that existed prior to the role being created.*&lt;**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="ProjectRole"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ProjectRole?> PostAsync(CreateUpdateRoleRequestBean body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ProjectRole> PostAsync(CreateUpdateRoleRequestBean body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<ProjectRole>(requestInfo, ProjectRole.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a list of all project roles, complete with project role details and default actors.### About project roles ###[Project roles](https://support.atlassian.com/jira-cloud-administration/docs/manage-project-roles/) are a flexible way to to associate users and groups with projects. In Jira Cloud, the list of project roles is shared globally with all projects, but each project can have a different set of actors associated with it (unlike groups, which have the same membership throughout all Jira applications).Project roles are used in [permission schemes](#api-rest-api-3-permissionscheme-get), [email notification schemes](#api-rest-api-3-notificationscheme-get), [issue security levels](#api-rest-api-3-issuesecurityschemes-get), [comment visibility](#api-rest-api-3-comment-list-post), and workflow conditions.#### Members and actors ####In the Jira REST API, a member of a project role is called an *actor*. An *actor* is a group or user associated with a project role.Actors may be set as [default members](https://support.atlassian.com/jira-cloud-administration/docs/manage-project-roles/#Specifying-&apos;default-members&apos;-for-a-project-role) of the project role or set at the project level: *  Default actors: Users and groups that are assigned to the project role for all newly created projects. The default actors can be removed at the project level later if desired. *  Actors: Users and groups that are associated with a project role for a project, which may differ from the default actors. This enables you to assign a user to different roles in different projects.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new project role with no [default actors](#api-rest-api-3-resolution-get). You can use the [Add default actors to project role](#api-rest-api-3-role-id-actors-post) operation to add default actors to the project role after creating it.*Note that although a new project role is available to all projects upon creation, any default actors that are associated with the project role are not added to projects that existed prior to the role being created.*&lt;**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CreateUpdateRoleRequestBean body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CreateUpdateRoleRequestBean body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="RoleRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RoleRequestBuilder WithUrl(string rawUrl)
        {
            return new RoleRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RoleRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RoleRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
