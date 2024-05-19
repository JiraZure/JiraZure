// <auto-generated/>
using JiraLib.Models;
using JiraLib.Rest.Api.Three.Notificationscheme.Item;
using JiraLib.Rest.Api.Three.Notificationscheme.Project;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Notificationscheme {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\notificationscheme
    /// </summary>
    public class NotificationschemeRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The project property</summary>
        public ProjectRequestBuilder Project
        {
            get => new ProjectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the JiraLib.rest.api.Three.notificationscheme.item collection</summary>
        /// <param name="position">The ID of the notification scheme. Use [Get notification schemes paginated](#api-rest-api-3-notificationscheme-get) to get a list of notification scheme IDs.</param>
        /// <returns>A <see cref="ItemRequestBuilder"/></returns>
        public ItemRequestBuilder this[long position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("%2Did", position);
                return new ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the JiraLib.rest.api.Three.notificationscheme.item collection</summary>
        /// <param name="position">The ID of the notification scheme. Use [Get notification schemes paginated](#api-rest-api-3-notificationscheme-get) to get a list of notification scheme IDs.</param>
        /// <returns>A <see cref="ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("%2Did", position);
                return new ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="NotificationschemeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NotificationschemeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/notificationscheme{?expand*,id*,maxResults*,onlyDefault*,projectId*,startAt*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="NotificationschemeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NotificationschemeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/notificationscheme{?expand*,id*,maxResults*,onlyDefault*,projectId*,startAt*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of [notification schemes](https://confluence.atlassian.com/x/8YdKLg) ordered by the display name.*Note that you should allow for events without recipients to appear in responses.***[Permissions](#permissions) required:** Permission to access Jira, however, the user must have permission to administer at least one project associated with a notification scheme for it to be returned.
        /// </summary>
        /// <returns>A <see cref="PageBeanNotificationScheme"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanNotificationScheme?> GetAsync(Action<RequestConfiguration<NotificationschemeRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<PageBeanNotificationScheme> GetAsync(Action<RequestConfiguration<NotificationschemeRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<PageBeanNotificationScheme>(requestInfo, PageBeanNotificationScheme.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a notification scheme with notifications. You can create up to 1000 notifications per request.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="NotificationSchemeId"/></returns>
        /// <param name="body">Details of an notification scheme.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ErrorCollection">When receiving a 400 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 401 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 403 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<NotificationSchemeId?> PostAsync(CreateNotificationSchemeDetails body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<NotificationSchemeId> PostAsync(CreateNotificationSchemeDetails body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"401", ErrorCollection.CreateFromDiscriminatorValue},
                {"403", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<NotificationSchemeId>(requestInfo, NotificationSchemeId.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of [notification schemes](https://confluence.atlassian.com/x/8YdKLg) ordered by the display name.*Note that you should allow for events without recipients to appear in responses.***[Permissions](#permissions) required:** Permission to access Jira, however, the user must have permission to administer at least one project associated with a notification scheme for it to be returned.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<NotificationschemeRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<NotificationschemeRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a notification scheme with notifications. You can create up to 1000 notifications per request.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Details of an notification scheme.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CreateNotificationSchemeDetails body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CreateNotificationSchemeDetails body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="NotificationschemeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public NotificationschemeRequestBuilder WithUrl(string rawUrl)
        {
            return new NotificationschemeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of [notification schemes](https://confluence.atlassian.com/x/8YdKLg) ordered by the display name.*Note that you should allow for events without recipients to appear in responses.***[Permissions](#permissions) required:** Permission to access Jira, however, the user must have permission to administer at least one project associated with a notification scheme for it to be returned.
        /// </summary>
        public class NotificationschemeRequestBuilderGetQueryParameters 
        {
            /// <summary>Use [expand](#expansion) to include additional information in the response. This parameter accepts a comma-separated list. Expand options include: *  `all` Returns all expandable information *  `field` Returns information about any custom fields assigned to receive an event *  `group` Returns information about any groups assigned to receive an event *  `notificationSchemeEvents` Returns a list of event associations. This list is returned for all expandable information *  `projectRole` Returns information about any project roles assigned to receive an event *  `user` Returns information about any users assigned to receive an event</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>The list of notification schemes IDs to be filtered by</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("id")]
            public string[]? Id { get; set; }
#nullable restore
#else
            [QueryParameter("id")]
            public string[] Id { get; set; }
#endif
            /// <summary>The maximum number of items to return per page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("maxResults")]
            public string? MaxResults { get; set; }
#nullable restore
#else
            [QueryParameter("maxResults")]
            public string MaxResults { get; set; }
#endif
            /// <summary>When set to true, returns only the default notification scheme. If you provide project IDs not associated with the default, returns an empty page. The default value is false.</summary>
            [QueryParameter("onlyDefault")]
            public bool? OnlyDefault { get; set; }
            /// <summary>The list of projects IDs to be filtered by</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("projectId")]
            public string[]? ProjectId { get; set; }
#nullable restore
#else
            [QueryParameter("projectId")]
            public string[] ProjectId { get; set; }
#endif
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("startAt")]
            public string? StartAt { get; set; }
#nullable restore
#else
            [QueryParameter("startAt")]
            public string StartAt { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class NotificationschemeRequestBuilderGetRequestConfiguration : RequestConfiguration<NotificationschemeRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class NotificationschemeRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
