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
namespace JiraLib.Rest.Api.Three.Worklog.List {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\worklog\list
    /// </summary>
    public class ListRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ListRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/worklog/list{?expand*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ListRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/worklog/list{?expand*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns worklog details for a list of worklog IDs.The returned list of worklogs is limited to 1000 items.**[Permissions](#permissions) required:** Permission to access Jira, however, worklogs are only returned where either of the following is true: *  the worklog is set as *Viewable by All Users*. *  the user is a member of a project role or group with permission to view the worklog.
        /// </summary>
        /// <returns>A List&lt;JiraLib.Models.Worklog&gt;</returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<JiraLib.Models.Worklog>?> PostAsync(WorklogIdsRequestBean body, Action<RequestConfiguration<ListRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<JiraLib.Models.Worklog>> PostAsync(WorklogIdsRequestBean body, Action<RequestConfiguration<ListRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<JiraLib.Models.Worklog>(requestInfo, JiraLib.Models.Worklog.CreateFromDiscriminatorValue, default,cancellationToken: cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Returns worklog details for a list of worklog IDs.The returned list of worklogs is limited to 1000 items.**[Permissions](#permissions) required:** Permission to access Jira, however, worklogs are only returned where either of the following is true: *  the worklog is set as *Viewable by All Users*. *  the user is a member of a project role or group with permission to view the worklog.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(WorklogIdsRequestBean body, Action<RequestConfiguration<ListRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(WorklogIdsRequestBean body, Action<RequestConfiguration<ListRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="ListRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ListRequestBuilder WithUrl(string rawUrl)
        {
            return new ListRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns worklog details for a list of worklog IDs.The returned list of worklogs is limited to 1000 items.**[Permissions](#permissions) required:** Permission to access Jira, however, worklogs are only returned where either of the following is true: *  the worklog is set as *Viewable by All Users*. *  the user is a member of a project role or group with permission to view the worklog.
        /// </summary>
        public class ListRequestBuilderPostQueryParameters 
        {
            /// <summary>Use [expand](#expansion) to include additional information about worklogs in the response. This parameter accepts `properties` that returns the properties of each worklog.</summary>
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
        public class ListRequestBuilderPostRequestConfiguration : RequestConfiguration<ListRequestBuilderPostQueryParameters> 
        {
        }
    }
}
