// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    #pragma warning disable CS1591
    public class ProjectLandingPageInfo : IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProjectLandingPageInfo_attributes? Attributes { get; set; }
#nullable restore
#else
        public ProjectLandingPageInfo_attributes Attributes { get; set; }
#endif
        /// <summary>The boardId property</summary>
        public long? BoardId { get; set; }
        /// <summary>The boardName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BoardName { get; set; }
#nullable restore
#else
        public string BoardName { get; set; }
#endif
        /// <summary>The projectKey property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectKey { get; set; }
#nullable restore
#else
        public string ProjectKey { get; set; }
#endif
        /// <summary>The projectType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectType { get; set; }
#nullable restore
#else
        public string ProjectType { get; set; }
#endif
        /// <summary>The queueCategory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QueueCategory { get; set; }
#nullable restore
#else
        public string QueueCategory { get; set; }
#endif
        /// <summary>The queueId property</summary>
        public long? QueueId { get; set; }
        /// <summary>The queueName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QueueName { get; set; }
#nullable restore
#else
        public string QueueName { get; set; }
#endif
        /// <summary>The simpleBoard property</summary>
        public bool? SimpleBoard { get; set; }
        /// <summary>The simplified property</summary>
        public bool? Simplified { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ProjectLandingPageInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProjectLandingPageInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProjectLandingPageInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"attributes", n => { Attributes = n.GetObjectValue<ProjectLandingPageInfo_attributes>(ProjectLandingPageInfo_attributes.CreateFromDiscriminatorValue); } },
                {"boardId", n => { BoardId = n.GetLongValue(); } },
                {"boardName", n => { BoardName = n.GetStringValue(); } },
                {"projectKey", n => { ProjectKey = n.GetStringValue(); } },
                {"projectType", n => { ProjectType = n.GetStringValue(); } },
                {"queueCategory", n => { QueueCategory = n.GetStringValue(); } },
                {"queueId", n => { QueueId = n.GetLongValue(); } },
                {"queueName", n => { QueueName = n.GetStringValue(); } },
                {"simpleBoard", n => { SimpleBoard = n.GetBoolValue(); } },
                {"simplified", n => { Simplified = n.GetBoolValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ProjectLandingPageInfo_attributes>("attributes", Attributes);
            writer.WriteLongValue("boardId", BoardId);
            writer.WriteStringValue("boardName", BoardName);
            writer.WriteStringValue("projectKey", ProjectKey);
            writer.WriteStringValue("projectType", ProjectType);
            writer.WriteStringValue("queueCategory", QueueCategory);
            writer.WriteLongValue("queueId", QueueId);
            writer.WriteStringValue("queueName", QueueName);
            writer.WriteBoolValue("simpleBoard", SimpleBoard);
            writer.WriteBoolValue("simplified", Simplified);
            writer.WriteStringValue("url", Url);
        }
    }
}
