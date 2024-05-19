// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details about a workflow scheme.
    /// </summary>
    public class WorkflowScheme : IParsable 
    {
        /// <summary>The name of the default workflow for the workflow scheme. The default workflow has *All Unassigned Issue Types* assigned to it in Jira. If `defaultWorkflow` is not specified when creating a workflow scheme, it is set to *Jira Workflow (jira)*.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultWorkflow { get; set; }
#nullable restore
#else
        public string DefaultWorkflow { get; set; }
#endif
        /// <summary>The description of the workflow scheme.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Whether the workflow scheme is a draft or not.</summary>
        public bool? Draft { get; private set; }
        /// <summary>The ID of the workflow scheme.</summary>
        public long? Id { get; private set; }
        /// <summary>The issue type to workflow mappings, where each mapping is an issue type ID and workflow name pair. Note that an issue type can only be mapped to one workflow in a workflow scheme.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowScheme_issueTypeMappings? IssueTypeMappings { get; set; }
#nullable restore
#else
        public WorkflowScheme_issueTypeMappings IssueTypeMappings { get; set; }
#endif
        /// <summary>The issue types available in Jira.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowScheme_issueTypes? IssueTypes { get; private set; }
#nullable restore
#else
        public WorkflowScheme_issueTypes IssueTypes { get; private set; }
#endif
        /// <summary>The date-time that the draft workflow scheme was last modified. A modification is a change to the issue type-project mappings only. This property does not apply to non-draft workflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModified { get; private set; }
#nullable restore
#else
        public string LastModified { get; private set; }
#endif
        /// <summary>The user that last modified the draft workflow scheme. A modification is a change to the issue type-project mappings only. This property does not apply to non-draft workflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public User? LastModifiedUser { get; private set; }
#nullable restore
#else
        public User LastModifiedUser { get; private set; }
#endif
        /// <summary>The name of the workflow scheme. The name must be unique. The maximum length is 255 characters. Required when creating a workflow scheme.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>For draft workflow schemes, this property is the name of the default workflow for the original workflow scheme. The default workflow has *All Unassigned Issue Types* assigned to it in Jira.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalDefaultWorkflow { get; private set; }
#nullable restore
#else
        public string OriginalDefaultWorkflow { get; private set; }
#endif
        /// <summary>For draft workflow schemes, this property is the issue type to workflow mappings for the original workflow scheme, where each mapping is an issue type ID and workflow name pair. Note that an issue type can only be mapped to one workflow in a workflow scheme.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowScheme_originalIssueTypeMappings? OriginalIssueTypeMappings { get; private set; }
#nullable restore
#else
        public WorkflowScheme_originalIssueTypeMappings OriginalIssueTypeMappings { get; private set; }
#endif
        /// <summary>The self property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; private set; }
#nullable restore
#else
        public string Self { get; private set; }
#endif
        /// <summary>Whether to create or update a draft workflow scheme when updating an active workflow scheme. An active workflow scheme is a workflow scheme that is used by at least one project. The following examples show how this property works: *  Update an active workflow scheme with `updateDraftIfNeeded` set to `true`: If a draft workflow scheme exists, it is updated. Otherwise, a draft workflow scheme is created. *  Update an active workflow scheme with `updateDraftIfNeeded` set to `false`: An error is returned, as active workflow schemes cannot be updated. *  Update an inactive workflow scheme with `updateDraftIfNeeded` set to `true`: The workflow scheme is updated, as inactive workflow schemes do not require drafts to update.Defaults to `false`.</summary>
        public bool? UpdateDraftIfNeeded { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WorkflowScheme"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowScheme CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowScheme();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"defaultWorkflow", n => { DefaultWorkflow = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"draft", n => { Draft = n.GetBoolValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"issueTypeMappings", n => { IssueTypeMappings = n.GetObjectValue<WorkflowScheme_issueTypeMappings>(WorkflowScheme_issueTypeMappings.CreateFromDiscriminatorValue); } },
                {"issueTypes", n => { IssueTypes = n.GetObjectValue<WorkflowScheme_issueTypes>(WorkflowScheme_issueTypes.CreateFromDiscriminatorValue); } },
                {"lastModified", n => { LastModified = n.GetStringValue(); } },
                {"lastModifiedUser", n => { LastModifiedUser = n.GetObjectValue<User>(User.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"originalDefaultWorkflow", n => { OriginalDefaultWorkflow = n.GetStringValue(); } },
                {"originalIssueTypeMappings", n => { OriginalIssueTypeMappings = n.GetObjectValue<WorkflowScheme_originalIssueTypeMappings>(WorkflowScheme_originalIssueTypeMappings.CreateFromDiscriminatorValue); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"updateDraftIfNeeded", n => { UpdateDraftIfNeeded = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultWorkflow", DefaultWorkflow);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<WorkflowScheme_issueTypeMappings>("issueTypeMappings", IssueTypeMappings);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("updateDraftIfNeeded", UpdateDraftIfNeeded);
        }
    }
}
