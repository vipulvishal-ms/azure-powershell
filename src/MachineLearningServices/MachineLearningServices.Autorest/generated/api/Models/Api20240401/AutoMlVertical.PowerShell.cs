// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>
    /// AutoML vertical class.
    /// Base class for AutoML verticals - TableVertical/ImageVertical/NLPVertical
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(AutoMlVerticalTypeConverter))]
    public partial class AutoMlVertical
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.AutoMlVertical"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AutoMlVertical(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TrainingData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingData = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMlTableJobInput) content.GetValueForProperty("TrainingData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingData, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MlTableJobInputTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogVerbosity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).LogVerbosity = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LogVerbosity?) content.GetValueForProperty("LogVerbosity",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).LogVerbosity, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LogVerbosity.CreateFrom);
            }
            if (content.Contains("TargetColumnName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TargetColumnName = (string) content.GetValueForProperty("TargetColumnName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TargetColumnName, global::System.Convert.ToString);
            }
            if (content.Contains("TaskType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TaskType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TaskType) content.GetValueForProperty("TaskType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TaskType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TaskType.CreateFrom);
            }
            if (content.Contains("TrainingDataMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataMode = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.InputDeliveryMode?) content.GetValueForProperty("TrainingDataMode",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataMode, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.InputDeliveryMode.CreateFrom);
            }
            if (content.Contains("TrainingDataUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataUri = (string) content.GetValueForProperty("TrainingDataUri",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataUri, global::System.Convert.ToString);
            }
            if (content.Contains("TrainingDataDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataDescription = (string) content.GetValueForProperty("TrainingDataDescription",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataDescription, global::System.Convert.ToString);
            }
            if (content.Contains("TrainingDataJobInputType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataJobInputType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType) content.GetValueForProperty("TrainingDataJobInputType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataJobInputType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.AutoMlVertical"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AutoMlVertical(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TrainingData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingData = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMlTableJobInput) content.GetValueForProperty("TrainingData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingData, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MlTableJobInputTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogVerbosity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).LogVerbosity = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LogVerbosity?) content.GetValueForProperty("LogVerbosity",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).LogVerbosity, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LogVerbosity.CreateFrom);
            }
            if (content.Contains("TargetColumnName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TargetColumnName = (string) content.GetValueForProperty("TargetColumnName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TargetColumnName, global::System.Convert.ToString);
            }
            if (content.Contains("TaskType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TaskType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TaskType) content.GetValueForProperty("TaskType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TaskType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TaskType.CreateFrom);
            }
            if (content.Contains("TrainingDataMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataMode = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.InputDeliveryMode?) content.GetValueForProperty("TrainingDataMode",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataMode, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.InputDeliveryMode.CreateFrom);
            }
            if (content.Contains("TrainingDataUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataUri = (string) content.GetValueForProperty("TrainingDataUri",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataUri, global::System.Convert.ToString);
            }
            if (content.Contains("TrainingDataDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataDescription = (string) content.GetValueForProperty("TrainingDataDescription",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataDescription, global::System.Convert.ToString);
            }
            if (content.Contains("TrainingDataJobInputType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataJobInputType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType) content.GetValueForProperty("TrainingDataJobInputType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVerticalInternal)this).TrainingDataJobInputType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.AutoMlVertical"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVertical"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVertical DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AutoMlVertical(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.AutoMlVertical"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVertical"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVertical DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AutoMlVertical(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AutoMlVertical" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AutoMlVertical" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoMlVertical FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// AutoML vertical class.
    /// Base class for AutoML verticals - TableVertical/ImageVertical/NLPVertical
    [System.ComponentModel.TypeConverter(typeof(AutoMlVerticalTypeConverter))]
    public partial interface IAutoMlVertical

    {

    }
}