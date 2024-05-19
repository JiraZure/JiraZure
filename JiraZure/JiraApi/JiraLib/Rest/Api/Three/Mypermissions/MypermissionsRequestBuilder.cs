// <auto-generated/>
using JiraLib.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Mypermissions {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\mypermissions
    /// </summary>
    public class MypermissionsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="MypermissionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MypermissionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/mypermissions{?commentId*,issueId*,issueKey*,permissions*,projectConfigurationUuid*,projectId*,projectKey*,projectUuid*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MypermissionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MypermissionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/mypermissions{?commentId*,issueId*,issueKey*,permissions*,projectConfigurationUuid*,projectId*,projectKey*,projectUuid*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of permissions indicating which permissions the user has. Details of the user&apos;s permissions can be obtained in a global, project, issue or comment context.The user is reported as having a project permission: *  in the global context, if the user has the project permission in any project. *  for a project, where the project permission is determined using issue data, if the user meets the permission&apos;s criteria for any issue in the project. Otherwise, if the user has the project permission in the project. *  for an issue, where a project permission is determined using issue data, if the user has the permission in the issue. Otherwise, if the user has the project permission in the project containing the issue. *  for a comment, where the user has both the permission to browse the comment and the project permission for the comment&apos;s parent issue. Only the BROWSE\_PROJECTS permission is supported. If a `commentId` is provided whose `permissions` does not equal BROWSE\_PROJECTS, a 400 error will be returned.This means that users may be shown as having an issue permission (such as EDIT\_ISSUES) in the global context or a project context but may not have the permission for any or all issues. For example, if Reporters have the EDIT\_ISSUES permission a user would be shown as having this permission in the global context or the context of a project, because any user can be a reporter. However, if they are not the user who reported the issue queried they would not have EDIT\_ISSUES permission for that issue.Global permissions are unaffected by context.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <returns>A <see cref="JiraLib.Models.Permissions"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ErrorCollection">When receiving a 400 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 401 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraLib.Models.Permissions?> GetAsync(Action<RequestConfiguration<MypermissionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<JiraLib.Models.Permissions> GetAsync(Action<RequestConfiguration<MypermissionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"401", ErrorCollection.CreateFromDiscriminatorValue},
                {"404", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<JiraLib.Models.Permissions>(requestInfo, JiraLib.Models.Permissions.CreateFromDiscriminatorValue, errorMapping,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of permissions indicating which permissions the user has. Details of the user&apos;s permissions can be obtained in a global, project, issue or comment context.The user is reported as having a project permission: *  in the global context, if the user has the project permission in any project. *  for a project, where the project permission is determined using issue data, if the user meets the permission&apos;s criteria for any issue in the project. Otherwise, if the user has the project permission in the project. *  for an issue, where a project permission is determined using issue data, if the user has the permission in the issue. Otherwise, if the user has the project permission in the project containing the issue. *  for a comment, where the user has both the permission to browse the comment and the project permission for the comment&apos;s parent issue. Only the BROWSE\_PROJECTS permission is supported. If a `commentId` is provided whose `permissions` does not equal BROWSE\_PROJECTS, a 400 error will be returned.This means that users may be shown as having an issue permission (such as EDIT\_ISSUES) in the global context or a project context but may not have the permission for any or all issues. For example, if Reporters have the EDIT\_ISSUES permission a user would be shown as having this permission in the global context or the context of a project, because any user can be a reporter. However, if they are not the user who reported the issue queried they would not have EDIT\_ISSUES permission for that issue.Global permissions are unaffected by context.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MypermissionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MypermissionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="MypermissionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MypermissionsRequestBuilder WithUrl(string rawUrl)
        {
            return new MypermissionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of permissions indicating which permissions the user has. Details of the user&apos;s permissions can be obtained in a global, project, issue or comment context.The user is reported as having a project permission: *  in the global context, if the user has the project permission in any project. *  for a project, where the project permission is determined using issue data, if the user meets the permission&apos;s criteria for any issue in the project. Otherwise, if the user has the project permission in the project. *  for an issue, where a project permission is determined using issue data, if the user has the permission in the issue. Otherwise, if the user has the project permission in the project containing the issue. *  for a comment, where the user has both the permission to browse the comment and the project permission for the comment&apos;s parent issue. Only the BROWSE\_PROJECTS permission is supported. If a `commentId` is provided whose `permissions` does not equal BROWSE\_PROJECTS, a 400 error will be returned.This means that users may be shown as having an issue permission (such as EDIT\_ISSUES) in the global context or a project context but may not have the permission for any or all issues. For example, if Reporters have the EDIT\_ISSUES permission a user would be shown as having this permission in the global context or the context of a project, because any user can be a reporter. However, if they are not the user who reported the issue queried they would not have EDIT\_ISSUES permission for that issue.Global permissions are unaffected by context.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        public class MypermissionsRequestBuilderGetQueryParameters 
        {
            /// <summary>The ID of the comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("commentId")]
            public string? CommentId { get; set; }
#nullable restore
#else
            [QueryParameter("commentId")]
            public string CommentId { get; set; }
#endif
            /// <summary>The ID of the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("issueId")]
            public string? IssueId { get; set; }
#nullable restore
#else
            [QueryParameter("issueId")]
            public string IssueId { get; set; }
#endif
            /// <summary>The key of the issue. Ignored if `issueId` is provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("issueKey")]
            public string? IssueKey { get; set; }
#nullable restore
#else
            [QueryParameter("issueKey")]
            public string IssueKey { get; set; }
#endif
            /// <summary>A list of permission keys. (Required) This parameter accepts a comma-separated list. To get the list of available permissions, use [Get all permissions](#api-rest-api-3-permissions-get).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("permissions")]
            public string? Permissions { get; set; }
#nullable restore
#else
            [QueryParameter("permissions")]
            public string Permissions { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("projectConfigurationUuid")]
            public string? ProjectConfigurationUuid { get; set; }
#nullable restore
#else
            [QueryParameter("projectConfigurationUuid")]
            public string ProjectConfigurationUuid { get; set; }
#endif
            /// <summary>The ID of project.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("projectId")]
            public string? ProjectId { get; set; }
#nullable restore
#else
            [QueryParameter("projectId")]
            public string ProjectId { get; set; }
#endif
            /// <summary>The key of project. Ignored if `projectId` is provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("projectKey")]
            public string? ProjectKey { get; set; }
#nullable restore
#else
            [QueryParameter("projectKey")]
            public string ProjectKey { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("projectUuid")]
            public string? ProjectUuid { get; set; }
#nullable restore
#else
            [QueryParameter("projectUuid")]
            public string ProjectUuid { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MypermissionsRequestBuilderGetRequestConfiguration : RequestConfiguration<MypermissionsRequestBuilderGetQueryParameters> 
        {
        }
    }
}
