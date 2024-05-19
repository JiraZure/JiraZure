// <auto-generated/>
using JiraLib.Rest.AtlassianConnect.One.Migration.Properties.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace JiraLib.Rest.AtlassianConnect.One.Migration.Properties {
    /// <summary>
    /// Builds and executes requests for operations under \rest\atlassian-connect\1\migration\properties
    /// </summary>
    public class PropertiesRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the JiraLib.rest.atlassianConnect.One.migration.properties.item collection</summary>
        /// <param name="position">The type indicating the object that contains the entity properties.</param>
        /// <returns>A <see cref="WithEntityTypeItemRequestBuilder"/></returns>
        public WithEntityTypeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("entityType", position);
                return new WithEntityTypeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="PropertiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PropertiesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/atlassian-connect/1/migration/properties", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="PropertiesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PropertiesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/atlassian-connect/1/migration/properties", rawUrl)
        {
        }
    }
}
