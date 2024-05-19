// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details about an issue type.
    /// </summary>
    public class IssueTypeDetails : IParsable 
    {
        /// <summary>The ID of the issue type&apos;s avatar.</summary>
        public long? AvatarId { get; private set; }
        /// <summary>The description of the issue type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; private set; }
#nullable restore
#else
        public string Description { get; private set; }
#endif
        /// <summary>Unique ID for next-gen projects.</summary>
        public Guid? EntityId { get; private set; }
        /// <summary>Hierarchy level of the issue type.</summary>
        public int? HierarchyLevel { get; private set; }
        /// <summary>The URL of the issue type&apos;s avatar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IconUrl { get; private set; }
#nullable restore
#else
        public string IconUrl { get; private set; }
#endif
        /// <summary>The ID of the issue type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>The name of the issue type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; private set; }
#nullable restore
#else
        public string Name { get; private set; }
#endif
        /// <summary>Details of the next-gen projects the issue type is available in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JiraLib.Models.Scope? Scope { get; private set; }
#nullable restore
#else
        public JiraLib.Models.Scope Scope { get; private set; }
#endif
        /// <summary>The URL of these issue type details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; private set; }
#nullable restore
#else
        public string Self { get; private set; }
#endif
        /// <summary>Whether this issue type is used to create subtasks.</summary>
        public bool? Subtask { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="IssueTypeDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IssueTypeDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IssueTypeDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"avatarId", n => { AvatarId = n.GetLongValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"entityId", n => { EntityId = n.GetGuidValue(); } },
                {"hierarchyLevel", n => { HierarchyLevel = n.GetIntValue(); } },
                {"iconUrl", n => { IconUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetObjectValue<JiraLib.Models.Scope>(JiraLib.Models.Scope.CreateFromDiscriminatorValue); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"subtask", n => { Subtask = n.GetBoolValue(); } },
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
