// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    #pragma warning disable CS1591
    public class IdBean : IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The ID of the permission scheme to associate with the project. Use the [Get all permission schemes](#api-rest-api-3-permissionscheme-get) resource to get a list of permission scheme IDs.</summary>
        public long? Id { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IdBean"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IdBean CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdBean();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
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
            writer.WriteLongValue("id", Id);
        }
    }
}
