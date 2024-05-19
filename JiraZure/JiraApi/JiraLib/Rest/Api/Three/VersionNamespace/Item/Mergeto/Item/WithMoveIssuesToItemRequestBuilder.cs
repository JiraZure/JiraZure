// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.VersionNamespace.Item.Mergeto.Item {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\version\{-id}\mergeto\{moveIssuesTo}
    /// </summary>
    public class WithMoveIssuesToItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="WithMoveIssuesToItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMoveIssuesToItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/version/{%2Did}/mergeto/{moveIssuesTo}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithMoveIssuesToItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithMoveIssuesToItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/version/{%2Did}/mergeto/{moveIssuesTo}", rawUrl)
        {
        }
        /// <summary>
        /// Merges two project versions. The merge is completed by deleting the version specified in `id` and replacing any occurrences of its ID in `fixVersion` with the version ID specified in `moveIssuesTo`.Consider using [ Delete and replace version](#api-rest-api-3-version-id-removeAndSwap-post) instead. This resource supports swapping version values in `fixVersion`, `affectedVersion`, and custom fields.This operation can be accessed anonymously.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg) or *Administer Projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that contains the version.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PutAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PutAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPutRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Merges two project versions. The merge is completed by deleting the version specified in `id` and replacing any occurrences of its ID in `fixVersion` with the version ID specified in `moveIssuesTo`.Consider using [ Delete and replace version](#api-rest-api-3-version-id-removeAndSwap-post) instead. This resource supports swapping version values in `fixVersion`, `affectedVersion`, and custom fields.This operation can be accessed anonymously.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg) or *Administer Projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project that contains the version.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithMoveIssuesToItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithMoveIssuesToItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithMoveIssuesToItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithMoveIssuesToItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
