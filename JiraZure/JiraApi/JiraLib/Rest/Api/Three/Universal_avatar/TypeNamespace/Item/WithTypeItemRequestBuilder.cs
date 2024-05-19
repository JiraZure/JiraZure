// <auto-generated/>
using JiraLib.Rest.Api.Three.Universal_avatar.TypeNamespace.Item.Owner;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace JiraLib.Rest.Api.Three.Universal_avatar.TypeNamespace.Item {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\universal_avatar\type\{type}
    /// </summary>
    public class WithTypeItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The owner property</summary>
        public OwnerRequestBuilder Owner
        {
            get => new OwnerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTypeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/universal_avatar/type/{type}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithTypeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTypeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/universal_avatar/type/{type}", rawUrl)
        {
        }
    }
}
