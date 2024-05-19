// <auto-generated/>
using JiraLib.Models;
using JiraLib.Rest.Api.Three.Issue.Item.Worklog.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Issue.Item.Worklog {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\issue\{issueIdOrKey}\worklog
    /// </summary>
    public class WorklogRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the JiraLib.rest.api.Three.issue.item.worklog.item collection</summary>
        /// <param name="position">The ID of the worklog.</param>
        /// <returns>A <see cref="ItemRequestBuilder"/></returns>
        public ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("%2Did", position);
                return new ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="WorklogRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorklogRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issue/{issueIdOrKey}/worklog{?adjustEstimate*,expand*,maxResults*,newEstimate*,notifyUsers*,overrideEditableFlag*,reduceBy*,startAt*,startedAfter*,startedBefore*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WorklogRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorklogRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issue/{issueIdOrKey}/worklog{?adjustEstimate*,expand*,maxResults*,newEstimate*,notifyUsers*,overrideEditableFlag*,reduceBy*,startAt*,startedAfter*,startedBefore*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns worklogs for an issue, starting from the oldest worklog or from the worklog started on or after a date and time.Time tracking must be enabled in Jira, otherwise this operation returns an error. For more information, see [Configuring time tracking](https://confluence.atlassian.com/x/qoXKM).This operation can be accessed anonymously.**[Permissions](#permissions) required:** Workloads are only returned where the user has: *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is in. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue. *  If the worklog has visibility restrictions, belongs to the group or has the role visibility is restricted to.
        /// </summary>
        /// <returns>A <see cref="PageOfWorklogs"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageOfWorklogs?> GetAsync(Action<RequestConfiguration<WorklogRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PageOfWorklogs> GetAsync(Action<RequestConfiguration<WorklogRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<PageOfWorklogs>(requestInfo, PageOfWorklogs.CreateFromDiscriminatorValue, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Adds a worklog to an issue.Time tracking must be enabled in Jira, otherwise this operation returns an error. For more information, see [Configuring time tracking](https://confluence.atlassian.com/x/qoXKM).This operation can be accessed anonymously.**[Permissions](#permissions) required:** *  *Browse projects* and *Work on issues* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is in. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue.
        /// </summary>
        /// <returns>A <see cref="JiraLib.Models.Worklog"/></returns>
        /// <param name="body">Details of a worklog.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraLib.Models.Worklog?> PostAsync(JiraLib.Models.Worklog body, Action<RequestConfiguration<WorklogRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<JiraLib.Models.Worklog> PostAsync(JiraLib.Models.Worklog body, Action<RequestConfiguration<WorklogRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<JiraLib.Models.Worklog>(requestInfo, JiraLib.Models.Worklog.CreateFromDiscriminatorValue, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns worklogs for an issue, starting from the oldest worklog or from the worklog started on or after a date and time.Time tracking must be enabled in Jira, otherwise this operation returns an error. For more information, see [Configuring time tracking](https://confluence.atlassian.com/x/qoXKM).This operation can be accessed anonymously.**[Permissions](#permissions) required:** Workloads are only returned where the user has: *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is in. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue. *  If the worklog has visibility restrictions, belongs to the group or has the role visibility is restricted to.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorklogRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorklogRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Adds a worklog to an issue.Time tracking must be enabled in Jira, otherwise this operation returns an error. For more information, see [Configuring time tracking](https://confluence.atlassian.com/x/qoXKM).This operation can be accessed anonymously.**[Permissions](#permissions) required:** *  *Browse projects* and *Work on issues* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is in. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Details of a worklog.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(JiraLib.Models.Worklog body, Action<RequestConfiguration<WorklogRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(JiraLib.Models.Worklog body, Action<RequestConfiguration<WorklogRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="WorklogRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WorklogRequestBuilder WithUrl(string rawUrl)
        {
            return new WorklogRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns worklogs for an issue, starting from the oldest worklog or from the worklog started on or after a date and time.Time tracking must be enabled in Jira, otherwise this operation returns an error. For more information, see [Configuring time tracking](https://confluence.atlassian.com/x/qoXKM).This operation can be accessed anonymously.**[Permissions](#permissions) required:** Workloads are only returned where the user has: *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is in. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue. *  If the worklog has visibility restrictions, belongs to the group or has the role visibility is restricted to.
        /// </summary>
        public class WorklogRequestBuilderGetQueryParameters 
        {
            /// <summary>Use [expand](#expansion) to include additional information about worklogs in the response. This parameter accepts`properties`, which returns worklog properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResults")]
            public int? MaxResults { get; set; }
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public long? StartAt { get; set; }
            /// <summary>The worklog start date and time, as a UNIX timestamp in milliseconds, after which worklogs are returned.</summary>
            [QueryParameter("startedAfter")]
            public long? StartedAfter { get; set; }
            /// <summary>The worklog start date and time, as a UNIX timestamp in milliseconds, before which worklogs are returned.</summary>
            [QueryParameter("startedBefore")]
            public long? StartedBefore { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WorklogRequestBuilderGetRequestConfiguration : RequestConfiguration<WorklogRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Adds a worklog to an issue.Time tracking must be enabled in Jira, otherwise this operation returns an error. For more information, see [Configuring time tracking](https://confluence.atlassian.com/x/qoXKM).This operation can be accessed anonymously.**[Permissions](#permissions) required:** *  *Browse projects* and *Work on issues* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that the issue is in. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue.
        /// </summary>
        public class WorklogRequestBuilderPostQueryParameters 
        {
            /// <summary>Defines how to update the issue&apos;s time estimate, the options are: *  `new` Sets the estimate to a specific value, defined in `newEstimate`. *  `leave` Leaves the estimate unchanged. *  `manual` Reduces the estimate by amount specified in `reduceBy`. *  `auto` Reduces the estimate by the value of `timeSpent` in the worklog.</summary>
            [Obsolete("This property is deprecated, use AdjustEstimateAsPostAdjustEstimateQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("adjustEstimate")]
            public string? AdjustEstimate { get; set; }
#nullable restore
#else
            [QueryParameter("adjustEstimate")]
            public string AdjustEstimate { get; set; }
#endif
            /// <summary>Defines how to update the issue&apos;s time estimate, the options are: *  `new` Sets the estimate to a specific value, defined in `newEstimate`. *  `leave` Leaves the estimate unchanged. *  `manual` Reduces the estimate by amount specified in `reduceBy`. *  `auto` Reduces the estimate by the value of `timeSpent` in the worklog.</summary>
            [QueryParameter("adjustEstimate")]
            public PostAdjustEstimateQueryParameterType? AdjustEstimateAsPostAdjustEstimateQueryParameterType { get; set; }
            /// <summary>Use [expand](#expansion) to include additional information about work logs in the response. This parameter accepts `properties`, which returns worklog properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>The value to set as the issue&apos;s remaining time estimate, as days (\#d), hours (\#h), or minutes (\#m or \#). For example, *2d*. Required when `adjustEstimate` is `new`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("newEstimate")]
            public string? NewEstimate { get; set; }
#nullable restore
#else
            [QueryParameter("newEstimate")]
            public string NewEstimate { get; set; }
#endif
            /// <summary>Whether users watching the issue are notified by email.</summary>
            [QueryParameter("notifyUsers")]
            public bool? NotifyUsers { get; set; }
            /// <summary>Whether the worklog entry should be added to the issue even if the issue is not editable, because jira.issue.editable set to false or missing. For example, the issue is closed. Connect and Forge app users with *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg) can use this flag.</summary>
            [QueryParameter("overrideEditableFlag")]
            public bool? OverrideEditableFlag { get; set; }
            /// <summary>The amount to reduce the issue&apos;s remaining estimate by, as days (\#d), hours (\#h), or minutes (\#m). For example, *2d*. Required when `adjustEstimate` is `manual`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("reduceBy")]
            public string? ReduceBy { get; set; }
#nullable restore
#else
            [QueryParameter("reduceBy")]
            public string ReduceBy { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WorklogRequestBuilderPostRequestConfiguration : RequestConfiguration<WorklogRequestBuilderPostQueryParameters> 
        {
        }
    }
}
