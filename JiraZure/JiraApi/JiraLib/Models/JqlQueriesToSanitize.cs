// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// The list of JQL queries to sanitize for the given account IDs.
    /// </summary>
    public class JqlQueriesToSanitize : IParsable 
    {
        /// <summary>The list of JQL queries to sanitize. Must contain unique values. Maximum of 20 queries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JqlQueryToSanitize>? Queries { get; set; }
#nullable restore
#else
        public List<JqlQueryToSanitize> Queries { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="JqlQueriesToSanitize"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JqlQueriesToSanitize CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JqlQueriesToSanitize();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"queries", n => { Queries = n.GetCollectionOfObjectValues<JqlQueryToSanitize>(JqlQueryToSanitize.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<JqlQueryToSanitize>("queries", Queries);
        }
    }
}
