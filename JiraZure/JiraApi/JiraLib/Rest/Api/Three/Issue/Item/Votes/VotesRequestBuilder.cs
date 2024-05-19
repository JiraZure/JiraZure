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
namespace JiraLib.Rest.Api.Three.Issue.Item.Votes {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\issue\{issueIdOrKey}\votes
    /// </summary>
    public class VotesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="VotesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VotesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issue/{issueIdOrKey}/votes", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="VotesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VotesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issue/{issueIdOrKey}/votes", rawUrl)
        {
        }
        /// <summary>
        /// Deletes a user&apos;s vote from an issue. This is the equivalent of the user clicking *Unvote* on an issue in Jira.This operation requires the **Allow users to vote on issues** option to be *ON*. This option is set in General configuration for Jira. See [Configuring Jira application options](https://confluence.atlassian.com/x/uYXKM) for details.**[Permissions](#permissions) required:** *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is in. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue.
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
            await RequestAdapter.SendNoContentAsync(requestInfo, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns details about the votes on an issue.This operation requires the **Allow users to vote on issues** option to be *ON*. This option is set in General configuration for Jira. See [Configuring Jira application options](https://confluence.atlassian.com/x/uYXKM) for details.This operation can be accessed anonymously.**[Permissions](#permissions) required:** *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is ini *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue.Note that users with the necessary permissions for this operation but without the *View voters and watchers* project permissions are not returned details in the `voters` field.
        /// </summary>
        /// <returns>A <see cref="JiraLib.Models.Votes"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraLib.Models.Votes?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<JiraLib.Models.Votes> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<JiraLib.Models.Votes>(requestInfo, JiraLib.Models.Votes.CreateFromDiscriminatorValue, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Adds the user&apos;s vote to an issue. This is the equivalent of the user clicking *Vote* on an issue in Jira.This operation requires the **Allow users to vote on issues** option to be *ON*. This option is set in General configuration for Jira. See [Configuring Jira application options](https://confluence.atlassian.com/x/uYXKM) for details.**[Permissions](#permissions) required:** *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is in. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a user&apos;s vote from an issue. This is the equivalent of the user clicking *Unvote* on an issue in Jira.This operation requires the **Allow users to vote on issues** option to be *ON*. This option is set in General configuration for Jira. See [Configuring Jira application options](https://confluence.atlassian.com/x/uYXKM) for details.**[Permissions](#permissions) required:** *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is in. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue.
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
        /// Returns details about the votes on an issue.This operation requires the **Allow users to vote on issues** option to be *ON*. This option is set in General configuration for Jira. See [Configuring Jira application options](https://confluence.atlassian.com/x/uYXKM) for details.This operation can be accessed anonymously.**[Permissions](#permissions) required:** *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is ini *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue.Note that users with the necessary permissions for this operation but without the *View voters and watchers* project permissions are not returned details in the `voters` field.
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
        /// Adds the user&apos;s vote to an issue. This is the equivalent of the user clicking *Vote* on an issue in Jira.This operation requires the **Allow users to vote on issues** option to be *ON*. This option is set in General configuration for Jira. See [Configuring Jira application options](https://confluence.atlassian.com/x/uYXKM) for details.**[Permissions](#permissions) required:** *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is in. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="VotesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public VotesRequestBuilder WithUrl(string rawUrl)
        {
            return new VotesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class VotesRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class VotesRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class VotesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
