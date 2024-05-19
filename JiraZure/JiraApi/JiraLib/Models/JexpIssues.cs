// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// The JQL specifying the issues available in the evaluated Jira expression under the `issues` context variable.
    /// </summary>
    public class JexpIssues : IParsable 
    {
        /// <summary>The JQL query that specifies the set of issues available in the Jira expression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JexpJqlIssues? Jql { get; set; }
#nullable restore
#else
        public JexpJqlIssues Jql { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="JexpIssues"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JexpIssues CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JexpIssues();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"jql", n => { Jql = n.GetObjectValue<JexpJqlIssues>(JexpJqlIssues.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<JexpJqlIssues>("jql", Jql);
        }
    }
}
