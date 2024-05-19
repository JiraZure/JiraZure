// <auto-generated/>
using JiraLib.Rest.AtlassianConnect.One.Migration.Workflow.Rule;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace JiraLib.Rest.AtlassianConnect.One.Migration.Workflow {
    /// <summary>
    /// Builds and executes requests for operations under \rest\atlassian-connect\1\migration\workflow
    /// </summary>
    public class WorkflowRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The rule property</summary>
        public RuleRequestBuilder Rule
        {
            get => new RuleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WorkflowRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/atlassian-connect/1/migration/workflow", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WorkflowRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/atlassian-connect/1/migration/workflow", rawUrl)
        {
        }
    }
}
