// <auto-generated/>
using JiraLib.Models;
using JiraLib.Rest.Api.Three.Configuration.Timetracking;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Configuration {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\configuration
    /// </summary>
    public class ConfigurationRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The timetracking property</summary>
        public TimetrackingRequestBuilder Timetracking
        {
            get => new TimetrackingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ConfigurationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigurationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/configuration", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ConfigurationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigurationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/configuration", rawUrl)
        {
        }
        /// <summary>
        /// Returns the [global settings](https://confluence.atlassian.com/x/qYXKM) in Jira. These settings determine whether optional features (for example, subtasks, time tracking, and others) are enabled. If time tracking is enabled, this operation also returns the time tracking configuration.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <returns>A <see cref="JiraLib.Models.Configuration"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraLib.Models.Configuration?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<JiraLib.Models.Configuration> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<JiraLib.Models.Configuration>(requestInfo, JiraLib.Models.Configuration.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the [global settings](https://confluence.atlassian.com/x/qYXKM) in Jira. These settings determine whether optional features (for example, subtasks, time tracking, and others) are enabled. If time tracking is enabled, this operation also returns the time tracking configuration.**[Permissions](#permissions) required:** Permission to access Jira.
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
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ConfigurationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ConfigurationRequestBuilder WithUrl(string rawUrl)
        {
            return new ConfigurationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ConfigurationRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
