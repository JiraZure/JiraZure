// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// A page of CreateMetaIssueType with Field.
    /// </summary>
    public class PageOfCreateMetaIssueTypeWithField : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The collection of FieldCreateMetaBeans.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FieldCreateMetadata>? Fields { get; private set; }
#nullable restore
#else
        public List<FieldCreateMetadata> Fields { get; private set; }
#endif
        /// <summary>The maximum number of items to return per page.</summary>
        public int? MaxResults { get; private set; }
        /// <summary>The results property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FieldCreateMetadata>? Results { get; set; }
#nullable restore
#else
        public List<FieldCreateMetadata> Results { get; set; }
#endif
        /// <summary>The index of the first item returned.</summary>
        public long? StartAt { get; private set; }
        /// <summary>The total number of items in all pages.</summary>
        public long? Total { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="PageOfCreateMetaIssueTypeWithField"/> and sets the default values.
        /// </summary>
        public PageOfCreateMetaIssueTypeWithField()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PageOfCreateMetaIssueTypeWithField"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PageOfCreateMetaIssueTypeWithField CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PageOfCreateMetaIssueTypeWithField();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"fields", n => { Fields = n.GetCollectionOfObjectValues<FieldCreateMetadata>(FieldCreateMetadata.CreateFromDiscriminatorValue)?.ToList(); } },
                {"maxResults", n => { MaxResults = n.GetIntValue(); } },
                {"results", n => { Results = n.GetCollectionOfObjectValues<FieldCreateMetadata>(FieldCreateMetadata.CreateFromDiscriminatorValue)?.ToList(); } },
                {"startAt", n => { StartAt = n.GetLongValue(); } },
                {"total", n => { Total = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<FieldCreateMetadata>("results", Results);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
