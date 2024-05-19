// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace JiraLib.Models {
    /// <summary>Determines how the conditions in the group are evaluated. Accepts either `ANY` or `ALL`. If `ANY` is used, at least one condition in the group must be true for the group to evaluate to true. If `ALL` is used, all conditions in the group must be true for the group to evaluate to true.</summary>
    public enum ConditionGroupConfiguration_operation
    {
        [EnumMember(Value = "ANY")]
        #pragma warning disable CS1591
        ANY,
        #pragma warning restore CS1591
        [EnumMember(Value = "ALL")]
        #pragma warning disable CS1591
        ALL,
        #pragma warning restore CS1591
    }
}
