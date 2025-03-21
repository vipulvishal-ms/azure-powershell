// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>Azure Resource Manager resource envelope.</summary>
    [System.ComponentModel.TypeConverter(typeof(DataVersionBaseTypeConverter))]
    public partial class DataVersionBase
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataVersionBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DataVersionBase(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataVersionBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("XmsAsyncOperationTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).XmsAsyncOperationTimeout = (global::System.TimeSpan?) content.GetValueForProperty("XmsAsyncOperationTimeout",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).XmsAsyncOperationTimeout, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceBaseProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).ResourceBaseProperty = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseProperties) content.GetValueForProperty("ResourceBaseProperty",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).ResourceBaseProperty, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ResourceBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).DataType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType) content.GetValueForProperty("DataType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).DataType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ResourceBaseTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IsAnonymou"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).IsAnonymou = (bool?) content.GetValueForProperty("IsAnonymou",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).IsAnonymou, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsArchived"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).IsArchived = (bool?) content.GetValueForProperty("IsArchived",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).IsArchived, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DataUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).DataUri = (string) content.GetValueForProperty("DataUri",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).DataUri, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataVersionBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DataVersionBase(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataVersionBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("XmsAsyncOperationTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).XmsAsyncOperationTimeout = (global::System.TimeSpan?) content.GetValueForProperty("XmsAsyncOperationTimeout",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).XmsAsyncOperationTimeout, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceBaseProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).ResourceBaseProperty = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseProperties) content.GetValueForProperty("ResourceBaseProperty",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).ResourceBaseProperty, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ResourceBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).DataType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType) content.GetValueForProperty("DataType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).DataType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.DataType.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ResourceBaseTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IsAnonymou"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).IsAnonymou = (bool?) content.GetValueForProperty("IsAnonymou",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).IsAnonymou, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsArchived"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).IsArchived = (bool?) content.GetValueForProperty("IsArchived",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).IsArchived, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DataUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).DataUri = (string) content.GetValueForProperty("DataUri",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBaseInternal)this).DataUri, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataVersionBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBase"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBase DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DataVersionBase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataVersionBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBase"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBase DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DataVersionBase(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataVersionBase" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DataVersionBase" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataVersionBase FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Azure Resource Manager resource envelope.
    [System.ComponentModel.TypeConverter(typeof(DataVersionBaseTypeConverter))]
    public partial interface IDataVersionBase

    {

    }
}