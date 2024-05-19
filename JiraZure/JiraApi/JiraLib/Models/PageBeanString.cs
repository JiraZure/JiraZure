// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// A page of items.
    /// </summary>
    public class PageBeanString : IParsable 
    {
        /// <summary>Whether this is the last page.</summary>
        public bool? IsLast { get; private set; }
        /// <summary>The maximum number of items that could be returned.</summary>
        public int? MaxResults { get; private set; }
        /// <summary>If there is another page of results, the URL of the next page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextPage { get; private set; }
#nullable restore
#else
        public string NextPage { get; private set; }
#endif
        /// <summary>The URL of the page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; private set; }
#nullable restore
#else
        public string Self { get; private set; }
#endif
        /// <summary>The index of the first item returned.</summary>
        public long? StartAt { get; private set; }
        /// <summary>The number of items returned.</summary>
        public long? Total { get; private set; }
        /// <summary>The list of items.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Values { get; private set; }
#nullable restore
#else
        public List<string> Values { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PageBeanString"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PageBeanString CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PageBeanString();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"isLast", n => { IsLast = n.GetBoolValue(); } },
                {"maxResults", n => { MaxResults = n.GetIntValue(); } },
                {"nextPage", n => { NextPage = n.GetStringValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"startAt", n => { StartAt = n.GetLongValue(); } },
                {"total", n => { Total = n.GetLongValue(); } },
                {"values", n => { Values = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
        }
    }
}
