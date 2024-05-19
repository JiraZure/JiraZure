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
namespace JiraLib.Rest.Api.Three.DataPolicy.Project {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\data-policy\project
    /// </summary>
    public class ProjectRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="ProjectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProjectRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/data-policy/project{?ids*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ProjectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProjectRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/data-policy/project{?ids*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns data policies for the projects specified in the request.
        /// </summary>
        /// <returns>A <see cref="ProjectDataPolicies"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ErrorCollection">When receiving a 400 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 401 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 403 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ProjectDataPolicies?> GetAsync(Action<RequestConfiguration<ProjectRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<ProjectDataPolicies> GetAsync(Action<RequestConfiguration<ProjectRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"401", ErrorCollection.CreateFromDiscriminatorValue},
                {"403", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ProjectDataPolicies>(requestInfo, ProjectDataPolicies.CreateFromDiscriminatorValue, errorMapping,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns data policies for the projects specified in the request.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ProjectRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ProjectRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="ProjectRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ProjectRequestBuilder WithUrl(string rawUrl)
        {
            return new ProjectRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns data policies for the projects specified in the request.
        /// </summary>
        public class ProjectRequestBuilderGetQueryParameters 
        {
            /// <summary>A list of project identifiers. This parameter accepts a comma-separated list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ids")]
            public string? Ids { get; set; }
#nullable restore
#else
            [QueryParameter("ids")]
            public string Ids { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ProjectRequestBuilderGetRequestConfiguration : RequestConfiguration<ProjectRequestBuilderGetQueryParameters> 
        {
        }
    }
}
