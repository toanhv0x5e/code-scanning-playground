// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.CodeAnalysis.Sarif.Readers;
using Newtonsoft.Json;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// Metadata that describes a specific report produced by the tool, as part of the analysis it provides or its runtime reporting.
    /// </summary>
    [DataContract]
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "0.62.0.0")]
    public partial class ReportingDescriptor : PropertyBagHolder, ISarifNode
    {
        public static IEqualityComparer<ReportingDescriptor> ValueComparer => ReportingDescriptorEqualityComparer.Instance;

        public bool ValueEquals(ReportingDescriptor other) => ValueComparer.Equals(this, other);
        public int ValueGetHashCode() => ValueComparer.GetHashCode(this);

        /// <summary>
        /// Gets a value indicating the type of object implementing <see cref="ISarifNode" />.
        /// </summary>
        public SarifNodeKind SarifNodeKind
        {
            get
            {
                return SarifNodeKind.ReportingDescriptor;
            }
        }

        // NOTYETAUTOGENERATED: Jschema needs a mechanism to emit all public methods as virtual
        // https://github.com/Microsoft/jschema/issues/97
        //
        /// <summary>
        /// A stable, opaque identifier for the report.
        /// </summary>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public virtual string Id { get; set; }

        /// <summary>
        /// An array of stable, opaque identifiers by which this report was known in some previous version of the analysis tool.
        /// </summary>
        [DataMember(Name = "deprecatedIds", IsRequired = false, EmitDefaultValue = false)]
        public virtual IList<string> DeprecatedIds { get; set; }

        /// <summary>
        /// A unique identifer for the reporting descriptor in the form of a GUID.
        /// </summary>
        [DataMember(Name = "guid", IsRequired = false, EmitDefaultValue = false)]
        public virtual string Guid { get; set; }

        /// <summary>
        /// An array of unique identifies in the form of a GUID by which this report was known in some previous version of the analysis tool.
        /// </summary>
        [DataMember(Name = "deprecatedGuids", IsRequired = false, EmitDefaultValue = false)]
        public virtual IList<string> DeprecatedGuids { get; set; }

        /// <summary>
        /// A report identifier that is understandable to an end user.
        /// </summary>
        [DataMember(Name = "name", IsRequired = false, EmitDefaultValue = false)]
        public virtual string Name { get; set; }

        /// <summary>
        /// An array of readable identifiers by which this report was known in some previous version of the analysis tool.
        /// </summary>
        [DataMember(Name = "deprecatedNames", IsRequired = false, EmitDefaultValue = false)]
        public virtual IList<string> DeprecatedNames { get; set; }

        /// <summary>
        /// A concise description of the report. Should be a single sentence that is understandable when visible space is limited to a single line of text.
        /// </summary>
        [DataMember(Name = "shortDescription", IsRequired = false, EmitDefaultValue = false)]
        public virtual MultiformatMessageString ShortDescription { get; set; }

        /// <summary>
        /// A description of the report. Should, as far as possible, provide details sufficient to enable resolution of any problem indicated by the result.
        /// </summary>
        [DataMember(Name = "fullDescription", IsRequired = false, EmitDefaultValue = false)]
        public virtual MultiformatMessageString FullDescription { get; set; }

        /// <summary>
        /// A set of name/value pairs with arbitrary names. Each value is a multiformatMessageString object, which holds message strings in plain text and (optionally) Markdown format. The strings can include placeholders, which can be used to construct a message in combination with an arbitrary number of additional string arguments.
        /// </summary>
        [DataMember(Name = "messageStrings", IsRequired = false, EmitDefaultValue = false)]
        public virtual IDictionary<string, MultiformatMessageString> MessageStrings { get; set; }

        /// <summary>
        /// Default reporting configuration information.
        /// </summary>
        [DataMember(Name = "defaultConfiguration", IsRequired = false, EmitDefaultValue = false)]
        public virtual ReportingConfiguration DefaultConfiguration { get; set; }

        /// <summary>
        /// A URI where the primary documentation for the report can be found.
        /// </summary>
        [DataMember(Name = "helpUri", IsRequired = false, EmitDefaultValue = false)]
        [JsonConverter(typeof(Microsoft.CodeAnalysis.Sarif.Readers.UriConverter))]
        public virtual Uri HelpUri { get; set; }

        /// <summary>
        /// Provides the primary documentation for the report, useful when there is no online documentation.
        /// </summary>
        [DataMember(Name = "help", IsRequired = false, EmitDefaultValue = false)]
        public virtual MultiformatMessageString Help { get; set; }

        /// <summary>
        /// An array of objects that describe relationships between this reporting descriptor and others.
        /// </summary>
        [DataMember(Name = "relationships", IsRequired = false, EmitDefaultValue = false)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public virtual IList<ReportingDescriptorRelationship> Relationships { get; set; }

        /// <summary>
        /// Key/value pairs that provide additional information about the report.
        /// </summary>
        [DataMember(Name = "properties", IsRequired = false, EmitDefaultValue = false)]
        internal override IDictionary<string, SerializedPropertyInfo> Properties { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingDescriptor" /> class.
        /// </summary>
        public ReportingDescriptor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingDescriptor" /> class from the supplied values.
        /// </summary>
        /// <param name="id">
        /// An initialization value for the <see cref="P:Id" /> property.
        /// </param>
        /// <param name="deprecatedIds">
        /// An initialization value for the <see cref="P:DeprecatedIds" /> property.
        /// </param>
        /// <param name="guid">
        /// An initialization value for the <see cref="P:Guid" /> property.
        /// </param>
        /// <param name="deprecatedGuids">
        /// An initialization value for the <see cref="P:DeprecatedGuids" /> property.
        /// </param>
        /// <param name="name">
        /// An initialization value for the <see cref="P:Name" /> property.
        /// </param>
        /// <param name="deprecatedNames">
        /// An initialization value for the <see cref="P:DeprecatedNames" /> property.
        /// </param>
        /// <param name="shortDescription">
        /// An initialization value for the <see cref="P:ShortDescription" /> property.
        /// </param>
        /// <param name="fullDescription">
        /// An initialization value for the <see cref="P:FullDescription" /> property.
        /// </param>
        /// <param name="messageStrings">
        /// An initialization value for the <see cref="P:MessageStrings" /> property.
        /// </param>
        /// <param name="defaultConfiguration">
        /// An initialization value for the <see cref="P:DefaultConfiguration" /> property.
        /// </param>
        /// <param name="helpUri">
        /// An initialization value for the <see cref="P:HelpUri" /> property.
        /// </param>
        /// <param name="help">
        /// An initialization value for the <see cref="P:Help" /> property.
        /// </param>
        /// <param name="relationships">
        /// An initialization value for the <see cref="P:Relationships" /> property.
        /// </param>
        /// <param name="properties">
        /// An initialization value for the <see cref="P:Properties" /> property.
        /// </param>
        public ReportingDescriptor(string id, IEnumerable<string> deprecatedIds, string guid, IEnumerable<string> deprecatedGuids, string name, IEnumerable<string> deprecatedNames, MultiformatMessageString shortDescription, MultiformatMessageString fullDescription, IDictionary<string, MultiformatMessageString> messageStrings, ReportingConfiguration defaultConfiguration, Uri helpUri, MultiformatMessageString help, IEnumerable<ReportingDescriptorRelationship> relationships, IDictionary<string, SerializedPropertyInfo> properties)
        {
            Init(id, deprecatedIds, guid, deprecatedGuids, name, deprecatedNames, shortDescription, fullDescription, messageStrings, defaultConfiguration, helpUri, help, relationships, properties);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingDescriptor" /> class from the specified instance.
        /// </summary>
        /// <param name="other">
        /// The instance from which the new instance is to be initialized.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other" /> is null.
        /// </exception>
        public ReportingDescriptor(ReportingDescriptor other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            Init(other.Id, other.DeprecatedIds, other.Guid, other.DeprecatedGuids, other.Name, other.DeprecatedNames, other.ShortDescription, other.FullDescription, other.MessageStrings, other.DefaultConfiguration, other.HelpUri, other.Help, other.Relationships, other.Properties);
        }

        ISarifNode ISarifNode.DeepClone()
        {
            return DeepCloneCore();
        }

        /// <summary>
        /// Creates a deep copy of this instance.
        /// </summary>
        public ReportingDescriptor DeepClone()
        {
            return (ReportingDescriptor)DeepCloneCore();
        }

        private ISarifNode DeepCloneCore()
        {
            return new ReportingDescriptor(this);
        }

        private void Init(string id, IEnumerable<string> deprecatedIds, string guid, IEnumerable<string> deprecatedGuids, string name, IEnumerable<string> deprecatedNames, MultiformatMessageString shortDescription, MultiformatMessageString fullDescription, IDictionary<string, MultiformatMessageString> messageStrings, ReportingConfiguration defaultConfiguration, Uri helpUri, MultiformatMessageString help, IEnumerable<ReportingDescriptorRelationship> relationships, IDictionary<string, SerializedPropertyInfo> properties)
        {
            Id = id;
            if (deprecatedIds != null)
            {
                var destination_0 = new List<string>();
                foreach (var value_0 in deprecatedIds)
                {
                    destination_0.Add(value_0);
                }

                DeprecatedIds = destination_0;
            }

            Guid = guid;
            if (deprecatedGuids != null)
            {
                var destination_1 = new List<string>();
                foreach (var value_1 in deprecatedGuids)
                {
                    destination_1.Add(value_1);
                }

                DeprecatedGuids = destination_1;
            }

            Name = name;
            if (deprecatedNames != null)
            {
                var destination_2 = new List<string>();
                foreach (var value_2 in deprecatedNames)
                {
                    destination_2.Add(value_2);
                }

                DeprecatedNames = destination_2;
            }

            if (shortDescription != null)
            {
                ShortDescription = new MultiformatMessageString(shortDescription);
            }

            if (fullDescription != null)
            {
                FullDescription = new MultiformatMessageString(fullDescription);
            }

            if (messageStrings != null)
            {
                MessageStrings = new Dictionary<string, MultiformatMessageString>();
                foreach (var value_3 in messageStrings)
                {
                    MessageStrings.Add(value_3.Key, new MultiformatMessageString(value_3.Value));
                }
            }

            if (defaultConfiguration != null)
            {
                DefaultConfiguration = new ReportingConfiguration(defaultConfiguration);
            }

            if (helpUri != null)
            {
                HelpUri = new Uri(helpUri.OriginalString, helpUri.IsAbsoluteUri ? UriKind.Absolute : UriKind.Relative);
            }

            if (help != null)
            {
                Help = new MultiformatMessageString(help);
            }

            if (relationships != null)
            {
                var destination_3 = new List<ReportingDescriptorRelationship>();
                foreach (var value_4 in relationships)
                {
                    if (value_4 == null)
                    {
                        destination_3.Add(null);
                    }
                    else
                    {
                        destination_3.Add(new ReportingDescriptorRelationship(value_4));
                    }
                }

                Relationships = destination_3;
            }

            if (properties != null)
            {
                Properties = new Dictionary<string, SerializedPropertyInfo>(properties);
            }
        }
    }
}