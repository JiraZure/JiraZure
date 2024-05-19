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
namespace JiraLib.Rest.Api.Three.User.Search.Query.Key {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\user\search\query\key
    /// </summary>
    public class KeyRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="KeyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public KeyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/user/search/query/key?query={query}{&maxResult*,startAt*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KeyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public KeyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/user/search/query/key?query={query}{&maxResult*,startAt*}", rawUrl)
        {
        }
        /// <summary>
        /// Finds users with a structured query and returns a [paginated](#pagination) list of user keys.This operation takes the users in the range defined by `startAt` and `maxResults`, up to the thousandth user, and then returns only the users from that range that match the structured query. This means the operation usually returns fewer users than specified in `maxResults`. To get all the users who match the structured query, use [Get all users](#api-rest-api-3-users-search-get) and filter the records in your code.**[Permissions](#permissions) required:** *Browse users and groups* [global permission](https://confluence.atlassian.com/x/x4dKLg).The query statements are: *  `is assignee of PROJ` Returns the users that are assignees of at least one issue in project *PROJ*. *  `is assignee of (PROJ-1, PROJ-2)` Returns users that are assignees on the issues *PROJ-1* or *PROJ-2*. *  `is reporter of (PROJ-1, PROJ-2)` Returns users that are reporters on the issues *PROJ-1* or *PROJ-2*. *  `is watcher of (PROJ-1, PROJ-2)` Returns users that are watchers on the issues *PROJ-1* or *PROJ-2*. *  `is voter of (PROJ-1, PROJ-2)` Returns users that are voters on the issues *PROJ-1* or *PROJ-2*. *  `is commenter of (PROJ-1, PROJ-2)` Returns users that have posted a comment on the issues *PROJ-1* or *PROJ-2*. *  `is transitioner of (PROJ-1, PROJ-2)` Returns users that have performed a transition on issues *PROJ-1* or *PROJ-2*. *  `[propertyKey].entity.property.path is &quot;property value&quot;` Returns users with the entity property value.The list of issues can be extended as needed, as in *(PROJ-1, PROJ-2, ... PROJ-n)*. Statements can be combined using the `AND` and `OR` operators to form more complex queries. For example:`is assignee of PROJ AND [propertyKey].entity.property.path is &quot;property value&quot;`
        /// </summary>
        /// <returns>A <see cref="PageBeanUserKey"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ErrorCollection">When receiving a 400 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 401 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 403 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 408 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanUserKey?> GetAsync(Action<RequestConfiguration<KeyRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PageBeanUserKey> GetAsync(Action<RequestConfiguration<KeyRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"401", ErrorCollection.CreateFromDiscriminatorValue},
                {"403", ErrorCollection.CreateFromDiscriminatorValue},
                {"408", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PageBeanUserKey>(requestInfo, PageBeanUserKey.CreateFromDiscriminatorValue, errorMapping,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Finds users with a structured query and returns a [paginated](#pagination) list of user keys.This operation takes the users in the range defined by `startAt` and `maxResults`, up to the thousandth user, and then returns only the users from that range that match the structured query. This means the operation usually returns fewer users than specified in `maxResults`. To get all the users who match the structured query, use [Get all users](#api-rest-api-3-users-search-get) and filter the records in your code.**[Permissions](#permissions) required:** *Browse users and groups* [global permission](https://confluence.atlassian.com/x/x4dKLg).The query statements are: *  `is assignee of PROJ` Returns the users that are assignees of at least one issue in project *PROJ*. *  `is assignee of (PROJ-1, PROJ-2)` Returns users that are assignees on the issues *PROJ-1* or *PROJ-2*. *  `is reporter of (PROJ-1, PROJ-2)` Returns users that are reporters on the issues *PROJ-1* or *PROJ-2*. *  `is watcher of (PROJ-1, PROJ-2)` Returns users that are watchers on the issues *PROJ-1* or *PROJ-2*. *  `is voter of (PROJ-1, PROJ-2)` Returns users that are voters on the issues *PROJ-1* or *PROJ-2*. *  `is commenter of (PROJ-1, PROJ-2)` Returns users that have posted a comment on the issues *PROJ-1* or *PROJ-2*. *  `is transitioner of (PROJ-1, PROJ-2)` Returns users that have performed a transition on issues *PROJ-1* or *PROJ-2*. *  `[propertyKey].entity.property.path is &quot;property value&quot;` Returns users with the entity property value.The list of issues can be extended as needed, as in *(PROJ-1, PROJ-2, ... PROJ-n)*. Statements can be combined using the `AND` and `OR` operators to form more complex queries. For example:`is assignee of PROJ AND [propertyKey].entity.property.path is &quot;property value&quot;`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KeyRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<KeyRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KeyRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KeyRequestBuilder WithUrl(string rawUrl)
        {
            return new KeyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Finds users with a structured query and returns a [paginated](#pagination) list of user keys.This operation takes the users in the range defined by `startAt` and `maxResults`, up to the thousandth user, and then returns only the users from that range that match the structured query. This means the operation usually returns fewer users than specified in `maxResults`. To get all the users who match the structured query, use [Get all users](#api-rest-api-3-users-search-get) and filter the records in your code.**[Permissions](#permissions) required:** *Browse users and groups* [global permission](https://confluence.atlassian.com/x/x4dKLg).The query statements are: *  `is assignee of PROJ` Returns the users that are assignees of at least one issue in project *PROJ*. *  `is assignee of (PROJ-1, PROJ-2)` Returns users that are assignees on the issues *PROJ-1* or *PROJ-2*. *  `is reporter of (PROJ-1, PROJ-2)` Returns users that are reporters on the issues *PROJ-1* or *PROJ-2*. *  `is watcher of (PROJ-1, PROJ-2)` Returns users that are watchers on the issues *PROJ-1* or *PROJ-2*. *  `is voter of (PROJ-1, PROJ-2)` Returns users that are voters on the issues *PROJ-1* or *PROJ-2*. *  `is commenter of (PROJ-1, PROJ-2)` Returns users that have posted a comment on the issues *PROJ-1* or *PROJ-2*. *  `is transitioner of (PROJ-1, PROJ-2)` Returns users that have performed a transition on issues *PROJ-1* or *PROJ-2*. *  `[propertyKey].entity.property.path is &quot;property value&quot;` Returns users with the entity property value.The list of issues can be extended as needed, as in *(PROJ-1, PROJ-2, ... PROJ-n)*. Statements can be combined using the `AND` and `OR` operators to form more complex queries. For example:`is assignee of PROJ AND [propertyKey].entity.property.path is &quot;property value&quot;`
        /// </summary>
        public class KeyRequestBuilderGetQueryParameters 
        {
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResult")]
            public int? MaxResult { get; set; }
            /// <summary>The search query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("query")]
            public string? Query { get; set; }
#nullable restore
#else
            [QueryParameter("query")]
            public string Query { get; set; }
#endif
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public long? StartAt { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class KeyRequestBuilderGetRequestConfiguration : RequestConfiguration<KeyRequestBuilderGetQueryParameters> 
        {
        }
    }
}
