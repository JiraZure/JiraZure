// <auto-generated/>
using JiraLib.Models;
using JiraLib.Rest.Api.Three.Dashboard.Item.Gadget.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace JiraLib.Rest.Api.Three.Dashboard.Item.Gadget {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\dashboard\{dashboard-id}\gadget
    /// </summary>
    public class GadgetRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the JiraLib.rest.api.Three.dashboard.item.gadget.item collection</summary>
        /// <param name="position">The ID of the gadget.</param>
        /// <returns>A <see cref="WithGadgetItemRequestBuilder"/></returns>
        public WithGadgetItemRequestBuilder this[long position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("gadgetId", position);
                return new WithGadgetItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the JiraLib.rest.api.Three.dashboard.item.gadget.item collection</summary>
        /// <param name="position">The ID of the gadget.</param>
        /// <returns>A <see cref="WithGadgetItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithGadgetItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("gadgetId", position);
                return new WithGadgetItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="GadgetRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GadgetRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/{dashboard%2Did}/gadget{?gadgetId*,moduleKey*,uri*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="GadgetRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GadgetRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/{dashboard%2Did}/gadget{?gadgetId*,moduleKey*,uri*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of dashboard gadgets on a dashboard.This operation returns: *  Gadgets from a list of IDs, when `id` is set. *  Gadgets with a module key, when `moduleKey` is set. *  Gadgets from a list of URIs, when `uri` is set. *  All gadgets, when no other parameters are set.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <returns>A <see cref="DashboardGadgetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ErrorCollection">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DashboardGadgetResponse?> GetAsync(Action<RequestConfiguration<GadgetRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<DashboardGadgetResponse> GetAsync(Action<RequestConfiguration<GadgetRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"404", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DashboardGadgetResponse>(requestInfo, DashboardGadgetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Adds a gadget to a dashboard.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <returns>A <see cref="DashboardGadget"/></returns>
        /// <param name="body">Details of the settings for a dashboard gadget.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ErrorCollection">When receiving a 400 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DashboardGadget?> PostAsync(DashboardGadgetSettings body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<DashboardGadget> PostAsync(DashboardGadgetSettings body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"404", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DashboardGadget>(requestInfo, DashboardGadget.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of dashboard gadgets on a dashboard.This operation returns: *  Gadgets from a list of IDs, when `id` is set. *  Gadgets with a module key, when `moduleKey` is set. *  Gadgets from a list of URIs, when `uri` is set. *  All gadgets, when no other parameters are set.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GadgetRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<GadgetRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Adds a gadget to a dashboard.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Details of the settings for a dashboard gadget.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(DashboardGadgetSettings body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(DashboardGadgetSettings body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="GadgetRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public GadgetRequestBuilder WithUrl(string rawUrl)
        {
            return new GadgetRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of dashboard gadgets on a dashboard.This operation returns: *  Gadgets from a list of IDs, when `id` is set. *  Gadgets with a module key, when `moduleKey` is set. *  Gadgets from a list of URIs, when `uri` is set. *  All gadgets, when no other parameters are set.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        public class GadgetRequestBuilderGetQueryParameters 
        {
            /// <summary>The list of gadgets IDs. To include multiple IDs, separate IDs with ampersand: `gadgetId=10000&amp;gadgetId=10001`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("gadgetId")]
            public long?[]? GadgetId { get; set; }
#nullable restore
#else
            [QueryParameter("gadgetId")]
            public long?[] GadgetId { get; set; }
#endif
            /// <summary>The list of gadgets module keys. To include multiple module keys, separate module keys with ampersand: `moduleKey=key:one&amp;moduleKey=key:two`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("moduleKey")]
            public string[]? ModuleKey { get; set; }
#nullable restore
#else
            [QueryParameter("moduleKey")]
            public string[] ModuleKey { get; set; }
#endif
            /// <summary>The list of gadgets URIs. To include multiple URIs, separate URIs with ampersand: `uri=/rest/example/uri/1&amp;uri=/rest/example/uri/2`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("uri")]
            public string[]? Uri { get; set; }
#nullable restore
#else
            [QueryParameter("uri")]
            public string[] Uri { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GadgetRequestBuilderGetRequestConfiguration : RequestConfiguration<GadgetRequestBuilderGetQueryParameters> 
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class GadgetRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters> 
        {
        }
    }
}
