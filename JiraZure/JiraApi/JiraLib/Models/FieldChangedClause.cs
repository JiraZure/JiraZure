// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// A clause that asserts whether a field was changed. For example, `status CHANGED AFTER startOfMonth(-1M)`.See [CHANGED](https://confluence.atlassian.com/x/dgiiLQ#Advancedsearching-operatorsreference-CHANGEDCHANGED) for more information about the CHANGED operator.
    /// </summary>
    public class FieldChangedClause : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A field used in a JQL query. See [Advanced searching - fields reference](https://confluence.atlassian.com/x/dAiiLQ) for more information about fields in JQL queries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JqlQueryField? Field { get; set; }
#nullable restore
#else
        public JqlQueryField Field { get; set; }
#endif
        /// <summary>The operator applied to the field.</summary>
        public FieldChangedClause_operator? Operator { get; set; }
        /// <summary>The list of time predicates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JqlQueryClauseTimePredicate>? Predicates { get; set; }
#nullable restore
#else
        public List<JqlQueryClauseTimePredicate> Predicates { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="FieldChangedClause"/> and sets the default values.
        /// </summary>
        public FieldChangedClause()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="FieldChangedClause"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FieldChangedClause CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FieldChangedClause();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"field", n => { Field = n.GetObjectValue<JqlQueryField>(JqlQueryField.CreateFromDiscriminatorValue); } },
                {"operator", n => { Operator = n.GetEnumValue<FieldChangedClause_operator>(); } },
                {"predicates", n => { Predicates = n.GetCollectionOfObjectValues<JqlQueryClauseTimePredicate>(JqlQueryClauseTimePredicate.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<JqlQueryField>("field", Field);
            writer.WriteEnumValue<FieldChangedClause_operator>("operator", Operator);
            writer.WriteCollectionOfObjectValues<JqlQueryClauseTimePredicate>("predicates", Predicates);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
