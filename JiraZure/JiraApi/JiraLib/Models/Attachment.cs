// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details about an attachment.
    /// </summary>
    public class Attachment : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Details of the user who added the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserDetails? Author { get; private set; }
#nullable restore
#else
        public UserDetails Author { get; private set; }
#endif
        /// <summary>The content of the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Content { get; private set; }
#nullable restore
#else
        public string Content { get; private set; }
#endif
        /// <summary>The datetime the attachment was created.</summary>
        public DateTimeOffset? Created { get; private set; }
        /// <summary>The file name of the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Filename { get; private set; }
#nullable restore
#else
        public string Filename { get; private set; }
#endif
        /// <summary>The ID of the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>The MIME type of the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MimeType { get; private set; }
#nullable restore
#else
        public string MimeType { get; private set; }
#endif
        /// <summary>The URL of the attachment details response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; private set; }
#nullable restore
#else
        public string Self { get; private set; }
#endif
        /// <summary>The size of the attachment.</summary>
        public long? Size { get; private set; }
        /// <summary>The URL of a thumbnail representing the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Thumbnail { get; private set; }
#nullable restore
#else
        public string Thumbnail { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Attachment"/> and sets the default values.
        /// </summary>
        public Attachment()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Attachment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Attachment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Attachment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"author", n => { Author = n.GetObjectValue<UserDetails>(UserDetails.CreateFromDiscriminatorValue); } },
                {"content", n => { Content = n.GetStringValue(); } },
                {"created", n => { Created = n.GetDateTimeOffsetValue(); } },
                {"filename", n => { Filename = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"mimeType", n => { MimeType = n.GetStringValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"thumbnail", n => { Thumbnail = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
