// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details of an issue update request.
    /// </summary>
    public class IssueUpdateDetails : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of issue screen fields to update, specifying the sub-field to update and its value for each field. This field provides a straightforward option when setting a sub-field. When multiple sub-fields or other operations are required, use `update`. Fields included in here cannot be included in `update`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueUpdateDetails_fields? Fields { get; set; }
#nullable restore
#else
        public IssueUpdateDetails_fields Fields { get; set; }
#endif
        /// <summary>Additional issue history details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JiraLib.Models.HistoryMetadata? HistoryMetadata { get; set; }
#nullable restore
#else
        public JiraLib.Models.HistoryMetadata HistoryMetadata { get; set; }
#endif
        /// <summary>Details of issue properties to be add or update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EntityProperty>? Properties { get; set; }
#nullable restore
#else
        public List<EntityProperty> Properties { get; set; }
#endif
        /// <summary>Details of a transition. Required when performing a transition, optional when creating or editing an issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueTransition? Transition { get; set; }
#nullable restore
#else
        public IssueTransition Transition { get; set; }
#endif
        /// <summary>A Map containing the field field name and a list of operations to perform on the issue screen field. Note that fields included in here cannot be included in `fields`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueUpdateDetails_update? Update { get; set; }
#nullable restore
#else
        public IssueUpdateDetails_update Update { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="IssueUpdateDetails"/> and sets the default values.
        /// </summary>
        public IssueUpdateDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IssueUpdateDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IssueUpdateDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IssueUpdateDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"fields", n => { Fields = n.GetObjectValue<IssueUpdateDetails_fields>(IssueUpdateDetails_fields.CreateFromDiscriminatorValue); } },
                {"historyMetadata", n => { HistoryMetadata = n.GetObjectValue<JiraLib.Models.HistoryMetadata>(JiraLib.Models.HistoryMetadata.CreateFromDiscriminatorValue); } },
                {"properties", n => { Properties = n.GetCollectionOfObjectValues<EntityProperty>(EntityProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"transition", n => { Transition = n.GetObjectValue<IssueTransition>(IssueTransition.CreateFromDiscriminatorValue); } },
                {"update", n => { Update = n.GetObjectValue<IssueUpdateDetails_update>(IssueUpdateDetails_update.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IssueUpdateDetails_fields>("fields", Fields);
            writer.WriteObjectValue<JiraLib.Models.HistoryMetadata>("historyMetadata", HistoryMetadata);
            writer.WriteCollectionOfObjectValues<EntityProperty>("properties", Properties);
            writer.WriteObjectValue<IssueTransition>("transition", Transition);
            writer.WriteObjectValue<IssueUpdateDetails_update>("update", Update);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
