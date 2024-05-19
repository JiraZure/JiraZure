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
namespace JiraLib.Rest.Api.Three.Issuesecurityschemes.Item.Members {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\issuesecurityschemes\{-id}\members
    /// </summary>
    public class MembersRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="MembersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issuesecurityschemes/{%2Did}/members{?expand*,issueSecurityLevelId*,maxResults*,startAt*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MembersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MembersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issuesecurityschemes/{%2Did}/members{?expand*,issueSecurityLevelId*,maxResults*,startAt*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns issue security level members.Only issue security level members in context of classic projects are returned.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="PageBeanIssueSecurityLevelMember"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanIssueSecurityLevelMember?> GetAsync(Action<RequestConfiguration<MembersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PageBeanIssueSecurityLevelMember> GetAsync(Action<RequestConfiguration<MembersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<PageBeanIssueSecurityLevelMember>(requestInfo, PageBeanIssueSecurityLevelMember.CreateFromDiscriminatorValue, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns issue security level members.Only issue security level members in context of classic projects are returned.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MembersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MembersRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="MembersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MembersRequestBuilder WithUrl(string rawUrl)
        {
            return new MembersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns issue security level members.Only issue security level members in context of classic projects are returned.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class MembersRequestBuilderGetQueryParameters 
        {
            /// <summary>Use expand to include additional information in the response. This parameter accepts a comma-separated list. Expand options include: *  `all` Returns all expandable information. *  `field` Returns information about the custom field granted the permission. *  `group` Returns information about the group that is granted the permission. *  `projectRole` Returns information about the project role granted the permission. *  `user` Returns information about the user who is granted the permission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>The list of issue security level IDs. To include multiple issue security levels separate IDs with ampersand: `issueSecurityLevelId=10000&amp;issueSecurityLevelId=10001`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("issueSecurityLevelId")]
            public string[]? IssueSecurityLevelId { get; set; }
#nullable restore
#else
            [QueryParameter("issueSecurityLevelId")]
            public string[] IssueSecurityLevelId { get; set; }
#endif
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResults")]
            public int? MaxResults { get; set; }
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public long? StartAt { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MembersRequestBuilderGetRequestConfiguration : RequestConfiguration<MembersRequestBuilderGetQueryParameters> 
        {
        }
    }
}
