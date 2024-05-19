// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details of global permissions to look up and project permissions with associated projects and issues to look up.
    /// </summary>
    public class BulkPermissionsRequestBean : IParsable 
    {
        /// <summary>The account ID of a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId { get; set; }
#nullable restore
#else
        public string AccountId { get; set; }
#endif
        /// <summary>Global permissions to look up.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GlobalPermissions { get; set; }
#nullable restore
#else
        public List<string> GlobalPermissions { get; set; }
#endif
        /// <summary>Project permissions with associated projects and issues to look up.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BulkProjectPermissions>? ProjectPermissions { get; set; }
#nullable restore
#else
        public List<BulkProjectPermissions> ProjectPermissions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BulkPermissionsRequestBean"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BulkPermissionsRequestBean CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkPermissionsRequestBean();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"accountId", n => { AccountId = n.GetStringValue(); } },
                {"globalPermissions", n => { GlobalPermissions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"projectPermissions", n => { ProjectPermissions = n.GetCollectionOfObjectValues<BulkProjectPermissions>(BulkProjectPermissions.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteCollectionOfPrimitiveValues<string>("globalPermissions", GlobalPermissions);
            writer.WriteCollectionOfObjectValues<BulkProjectPermissions>("projectPermissions", ProjectPermissions);
        }
    }
}
