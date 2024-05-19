// <auto-generated/>
using JiraLib.Models;
using JiraLib.Rest.Api.Three.Permissionscheme.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Permissionscheme {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\permissionscheme
    /// </summary>
    public class PermissionschemeRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the JiraLib.rest.api.Three.permissionscheme.item collection</summary>
        /// <param name="position">The ID of the permission scheme being deleted.</param>
        /// <returns>A <see cref="WithSchemeItemRequestBuilder"/></returns>
        public WithSchemeItemRequestBuilder this[long position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("schemeId", position);
                return new WithSchemeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the JiraLib.rest.api.Three.permissionscheme.item collection</summary>
        /// <param name="position">The ID of the permission scheme being deleted.</param>
        /// <returns>A <see cref="WithSchemeItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithSchemeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("schemeId", position);
                return new WithSchemeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="PermissionschemeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermissionschemeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/permissionscheme{?expand*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PermissionschemeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PermissionschemeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/permissionscheme{?expand*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns all permission schemes.### About permission schemes and grants ###A permission scheme is a collection of permission grants. A permission grant consists of a `holder` and a `permission`.#### Holder object ####The `holder` object contains information about the user or group being granted the permission. For example, the *Administer projects* permission is granted to a group named *Teams in space administrators*. In this case, the type is `&quot;type&quot;: &quot;group&quot;`, and the parameter is the group name, `&quot;parameter&quot;: &quot;Teams in space administrators&quot;` and the value is group ID, `&quot;value&quot;: &quot;ca85fac0-d974-40ca-a615-7af99c48d24f&quot;`.The `holder` object is defined by the following properties: *  `type` Identifies the user or group (see the list of types below). *  `parameter` As a group&apos;s name can change, use of `value` is recommended. The value of this property depends on the `type`. For example, if the `type` is a group, then you need to specify the group name. *  `value` The value of this property depends on the `type`. If the `type` is a group, then you need to specify the group ID. For other `type` it has the same value as `parameter`The following `types` are available. The expected values for `parameter` and `value` are given in parentheses (some types may not have a `parameter` or `value`): *  `anyone` Grant for anonymous users. *  `applicationRole` Grant for users with access to the specified application (application name, application name). See [Update product access settings](https://confluence.atlassian.com/x/3YxjL) for more information. *  `assignee` Grant for the user currently assigned to an issue. *  `group` Grant for the specified group (`parameter` : group name, `value` : group ID). *  `groupCustomField` Grant for a user in the group selected in the specified custom field (`parameter` : custom field ID, `value` : custom field ID). *  `projectLead` Grant for a project lead. *  `projectRole` Grant for the specified project role (`parameter` :project role ID, `value` : project role ID). *  `reporter` Grant for the user who reported the issue. *  `sd.customer.portal.only` Jira Service Desk only. Grants customers permission to access the customer portal but not Jira. See [Customizing Jira Service Desk permissions](https://confluence.atlassian.com/x/24dKLg) for more information. *  `user` Grant for the specified user (`parameter` : user ID - historically this was the userkey but that is deprecated and the account ID should be used, `value` : user ID). *  `userCustomField` Grant for a user selected in the specified custom field (`parameter` : custom field ID, `value` : custom field ID).#### Built-in permissions ####The [built-in Jira permissions](https://confluence.atlassian.com/x/yodKLg) are listed below. Apps can also define custom permissions. See the [project permission](https://developer.atlassian.com/cloud/jira/platform/modules/project-permission/) and [global permission](https://developer.atlassian.com/cloud/jira/platform/modules/global-permission/) module documentation for more information.**Project permissions** *  `ADMINISTER_PROJECTS` *  `BROWSE_PROJECTS` *  `MANAGE_SPRINTS_PERMISSION` (Jira Software only) *  `SERVICEDESK_AGENT` (Jira Service Desk only) *  `VIEW_DEV_TOOLS` (Jira Software only) *  `VIEW_READONLY_WORKFLOW`**Issue permissions** *  `ASSIGNABLE_USER` *  `ASSIGN_ISSUES` *  `CLOSE_ISSUES` *  `CREATE_ISSUES` *  `DELETE_ISSUES` *  `EDIT_ISSUES` *  `LINK_ISSUES` *  `MODIFY_REPORTER` *  `MOVE_ISSUES` *  `RESOLVE_ISSUES` *  `SCHEDULE_ISSUES` *  `SET_ISSUE_SECURITY` *  `TRANSITION_ISSUES`**Voters and watchers permissions** *  `MANAGE_WATCHERS` *  `VIEW_VOTERS_AND_WATCHERS`**Comments permissions** *  `ADD_COMMENTS` *  `DELETE_ALL_COMMENTS` *  `DELETE_OWN_COMMENTS` *  `EDIT_ALL_COMMENTS` *  `EDIT_OWN_COMMENTS`**Attachments permissions** *  `CREATE_ATTACHMENTS` *  `DELETE_ALL_ATTACHMENTS` *  `DELETE_OWN_ATTACHMENTS`**Time tracking permissions** *  `DELETE_ALL_WORKLOGS` *  `DELETE_OWN_WORKLOGS` *  `EDIT_ALL_WORKLOGS` *  `EDIT_OWN_WORKLOGS` *  `WORK_ON_ISSUES`**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <returns>A <see cref="PermissionSchemes"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PermissionSchemes?> GetAsync(Action<RequestConfiguration<PermissionschemeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PermissionSchemes> GetAsync(Action<RequestConfiguration<PermissionschemeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<PermissionSchemes>(requestInfo, PermissionSchemes.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new permission scheme. You can create a permission scheme with or without defining a set of permission grants.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="JiraLib.Models.PermissionScheme"/></returns>
        /// <param name="body">Details of a permission scheme.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraLib.Models.PermissionScheme?> PostAsync(JiraLib.Models.PermissionScheme body, Action<RequestConfiguration<PermissionschemeRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<JiraLib.Models.PermissionScheme> PostAsync(JiraLib.Models.PermissionScheme body, Action<RequestConfiguration<PermissionschemeRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<JiraLib.Models.PermissionScheme>(requestInfo, JiraLib.Models.PermissionScheme.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns all permission schemes.### About permission schemes and grants ###A permission scheme is a collection of permission grants. A permission grant consists of a `holder` and a `permission`.#### Holder object ####The `holder` object contains information about the user or group being granted the permission. For example, the *Administer projects* permission is granted to a group named *Teams in space administrators*. In this case, the type is `&quot;type&quot;: &quot;group&quot;`, and the parameter is the group name, `&quot;parameter&quot;: &quot;Teams in space administrators&quot;` and the value is group ID, `&quot;value&quot;: &quot;ca85fac0-d974-40ca-a615-7af99c48d24f&quot;`.The `holder` object is defined by the following properties: *  `type` Identifies the user or group (see the list of types below). *  `parameter` As a group&apos;s name can change, use of `value` is recommended. The value of this property depends on the `type`. For example, if the `type` is a group, then you need to specify the group name. *  `value` The value of this property depends on the `type`. If the `type` is a group, then you need to specify the group ID. For other `type` it has the same value as `parameter`The following `types` are available. The expected values for `parameter` and `value` are given in parentheses (some types may not have a `parameter` or `value`): *  `anyone` Grant for anonymous users. *  `applicationRole` Grant for users with access to the specified application (application name, application name). See [Update product access settings](https://confluence.atlassian.com/x/3YxjL) for more information. *  `assignee` Grant for the user currently assigned to an issue. *  `group` Grant for the specified group (`parameter` : group name, `value` : group ID). *  `groupCustomField` Grant for a user in the group selected in the specified custom field (`parameter` : custom field ID, `value` : custom field ID). *  `projectLead` Grant for a project lead. *  `projectRole` Grant for the specified project role (`parameter` :project role ID, `value` : project role ID). *  `reporter` Grant for the user who reported the issue. *  `sd.customer.portal.only` Jira Service Desk only. Grants customers permission to access the customer portal but not Jira. See [Customizing Jira Service Desk permissions](https://confluence.atlassian.com/x/24dKLg) for more information. *  `user` Grant for the specified user (`parameter` : user ID - historically this was the userkey but that is deprecated and the account ID should be used, `value` : user ID). *  `userCustomField` Grant for a user selected in the specified custom field (`parameter` : custom field ID, `value` : custom field ID).#### Built-in permissions ####The [built-in Jira permissions](https://confluence.atlassian.com/x/yodKLg) are listed below. Apps can also define custom permissions. See the [project permission](https://developer.atlassian.com/cloud/jira/platform/modules/project-permission/) and [global permission](https://developer.atlassian.com/cloud/jira/platform/modules/global-permission/) module documentation for more information.**Project permissions** *  `ADMINISTER_PROJECTS` *  `BROWSE_PROJECTS` *  `MANAGE_SPRINTS_PERMISSION` (Jira Software only) *  `SERVICEDESK_AGENT` (Jira Service Desk only) *  `VIEW_DEV_TOOLS` (Jira Software only) *  `VIEW_READONLY_WORKFLOW`**Issue permissions** *  `ASSIGNABLE_USER` *  `ASSIGN_ISSUES` *  `CLOSE_ISSUES` *  `CREATE_ISSUES` *  `DELETE_ISSUES` *  `EDIT_ISSUES` *  `LINK_ISSUES` *  `MODIFY_REPORTER` *  `MOVE_ISSUES` *  `RESOLVE_ISSUES` *  `SCHEDULE_ISSUES` *  `SET_ISSUE_SECURITY` *  `TRANSITION_ISSUES`**Voters and watchers permissions** *  `MANAGE_WATCHERS` *  `VIEW_VOTERS_AND_WATCHERS`**Comments permissions** *  `ADD_COMMENTS` *  `DELETE_ALL_COMMENTS` *  `DELETE_OWN_COMMENTS` *  `EDIT_ALL_COMMENTS` *  `EDIT_OWN_COMMENTS`**Attachments permissions** *  `CREATE_ATTACHMENTS` *  `DELETE_ALL_ATTACHMENTS` *  `DELETE_OWN_ATTACHMENTS`**Time tracking permissions** *  `DELETE_ALL_WORKLOGS` *  `DELETE_OWN_WORKLOGS` *  `EDIT_ALL_WORKLOGS` *  `EDIT_OWN_WORKLOGS` *  `WORK_ON_ISSUES`**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PermissionschemeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PermissionschemeRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new permission scheme. You can create a permission scheme with or without defining a set of permission grants.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Details of a permission scheme.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(JiraLib.Models.PermissionScheme body, Action<RequestConfiguration<PermissionschemeRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(JiraLib.Models.PermissionScheme body, Action<RequestConfiguration<PermissionschemeRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="PermissionschemeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PermissionschemeRequestBuilder WithUrl(string rawUrl)
        {
            return new PermissionschemeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns all permission schemes.### About permission schemes and grants ###A permission scheme is a collection of permission grants. A permission grant consists of a `holder` and a `permission`.#### Holder object ####The `holder` object contains information about the user or group being granted the permission. For example, the *Administer projects* permission is granted to a group named *Teams in space administrators*. In this case, the type is `&quot;type&quot;: &quot;group&quot;`, and the parameter is the group name, `&quot;parameter&quot;: &quot;Teams in space administrators&quot;` and the value is group ID, `&quot;value&quot;: &quot;ca85fac0-d974-40ca-a615-7af99c48d24f&quot;`.The `holder` object is defined by the following properties: *  `type` Identifies the user or group (see the list of types below). *  `parameter` As a group&apos;s name can change, use of `value` is recommended. The value of this property depends on the `type`. For example, if the `type` is a group, then you need to specify the group name. *  `value` The value of this property depends on the `type`. If the `type` is a group, then you need to specify the group ID. For other `type` it has the same value as `parameter`The following `types` are available. The expected values for `parameter` and `value` are given in parentheses (some types may not have a `parameter` or `value`): *  `anyone` Grant for anonymous users. *  `applicationRole` Grant for users with access to the specified application (application name, application name). See [Update product access settings](https://confluence.atlassian.com/x/3YxjL) for more information. *  `assignee` Grant for the user currently assigned to an issue. *  `group` Grant for the specified group (`parameter` : group name, `value` : group ID). *  `groupCustomField` Grant for a user in the group selected in the specified custom field (`parameter` : custom field ID, `value` : custom field ID). *  `projectLead` Grant for a project lead. *  `projectRole` Grant for the specified project role (`parameter` :project role ID, `value` : project role ID). *  `reporter` Grant for the user who reported the issue. *  `sd.customer.portal.only` Jira Service Desk only. Grants customers permission to access the customer portal but not Jira. See [Customizing Jira Service Desk permissions](https://confluence.atlassian.com/x/24dKLg) for more information. *  `user` Grant for the specified user (`parameter` : user ID - historically this was the userkey but that is deprecated and the account ID should be used, `value` : user ID). *  `userCustomField` Grant for a user selected in the specified custom field (`parameter` : custom field ID, `value` : custom field ID).#### Built-in permissions ####The [built-in Jira permissions](https://confluence.atlassian.com/x/yodKLg) are listed below. Apps can also define custom permissions. See the [project permission](https://developer.atlassian.com/cloud/jira/platform/modules/project-permission/) and [global permission](https://developer.atlassian.com/cloud/jira/platform/modules/global-permission/) module documentation for more information.**Project permissions** *  `ADMINISTER_PROJECTS` *  `BROWSE_PROJECTS` *  `MANAGE_SPRINTS_PERMISSION` (Jira Software only) *  `SERVICEDESK_AGENT` (Jira Service Desk only) *  `VIEW_DEV_TOOLS` (Jira Software only) *  `VIEW_READONLY_WORKFLOW`**Issue permissions** *  `ASSIGNABLE_USER` *  `ASSIGN_ISSUES` *  `CLOSE_ISSUES` *  `CREATE_ISSUES` *  `DELETE_ISSUES` *  `EDIT_ISSUES` *  `LINK_ISSUES` *  `MODIFY_REPORTER` *  `MOVE_ISSUES` *  `RESOLVE_ISSUES` *  `SCHEDULE_ISSUES` *  `SET_ISSUE_SECURITY` *  `TRANSITION_ISSUES`**Voters and watchers permissions** *  `MANAGE_WATCHERS` *  `VIEW_VOTERS_AND_WATCHERS`**Comments permissions** *  `ADD_COMMENTS` *  `DELETE_ALL_COMMENTS` *  `DELETE_OWN_COMMENTS` *  `EDIT_ALL_COMMENTS` *  `EDIT_OWN_COMMENTS`**Attachments permissions** *  `CREATE_ATTACHMENTS` *  `DELETE_ALL_ATTACHMENTS` *  `DELETE_OWN_ATTACHMENTS`**Time tracking permissions** *  `DELETE_ALL_WORKLOGS` *  `DELETE_OWN_WORKLOGS` *  `EDIT_ALL_WORKLOGS` *  `EDIT_OWN_WORKLOGS` *  `WORK_ON_ISSUES`**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        public class PermissionschemeRequestBuilderGetQueryParameters 
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
        public class PermissionschemeRequestBuilderGetRequestConfiguration : RequestConfiguration<PermissionschemeRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Creates a new permission scheme. You can create a permission scheme with or without defining a set of permission grants.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class PermissionschemeRequestBuilderPostQueryParameters 
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
        public class PermissionschemeRequestBuilderPostRequestConfiguration : RequestConfiguration<PermissionschemeRequestBuilderPostQueryParameters> 
        {
        }
    }
}
