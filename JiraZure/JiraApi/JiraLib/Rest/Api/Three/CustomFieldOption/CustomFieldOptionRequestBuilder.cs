// <auto-generated/>
using JiraLib.Rest.Api.Three.CustomFieldOption.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace JiraLib.Rest.Api.Three.CustomFieldOption {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\customFieldOption
    /// </summary>
    public class CustomFieldOptionRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the JiraLib.rest.api.Three.customFieldOption.item collection</summary>
        /// <param name="position">The ID of the custom field option.</param>
        /// <returns>A <see cref="CustomFieldOptionItemRequestBuilder"/></returns>
        public CustomFieldOptionItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new CustomFieldOptionItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="CustomFieldOptionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomFieldOptionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/customFieldOption", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="CustomFieldOptionRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomFieldOptionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/customFieldOption", rawUrl)
        {
        }
    }
}
