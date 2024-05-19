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
namespace JiraLib.Rest.Api.Three.Universal_avatar.View.TypeNamespace.Item.Avatar.Item {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\universal_avatar\view\type\{type}\avatar\{id}
    /// </summary>
    public class AvatarItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="AvatarItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AvatarItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/universal_avatar/view/type/{type}/avatar/{id}{?format*,size*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AvatarItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AvatarItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/universal_avatar/view/type/{type}/avatar/{id}{?format*,size*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a project or issue type avatar image by ID.This operation can be accessed anonymously.**[Permissions](#permissions) required:** *  For system avatars, none. *  For custom project avatars, *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project the avatar belongs to. *  For custom issue type avatars, *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for at least one project the issue type is used in.
        /// </summary>
        /// <returns>A <see cref="StreamingResponseBody"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ErrorCollection">When receiving a 400 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 401 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 403 status code</exception>
        /// <exception cref="ErrorCollection">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<StreamingResponseBody?> GetAsync(Action<RequestConfiguration<AvatarItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<StreamingResponseBody> GetAsync(Action<RequestConfiguration<AvatarItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"401", ErrorCollection.CreateFromDiscriminatorValue},
                {"403", ErrorCollection.CreateFromDiscriminatorValue},
                {"404", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<StreamingResponseBody>(requestInfo, StreamingResponseBody.CreateFromDiscriminatorValue, errorMapping,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a project or issue type avatar image by ID.This operation can be accessed anonymously.**[Permissions](#permissions) required:** *  For system avatars, none. *  For custom project avatars, *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project the avatar belongs to. *  For custom issue type avatars, *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for at least one project the issue type is used in.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AvatarItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AvatarItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="AvatarItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AvatarItemRequestBuilder WithUrl(string rawUrl)
        {
            return new AvatarItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a project or issue type avatar image by ID.This operation can be accessed anonymously.**[Permissions](#permissions) required:** *  For system avatars, none. *  For custom project avatars, *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project the avatar belongs to. *  For custom issue type avatars, *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for at least one project the issue type is used in.
        /// </summary>
        public class AvatarItemRequestBuilderGetQueryParameters 
        {
            /// <summary>The format to return the avatar image in. If not provided the original content format is returned.</summary>
            [Obsolete("This property is deprecated, use FormatAsGetFormatQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("format")]
            public string? Format { get; set; }
#nullable restore
#else
            [QueryParameter("format")]
            public string Format { get; set; }
#endif
            /// <summary>The format to return the avatar image in. If not provided the original content format is returned.</summary>
            [QueryParameter("format")]
            public GetFormatQueryParameterType? FormatAsGetFormatQueryParameterType { get; set; }
            /// <summary>The size of the avatar image. If not provided the default size is returned.</summary>
            [Obsolete("This property is deprecated, use SizeAsGetSizeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("size")]
            public string? Size { get; set; }
#nullable restore
#else
            [QueryParameter("size")]
            public string Size { get; set; }
#endif
            /// <summary>The size of the avatar image. If not provided the default size is returned.</summary>
            [QueryParameter("size")]
            public GetSizeQueryParameterType? SizeAsGetSizeQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AvatarItemRequestBuilderGetRequestConfiguration : RequestConfiguration<AvatarItemRequestBuilderGetQueryParameters> 
        {
        }
    }
}
