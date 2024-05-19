// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details of an application role.
    /// </summary>
    public class ApplicationRole : IParsable 
    {
        /// <summary>The groups that are granted default access for this application role. As a group&apos;s name can change, use of `defaultGroupsDetails` is recommended to identify a groups.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefaultGroups { get; set; }
#nullable restore
#else
        public List<string> DefaultGroups { get; set; }
#endif
        /// <summary>The groups that are granted default access for this application role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GroupName>? DefaultGroupsDetails { get; set; }
#nullable restore
#else
        public List<GroupName> DefaultGroupsDetails { get; set; }
#endif
        /// <summary>Deprecated.</summary>
        public bool? Defined { get; set; }
        /// <summary>The groups associated with the application role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GroupName>? GroupDetails { get; set; }
#nullable restore
#else
        public List<GroupName> GroupDetails { get; set; }
#endif
        /// <summary>The groups associated with the application role. As a group&apos;s name can change, use of `groupDetails` is recommended to identify a groups.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Groups { get; set; }
#nullable restore
#else
        public List<string> Groups { get; set; }
#endif
        /// <summary>The hasUnlimitedSeats property</summary>
        public bool? HasUnlimitedSeats { get; set; }
        /// <summary>The key of the application role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>The display name of the application role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The maximum count of users on your license.</summary>
        public int? NumberOfSeats { get; set; }
        /// <summary>Indicates if the application role belongs to Jira platform (`jira-core`).</summary>
        public bool? Platform { get; set; }
        /// <summary>The count of users remaining on your license.</summary>
        public int? RemainingSeats { get; set; }
        /// <summary>Determines whether this application role should be selected by default on user creation.</summary>
        public bool? SelectedByDefault { get; set; }
        /// <summary>The number of users counting against your license.</summary>
        public int? UserCount { get; set; }
        /// <summary>The [type of users](https://confluence.atlassian.com/x/lRW3Ng) being counted against your license.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserCountDescription { get; set; }
#nullable restore
#else
        public string UserCountDescription { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ApplicationRole"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplicationRole CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"defaultGroups", n => { DefaultGroups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defaultGroupsDetails", n => { DefaultGroupsDetails = n.GetCollectionOfObjectValues<GroupName>(GroupName.CreateFromDiscriminatorValue)?.ToList(); } },
                {"defined", n => { Defined = n.GetBoolValue(); } },
                {"groupDetails", n => { GroupDetails = n.GetCollectionOfObjectValues<GroupName>(GroupName.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groups", n => { Groups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"hasUnlimitedSeats", n => { HasUnlimitedSeats = n.GetBoolValue(); } },
                {"key", n => { Key = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"numberOfSeats", n => { NumberOfSeats = n.GetIntValue(); } },
                {"platform", n => { Platform = n.GetBoolValue(); } },
                {"remainingSeats", n => { RemainingSeats = n.GetIntValue(); } },
                {"selectedByDefault", n => { SelectedByDefault = n.GetBoolValue(); } },
                {"userCount", n => { UserCount = n.GetIntValue(); } },
                {"userCountDescription", n => { UserCountDescription = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("defaultGroups", DefaultGroups);
            writer.WriteCollectionOfObjectValues<GroupName>("defaultGroupsDetails", DefaultGroupsDetails);
            writer.WriteBoolValue("defined", Defined);
            writer.WriteCollectionOfObjectValues<GroupName>("groupDetails", GroupDetails);
            writer.WriteCollectionOfPrimitiveValues<string>("groups", Groups);
            writer.WriteBoolValue("hasUnlimitedSeats", HasUnlimitedSeats);
            writer.WriteStringValue("key", Key);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("numberOfSeats", NumberOfSeats);
            writer.WriteBoolValue("platform", Platform);
            writer.WriteIntValue("remainingSeats", RemainingSeats);
            writer.WriteBoolValue("selectedByDefault", SelectedByDefault);
            writer.WriteIntValue("userCount", UserCount);
            writer.WriteStringValue("userCountDescription", UserCountDescription);
        }
    }
}
