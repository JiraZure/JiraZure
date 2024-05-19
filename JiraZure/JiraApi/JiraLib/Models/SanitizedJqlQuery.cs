// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details of the sanitized JQL query.
    /// </summary>
    public class SanitizedJqlQuery : IParsable 
    {
        /// <summary>The account ID of the user for whom sanitization was performed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId { get; set; }
#nullable restore
#else
        public string AccountId { get; set; }
#endif
        /// <summary>The list of errors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ErrorCollection? Errors { get; set; }
#nullable restore
#else
        public ErrorCollection Errors { get; set; }
#endif
        /// <summary>The initial query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitialQuery { get; set; }
#nullable restore
#else
        public string InitialQuery { get; set; }
#endif
        /// <summary>The sanitized query, if there were no errors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SanitizedQuery { get; set; }
#nullable restore
#else
        public string SanitizedQuery { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SanitizedJqlQuery"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SanitizedJqlQuery CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SanitizedJqlQuery();
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
                {"errors", n => { Errors = n.GetObjectValue<ErrorCollection>(ErrorCollection.CreateFromDiscriminatorValue); } },
                {"initialQuery", n => { InitialQuery = n.GetStringValue(); } },
                {"sanitizedQuery", n => { SanitizedQuery = n.GetStringValue(); } },
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
            writer.WriteObjectValue<ErrorCollection>("errors", Errors);
            writer.WriteStringValue("initialQuery", InitialQuery);
            writer.WriteStringValue("sanitizedQuery", SanitizedQuery);
        }
    }
}
