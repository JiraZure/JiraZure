// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details of the workflow and its transition rules.
    /// </summary>
    public class WorkflowRulesSearch : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Use expand to include additional information in the response. This parameter accepts `transition` which, for each rule, returns information about the transition the rule is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Expand { get; set; }
#nullable restore
#else
        public string Expand { get; set; }
#endif
        /// <summary>The list of workflow rule IDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? RuleIds { get; set; }
#nullable restore
#else
        public List<Guid?> RuleIds { get; set; }
#endif
        /// <summary>The workflow ID.</summary>
        public Guid? WorkflowEntityId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WorkflowRulesSearch"/> and sets the default values.
        /// </summary>
        public WorkflowRulesSearch()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WorkflowRulesSearch"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowRulesSearch CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowRulesSearch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"expand", n => { Expand = n.GetStringValue(); } },
                {"ruleIds", n => { RuleIds = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"workflowEntityId", n => { WorkflowEntityId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("expand", Expand);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("ruleIds", RuleIds);
            writer.WriteGuidValue("workflowEntityId", WorkflowEntityId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
