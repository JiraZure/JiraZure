// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    #pragma warning disable CS1591
    public class PrioritySchemeChangesWithMappings : IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Affected entity ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<long?>? Ids { get; set; }
#nullable restore
#else
        public List<long?> Ids { get; set; }
#endif
        /// <summary>Instructions to migrate issues.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PriorityMapping>? Mappings { get; set; }
#nullable restore
#else
        public List<PriorityMapping> Mappings { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrioritySchemeChangesWithMappings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrioritySchemeChangesWithMappings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrioritySchemeChangesWithMappings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"ids", n => { Ids = n.GetCollectionOfPrimitiveValues<long?>()?.ToList(); } },
                {"mappings", n => { Mappings = n.GetCollectionOfObjectValues<PriorityMapping>(PriorityMapping.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<long?>("ids", Ids);
            writer.WriteCollectionOfObjectValues<PriorityMapping>("mappings", Mappings);
        }
    }
}
