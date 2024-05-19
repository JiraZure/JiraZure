// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// The conditions group associated with the transition.
    /// </summary>
    public class ConditionGroupUpdate : IParsable 
    {
        /// <summary>The nested conditions of the condition group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionGroupUpdate>? ConditionGroups { get; set; }
#nullable restore
#else
        public List<ConditionGroupUpdate> ConditionGroups { get; set; }
#endif
        /// <summary>The rules for this condition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowRuleConfiguration>? Conditions { get; set; }
#nullable restore
#else
        public List<WorkflowRuleConfiguration> Conditions { get; set; }
#endif
        /// <summary>Determines how the conditions in the group are evaluated. Accepts either `ANY` or `ALL`. If `ANY` is used, at least one condition in the group must be true for the group to evaluate to true. If `ALL` is used, all conditions in the group must be true for the group to evaluate to true.</summary>
        public ConditionGroupUpdate_operation? Operation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ConditionGroupUpdate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionGroupUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionGroupUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"conditionGroups", n => { ConditionGroups = n.GetCollectionOfObjectValues<ConditionGroupUpdate>(ConditionGroupUpdate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditions", n => { Conditions = n.GetCollectionOfObjectValues<WorkflowRuleConfiguration>(WorkflowRuleConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operation", n => { Operation = n.GetEnumValue<ConditionGroupUpdate_operation>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ConditionGroupUpdate>("conditionGroups", ConditionGroups);
            writer.WriteCollectionOfObjectValues<WorkflowRuleConfiguration>("conditions", Conditions);
            writer.WriteEnumValue<ConditionGroupUpdate_operation>("operation", Operation);
        }
    }
}
