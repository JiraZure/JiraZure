// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details about a workflow configuration update request.
    /// </summary>
    public class WorkflowTransitionRulesDetails : IParsable 
    {
        /// <summary>Properties that identify a workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JiraLib.Models.WorkflowId? WorkflowId { get; set; }
#nullable restore
#else
        public JiraLib.Models.WorkflowId WorkflowId { get; set; }
#endif
        /// <summary>The list of connect workflow rule IDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WorkflowRuleIds { get; set; }
#nullable restore
#else
        public List<string> WorkflowRuleIds { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WorkflowTransitionRulesDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowTransitionRulesDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowTransitionRulesDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"workflowId", n => { WorkflowId = n.GetObjectValue<JiraLib.Models.WorkflowId>(JiraLib.Models.WorkflowId.CreateFromDiscriminatorValue); } },
                {"workflowRuleIds", n => { WorkflowRuleIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<JiraLib.Models.WorkflowId>("workflowId", WorkflowId);
            writer.WriteCollectionOfPrimitiveValues<string>("workflowRuleIds", WorkflowRuleIds);
        }
    }
}
