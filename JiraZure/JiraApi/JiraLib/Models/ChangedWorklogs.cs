// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// List of changed worklogs.
    /// </summary>
    public class ChangedWorklogs : IParsable 
    {
        /// <summary>The lastPage property</summary>
        public bool? LastPage { get; set; }
        /// <summary>The URL of the next list of changed worklogs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextPage { get; private set; }
#nullable restore
#else
        public string NextPage { get; private set; }
#endif
        /// <summary>The URL of this changed worklogs list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; private set; }
#nullable restore
#else
        public string Self { get; private set; }
#endif
        /// <summary>The datetime of the first worklog item in the list.</summary>
        public long? Since { get; private set; }
        /// <summary>The datetime of the last worklog item in the list.</summary>
        public long? Until { get; private set; }
        /// <summary>Changed worklog list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChangedWorklog>? Values { get; private set; }
#nullable restore
#else
        public List<ChangedWorklog> Values { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ChangedWorklogs"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ChangedWorklogs CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChangedWorklogs();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"lastPage", n => { LastPage = n.GetBoolValue(); } },
                {"nextPage", n => { NextPage = n.GetStringValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"since", n => { Since = n.GetLongValue(); } },
                {"until", n => { Until = n.GetLongValue(); } },
                {"values", n => { Values = n.GetCollectionOfObjectValues<ChangedWorklog>(ChangedWorklog.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("lastPage", LastPage);
        }
    }
}
