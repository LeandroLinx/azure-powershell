// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.PowerShell;

    /// <summary>Patch Request content for Microsoft.DataProtection resources</summary>
    [System.ComponentModel.TypeConverter(typeof(PatchResourceRequestInputTypeConverter))]
    public partial class PatchResourceRequestInput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.PatchResourceRequestInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PatchResourceRequestInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.PatchResourceRequestInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PatchResourceRequestInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PatchResourceRequestInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PatchResourceRequestInput" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.PatchResourceRequestInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PatchResourceRequestInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppIdentityDetails) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.DppIdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchBackupVaultInput) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.PatchBackupVaultInputTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.PatchResourceRequestInputTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).MonitoringSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IMonitoringSettings) content.GetValueForProperty("MonitoringSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).MonitoringSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.MonitoringSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringSettingAzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).MonitoringSettingAzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IAzureMonitorAlertSettings) content.GetValueForProperty("MonitoringSettingAzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).MonitoringSettingAzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureMonitorAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).AzureMonitorAlertsForAllJobFailure = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState?) content.GetValueForProperty("AzureMonitorAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).AzureMonitorAlertsForAllJobFailure, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.PatchResourceRequestInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PatchResourceRequestInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppIdentityDetails) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.DppIdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchBackupVaultInput) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.PatchBackupVaultInputTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.PatchResourceRequestInputTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).MonitoringSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IMonitoringSettings) content.GetValueForProperty("MonitoringSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).MonitoringSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.MonitoringSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringSettingAzureMonitorAlertSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).MonitoringSettingAzureMonitorAlertSetting = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IAzureMonitorAlertSettings) content.GetValueForProperty("MonitoringSettingAzureMonitorAlertSetting",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).MonitoringSettingAzureMonitorAlertSetting, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.AzureMonitorAlertSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureMonitorAlertsForAllJobFailure"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).AzureMonitorAlertsForAllJobFailure = (Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState?) content.GetValueForProperty("AzureMonitorAlertsForAllJobFailure",((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IPatchResourceRequestInputInternal)this).AzureMonitorAlertsForAllJobFailure, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Patch Request content for Microsoft.DataProtection resources
    [System.ComponentModel.TypeConverter(typeof(PatchResourceRequestInputTypeConverter))]
    public partial interface IPatchResourceRequestInput

    {

    }
}