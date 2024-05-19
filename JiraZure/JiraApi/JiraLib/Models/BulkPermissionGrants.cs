// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details of global and project permissions granted to the user.
    /// </summary>
    public class BulkPermissionGrants : IParsable 
    {
        /// <summary>List of permissions granted to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GlobalPermissions { get; set; }
#nullable restore
#else
        public List<string> GlobalPermissions { get; set; }
#endif
        /// <summary>List of project permissions and the projects and issues those permissions provide access to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BulkProjectPermissionGrants>? ProjectPermissions { get; set; }
#nullable restore
#else
        public List<BulkProjectPermissionGrants> ProjectPermissions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BulkPermissionGrants"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BulkPermissionGrants CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkPermissionGrants();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"globalPermissions", n => { GlobalPermissions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"projectPermissions", n => { ProjectPermissions = n.GetCollectionOfObjectValues<BulkProjectPermissionGrants>(BulkProjectPermissionGrants.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("globalPermissions", GlobalPermissions);
            writer.WriteCollectionOfObjectValues<BulkProjectPermissionGrants>("projectPermissions", ProjectPermissions);
        }
    }
}
