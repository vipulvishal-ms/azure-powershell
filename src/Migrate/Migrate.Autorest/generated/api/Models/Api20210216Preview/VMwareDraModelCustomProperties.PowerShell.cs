// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>VMware DRA model custom properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(VMwareDraModelCustomPropertiesTypeConverter))]
    public partial class VMwareDraModelCustomProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.VMwareDraModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMwareDraModelCustomProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.VMwareDraModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMwareDraModelCustomProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMwareDraModelCustomProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VMwareDraModelCustomProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.VMwareDraModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMwareDraModelCustomProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MarsAuthenticationIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarsAuthenticationIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModel) content.GetValueForProperty("MarsAuthenticationIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarsAuthenticationIdentity, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IdentityModelTypeConverter.ConvertFrom);
            }
            if (content.Contains("BiosId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).BiosId = (string) content.GetValueForProperty("BiosId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).BiosId, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IDraModelCustomPropertiesInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IDraModelCustomPropertiesInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("MarAuthenticationIdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityTenantId = (string) content.GetValueForProperty("MarAuthenticationIdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("MarAuthenticationIdentityApplicationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityApplicationId = (string) content.GetValueForProperty("MarAuthenticationIdentityApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityApplicationId, global::System.Convert.ToString);
            }
            if (content.Contains("MarAuthenticationIdentityObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityObjectId = (string) content.GetValueForProperty("MarAuthenticationIdentityObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("MarAuthenticationIdentityAudience"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityAudience = (string) content.GetValueForProperty("MarAuthenticationIdentityAudience",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityAudience, global::System.Convert.ToString);
            }
            if (content.Contains("MarAuthenticationIdentityAadAuthority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityAadAuthority = (string) content.GetValueForProperty("MarAuthenticationIdentityAadAuthority",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityAadAuthority, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.VMwareDraModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMwareDraModelCustomProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MarsAuthenticationIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarsAuthenticationIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IIdentityModel) content.GetValueForProperty("MarsAuthenticationIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarsAuthenticationIdentity, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IdentityModelTypeConverter.ConvertFrom);
            }
            if (content.Contains("BiosId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).BiosId = (string) content.GetValueForProperty("BiosId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).BiosId, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IDraModelCustomPropertiesInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IDraModelCustomPropertiesInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("MarAuthenticationIdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityTenantId = (string) content.GetValueForProperty("MarAuthenticationIdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("MarAuthenticationIdentityApplicationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityApplicationId = (string) content.GetValueForProperty("MarAuthenticationIdentityApplicationId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityApplicationId, global::System.Convert.ToString);
            }
            if (content.Contains("MarAuthenticationIdentityObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityObjectId = (string) content.GetValueForProperty("MarAuthenticationIdentityObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("MarAuthenticationIdentityAudience"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityAudience = (string) content.GetValueForProperty("MarAuthenticationIdentityAudience",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityAudience, global::System.Convert.ToString);
            }
            if (content.Contains("MarAuthenticationIdentityAadAuthority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityAadAuthority = (string) content.GetValueForProperty("MarAuthenticationIdentityAadAuthority",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IVMwareDraModelCustomPropertiesInternal)this).MarAuthenticationIdentityAadAuthority, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// VMware DRA model custom properties.
    [System.ComponentModel.TypeConverter(typeof(VMwareDraModelCustomPropertiesTypeConverter))]
    public partial interface IVMwareDraModelCustomProperties

    {

    }
}