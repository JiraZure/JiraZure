// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    #pragma warning disable CS1591
    public class ProjectScopeBean : IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Defines the behavior of the option in the project.If notSelectable is set, the option cannot be set as the field&apos;s value. This is useful for archiving an option that has previously been selected but shouldn&apos;t be used anymore.If defaultValue is set, the option is selected by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProjectScopeBean_attributes?>? Attributes { get; set; }
#nullable restore
#else
        public List<ProjectScopeBean_attributes?> Attributes { get; set; }
#endif
        /// <summary>The ID of the project that the option&apos;s behavior applies to.</summary>
        public long? Id { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ProjectScopeBean"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProjectScopeBean CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProjectScopeBean();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"attributes", n => { Attributes = n.GetCollectionOfEnumValues<ProjectScopeBean_attributes>()?.ToList(); } },
                {"id", n => { Id = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<ProjectScopeBean_attributes>("attributes", Attributes);
            writer.WriteLongValue("id", Id);
        }
    }
}
