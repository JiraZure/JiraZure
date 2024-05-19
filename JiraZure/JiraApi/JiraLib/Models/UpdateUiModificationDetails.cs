// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// The details of a UI modification.
    /// </summary>
    public class UpdateUiModificationDetails : IParsable 
    {
        /// <summary>List of contexts of the UI modification. The maximum number of contexts is 1000. If provided, replaces all existing contexts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UiModificationContextDetails>? Contexts { get; set; }
#nullable restore
#else
        public List<UiModificationContextDetails> Contexts { get; set; }
#endif
        /// <summary>The data of the UI modification. The maximum size of the data is 50000 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Data { get; set; }
#nullable restore
#else
        public string Data { get; set; }
#endif
        /// <summary>The description of the UI modification. The maximum length is 255 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The name of the UI modification. The maximum length is 255 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UpdateUiModificationDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdateUiModificationDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateUiModificationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"contexts", n => { Contexts = n.GetCollectionOfObjectValues<UiModificationContextDetails>(UiModificationContextDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"data", n => { Data = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<UiModificationContextDetails>("contexts", Contexts);
            writer.WriteStringValue("data", Data);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
        }
    }
}
