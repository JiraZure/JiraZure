// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace JiraLib.Models {
    /// <summary>
    /// Details of functions that can be used in advanced searches.
    /// </summary>
    public class FunctionReferenceData : IParsable 
    {
        /// <summary>The display name of the function.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Whether the function can take a list of arguments.</summary>
        public FunctionReferenceData_isList? IsList { get; set; }
        /// <summary>Whether the function supports both single and list value operators.</summary>
        public FunctionReferenceData_supportsListAndSingleValueOperators? SupportsListAndSingleValueOperators { get; set; }
        /// <summary>The data types returned by the function.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Types { get; set; }
#nullable restore
#else
        public List<string> Types { get; set; }
#endif
        /// <summary>The function identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="FunctionReferenceData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FunctionReferenceData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FunctionReferenceData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isList", n => { IsList = n.GetEnumValue<FunctionReferenceData_isList>(); } },
                {"supportsListAndSingleValueOperators", n => { SupportsListAndSingleValueOperators = n.GetEnumValue<FunctionReferenceData_supportsListAndSingleValueOperators>(); } },
                {"types", n => { Types = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<FunctionReferenceData_isList>("isList", IsList);
            writer.WriteEnumValue<FunctionReferenceData_supportsListAndSingleValueOperators>("supportsListAndSingleValueOperators", SupportsListAndSingleValueOperators);
            writer.WriteCollectionOfPrimitiveValues<string>("types", Types);
            writer.WriteStringValue("value", Value);
        }
    }
}
