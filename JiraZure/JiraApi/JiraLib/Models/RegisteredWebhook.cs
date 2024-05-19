// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// ID of a registered webhook or error messages explaining why a webhook wasn&apos;t registered.
    /// </summary>
    public class RegisteredWebhook : IParsable 
    {
        /// <summary>The ID of the webhook. Returned if the webhook is created.</summary>
        public long? CreatedWebhookId { get; set; }
        /// <summary>Error messages specifying why the webhook creation failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Errors { get; set; }
#nullable restore
#else
        public List<string> Errors { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RegisteredWebhook"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RegisteredWebhook CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegisteredWebhook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"createdWebhookId", n => { CreatedWebhookId = n.GetLongValue(); } },
                {"errors", n => { Errors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("createdWebhookId", CreatedWebhookId);
            writer.WriteCollectionOfPrimitiveValues<string>("errors", Errors);
        }
    }
}
