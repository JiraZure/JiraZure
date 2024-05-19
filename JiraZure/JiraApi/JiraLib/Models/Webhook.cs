// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// A webhook.
    /// </summary>
    public class Webhook : IParsable 
    {
        /// <summary>The Jira events that trigger the webhook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Webhook_events?>? Events { get; set; }
#nullable restore
#else
        public List<Webhook_events?> Events { get; set; }
#endif
        /// <summary>The date after which the webhook is no longer sent. Use [Extend webhook life](https://developer.atlassian.com/cloud/jira/platform/rest/v3/api-group-webhooks/#api-rest-api-3-webhook-refresh-put) to extend the date.</summary>
        public long? ExpirationDate { get; private set; }
        /// <summary>A list of field IDs. When the issue changelog contains any of the fields, the webhook `jira:issue_updated` is sent. If this parameter is not present, the app is notified about all field updates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? FieldIdsFilter { get; set; }
#nullable restore
#else
        public List<string> FieldIdsFilter { get; set; }
#endif
        /// <summary>The ID of the webhook.</summary>
        public long? Id { get; set; }
        /// <summary>A list of issue property keys. A change of those issue properties triggers the `issue_property_set` or `issue_property_deleted` webhooks. If this parameter is not present, the app is notified about all issue property updates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IssuePropertyKeysFilter { get; set; }
#nullable restore
#else
        public List<string> IssuePropertyKeysFilter { get; set; }
#endif
        /// <summary>The JQL filter that specifies which issues the webhook is sent for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JqlFilter { get; set; }
#nullable restore
#else
        public string JqlFilter { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Webhook"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Webhook CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Webhook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"events", n => { Events = n.GetCollectionOfEnumValues<Webhook_events>()?.ToList(); } },
                {"expirationDate", n => { ExpirationDate = n.GetLongValue(); } },
                {"fieldIdsFilter", n => { FieldIdsFilter = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"issuePropertyKeysFilter", n => { IssuePropertyKeysFilter = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"jqlFilter", n => { JqlFilter = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<Webhook_events>("events", Events);
            writer.WriteCollectionOfPrimitiveValues<string>("fieldIdsFilter", FieldIdsFilter);
            writer.WriteLongValue("id", Id);
            writer.WriteCollectionOfPrimitiveValues<string>("issuePropertyKeysFilter", IssuePropertyKeysFilter);
            writer.WriteStringValue("jqlFilter", JqlFilter);
        }
    }
}
