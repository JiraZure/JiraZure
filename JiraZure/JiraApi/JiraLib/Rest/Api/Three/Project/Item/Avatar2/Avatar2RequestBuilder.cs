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
namespace JiraLib.Rest.Api.Three.Project.Item.Avatar2 {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\project\{projectIdOrKey-id}\avatar2
    /// </summary>
    public class Avatar2RequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="Avatar2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Avatar2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/project/{projectIdOrKey%2Did}/avatar2{?size*,x*,y*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Avatar2RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Avatar2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/project/{projectIdOrKey%2Did}/avatar2{?size*,x*,y*}", rawUrl)
        {
        }
        /// <summary>
        /// Loads an avatar for a project.Specify the avatar&apos;s local file location in the body of the request. Also, include the following headers: *  `X-Atlassian-Token: no-check` To prevent XSRF protection blocking the request, for more information see [Special Headers](#special-request-headers). *  `Content-Type: image/image type` Valid image types are JPEG, GIF, or PNG.For example:  `curl --request POST ``--user email@example.com:&lt;api_token&gt; ``--header &apos;X-Atlassian-Token: no-check&apos; ``--header &apos;Content-Type: image/&lt; image_type&gt;&apos; ``--data-binary &quot;&lt;@/path/to/file/with/your/avatar&gt;&quot; ``--url &apos;https://your-domain.atlassian.net/rest/api/3/project/{projectIdOrKey}/avatar2&apos;`The avatar is cropped to a square. If no crop parameters are specified, the square originates at the top left of the image. The length of the square&apos;s sides is set to the smaller of the height or width of the image.The cropped image is then used to create avatars of 16x16, 24x24, 32x32, and 48x48 in size.After creating the avatar use [Set project avatar](#api-rest-api-3-project-projectIdOrKey-avatar-put) to set it as the project&apos;s displayed avatar.**[Permissions](#permissions) required:** *Administer projects* [project permission](https://confluence.atlassian.com/x/yodKLg).
        /// </summary>
        /// <returns>A <see cref="JiraLib.Models.Avatar"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="contentType">The request body content type.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraLib.Models.Avatar?> PostAsync(Stream body, string contentType, Action<RequestConfiguration<Avatar2RequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<JiraLib.Models.Avatar> PostAsync(Stream body, string contentType, Action<RequestConfiguration<Avatar2RequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            if(string.IsNullOrEmpty(contentType)) throw new ArgumentNullException(nameof(contentType));
            var requestInfo = ToPostRequestInformation(body, contentType, requestConfiguration);
            return await RequestAdapter.SendAsync<JiraLib.Models.Avatar>(requestInfo, JiraLib.Models.Avatar.CreateFromDiscriminatorValue, default,cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Loads an avatar for a project.Specify the avatar&apos;s local file location in the body of the request. Also, include the following headers: *  `X-Atlassian-Token: no-check` To prevent XSRF protection blocking the request, for more information see [Special Headers](#special-request-headers). *  `Content-Type: image/image type` Valid image types are JPEG, GIF, or PNG.For example:  `curl --request POST ``--user email@example.com:&lt;api_token&gt; ``--header &apos;X-Atlassian-Token: no-check&apos; ``--header &apos;Content-Type: image/&lt; image_type&gt;&apos; ``--data-binary &quot;&lt;@/path/to/file/with/your/avatar&gt;&quot; ``--url &apos;https://your-domain.atlassian.net/rest/api/3/project/{projectIdOrKey}/avatar2&apos;`The avatar is cropped to a square. If no crop parameters are specified, the square originates at the top left of the image. The length of the square&apos;s sides is set to the smaller of the height or width of the image.The cropped image is then used to create avatars of 16x16, 24x24, 32x32, and 48x48 in size.After creating the avatar use [Set project avatar](#api-rest-api-3-project-projectIdOrKey-avatar-put) to set it as the project&apos;s displayed avatar.**[Permissions](#permissions) required:** *Administer projects* [project permission](https://confluence.atlassian.com/x/yodKLg).
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Binary request body</param>
        /// <param name="contentType">The request body content type.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Stream body, string contentType, Action<RequestConfiguration<Avatar2RequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Stream body, string contentType, Action<RequestConfiguration<Avatar2RequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            if(string.IsNullOrEmpty(contentType)) throw new ArgumentNullException(nameof(contentType));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetStreamContent(body, contentType);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Avatar2RequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Avatar2RequestBuilder WithUrl(string rawUrl)
        {
            return new Avatar2RequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Loads an avatar for a project.Specify the avatar&apos;s local file location in the body of the request. Also, include the following headers: *  `X-Atlassian-Token: no-check` To prevent XSRF protection blocking the request, for more information see [Special Headers](#special-request-headers). *  `Content-Type: image/image type` Valid image types are JPEG, GIF, or PNG.For example:  `curl --request POST ``--user email@example.com:&lt;api_token&gt; ``--header &apos;X-Atlassian-Token: no-check&apos; ``--header &apos;Content-Type: image/&lt; image_type&gt;&apos; ``--data-binary &quot;&lt;@/path/to/file/with/your/avatar&gt;&quot; ``--url &apos;https://your-domain.atlassian.net/rest/api/3/project/{projectIdOrKey}/avatar2&apos;`The avatar is cropped to a square. If no crop parameters are specified, the square originates at the top left of the image. The length of the square&apos;s sides is set to the smaller of the height or width of the image.The cropped image is then used to create avatars of 16x16, 24x24, 32x32, and 48x48 in size.After creating the avatar use [Set project avatar](#api-rest-api-3-project-projectIdOrKey-avatar-put) to set it as the project&apos;s displayed avatar.**[Permissions](#permissions) required:** *Administer projects* [project permission](https://confluence.atlassian.com/x/yodKLg).
        /// </summary>
        public class Avatar2RequestBuilderPostQueryParameters 
        {
            /// <summary>The length of each side of the crop region.</summary>
            [QueryParameter("size")]
            public int? Size { get; set; }
            /// <summary>The X coordinate of the top-left corner of the crop region.</summary>
            [QueryParameter("x")]
            public int? X { get; set; }
            /// <summary>The Y coordinate of the top-left corner of the crop region.</summary>
            [QueryParameter("y")]
            public int? Y { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class Avatar2RequestBuilderPostRequestConfiguration : RequestConfiguration<Avatar2RequestBuilderPostQueryParameters> 
        {
        }
    }
}
