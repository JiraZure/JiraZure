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
namespace JiraLib.Rest.Api.Three.User.Bulk.Migration {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\user\bulk\migration
    /// </summary>
    public class MigrationRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="MigrationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MigrationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/user/bulk/migration{?key*,maxResults*,startAt*,username*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="MigrationRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MigrationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/user/bulk/migration{?key*,maxResults*,startAt*,username*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the account IDs for the users specified in the `key` or `username` parameters. Note that multiple `key` or `username` parameters can be specified.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <returns>A List&lt;UserMigrationBean&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<UserMigrationBean>?> GetAsync(Action<RequestConfiguration<MigrationRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<UserMigrationBean>> GetAsync(Action<RequestConfiguration<MigrationRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<UserMigrationBean>(requestInfo, UserMigrationBean.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Returns the account IDs for the users specified in the `key` or `username` parameters. Note that multiple `key` or `username` parameters can be specified.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MigrationRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<MigrationRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="MigrationRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MigrationRequestBuilder WithUrl(string rawUrl)
        {
            return new MigrationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns the account IDs for the users specified in the `key` or `username` parameters. Note that multiple `key` or `username` parameters can be specified.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        public class MigrationRequestBuilderGetQueryParameters 
        {
            /// <summary>Key of a user. To specify multiple users, pass multiple copies of this parameter. For example, `key=fred&amp;key=barney`. Required if `username` isn&apos;t provided. Cannot be provided if `username` is present.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("key")]
            public string[]? Key { get; set; }
#nullable restore
#else
            [QueryParameter("key")]
            public string[] Key { get; set; }
#endif
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResults")]
            public int? MaxResults { get; set; }
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public long? StartAt { get; set; }
            /// <summary>Username of a user. To specify multiple users, pass multiple copies of this parameter. For example, `username=fred&amp;username=barney`. Required if `key` isn&apos;t provided. Cannot be provided if `key` is present.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("username")]
            public string[]? Username { get; set; }
#nullable restore
#else
            [QueryParameter("username")]
            public string[] Username { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class MigrationRequestBuilderGetRequestConfiguration : RequestConfiguration<MigrationRequestBuilderGetQueryParameters> 
        {
        }
    }
}
