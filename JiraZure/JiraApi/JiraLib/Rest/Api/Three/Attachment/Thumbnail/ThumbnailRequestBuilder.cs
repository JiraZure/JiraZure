// <auto-generated/>
using JiraLib.Rest.Api.Three.Attachment.Thumbnail.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace JiraLib.Rest.Api.Three.Attachment.Thumbnail {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\attachment\thumbnail
    /// </summary>
    public class ThumbnailRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the JiraLib.rest.api.Three.attachment.thumbnail.item collection</summary>
        /// <param name="position">The ID of the attachment.</param>
        /// <returns>A <see cref="ThumbnailItemRequestBuilder"/></returns>
        public ThumbnailItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new ThumbnailItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="ThumbnailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThumbnailRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/attachment/thumbnail", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="ThumbnailRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThumbnailRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/attachment/thumbnail", rawUrl)
        {
        }
    }
}
