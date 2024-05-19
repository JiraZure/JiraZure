// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// The default text for a Forge string custom field.
    /// </summary>
    public class CustomFieldContextDefaultValueForgeStringField : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContextId { get; set; }
#nullable restore
#else
        public string ContextId { get; set; }
#endif
        /// <summary>The default text. The maximum length is 254 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CustomFieldContextDefaultValueForgeStringField"/> and sets the default values.
        /// </summary>
        public CustomFieldContextDefaultValueForgeStringField()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CustomFieldContextDefaultValueForgeStringField"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CustomFieldContextDefaultValueForgeStringField CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomFieldContextDefaultValueForgeStringField();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"contextId", n => { ContextId = n.GetStringValue(); } },
                {"text", n => { Text = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contextId", ContextId);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
