// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>AKS properties</summary>
    [System.ComponentModel.TypeConverter(typeof(AksSchemaPropertiesTypeConverter))]
    public partial class AksSchemaProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.AksSchemaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AksSchemaProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SslConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISslConfiguration) content.GetValueForProperty("SslConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfiguration, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SslConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AksNetworkingConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AksNetworkingConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksNetworkingConfiguration) content.GetValueForProperty("AksNetworkingConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AksNetworkingConfiguration, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.AksNetworkingConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ClusterFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).ClusterFqdn = (string) content.GetValueForProperty("ClusterFqdn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).ClusterFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("SystemService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SystemService = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISystemService[]) content.GetValueForProperty("SystemService",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SystemService, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISystemService>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SystemServiceTypeConverter.ConvertFrom));
            }
            if (content.Contains("AgentCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AgentCount = (int?) content.GetValueForProperty("AgentCount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AgentCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AgentVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AgentVMSize = (string) content.GetValueForProperty("AgentVMSize",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AgentVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterPurpose"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).ClusterPurpose = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ClusterPurpose?) content.GetValueForProperty("ClusterPurpose",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).ClusterPurpose, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ClusterPurpose.CreateFrom);
            }
            if (content.Contains("LoadBalancerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).LoadBalancerType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LoadBalancerType?) content.GetValueForProperty("LoadBalancerType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).LoadBalancerType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LoadBalancerType.CreateFrom);
            }
            if (content.Contains("LoadBalancerSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).LoadBalancerSubnet = (string) content.GetValueForProperty("LoadBalancerSubnet",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).LoadBalancerSubnet, global::System.Convert.ToString);
            }
            if (content.Contains("SslConfigurationCert"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationCert = (string) content.GetValueForProperty("SslConfigurationCert",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationCert, global::System.Convert.ToString);
            }
            if (content.Contains("SslConfigurationKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationKey = (string) content.GetValueForProperty("SslConfigurationKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationKey, global::System.Convert.ToString);
            }
            if (content.Contains("SslConfigurationCname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationCname = (string) content.GetValueForProperty("SslConfigurationCname",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationCname, global::System.Convert.ToString);
            }
            if (content.Contains("AkNetworkingConfigurationSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationSubnetId = (string) content.GetValueForProperty("AkNetworkingConfigurationSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("AkNetworkingConfigurationServiceCidr"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationServiceCidr = (string) content.GetValueForProperty("AkNetworkingConfigurationServiceCidr",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationServiceCidr, global::System.Convert.ToString);
            }
            if (content.Contains("SslConfigurationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationStatus = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus?) content.GetValueForProperty("SslConfigurationStatus",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationStatus, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus.CreateFrom);
            }
            if (content.Contains("SslConfigurationLeafDomainLabel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationLeafDomainLabel = (string) content.GetValueForProperty("SslConfigurationLeafDomainLabel",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationLeafDomainLabel, global::System.Convert.ToString);
            }
            if (content.Contains("SslConfigurationOverwriteExistingDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationOverwriteExistingDomain = (bool?) content.GetValueForProperty("SslConfigurationOverwriteExistingDomain",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationOverwriteExistingDomain, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AkNetworkingConfigurationDnsServiceIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationDnsServiceIP = (string) content.GetValueForProperty("AkNetworkingConfigurationDnsServiceIP",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationDnsServiceIP, global::System.Convert.ToString);
            }
            if (content.Contains("AkNetworkingConfigurationDockerBridgeCidr"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationDockerBridgeCidr = (string) content.GetValueForProperty("AkNetworkingConfigurationDockerBridgeCidr",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationDockerBridgeCidr, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.AksSchemaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AksSchemaProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SslConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISslConfiguration) content.GetValueForProperty("SslConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfiguration, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SslConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AksNetworkingConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AksNetworkingConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksNetworkingConfiguration) content.GetValueForProperty("AksNetworkingConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AksNetworkingConfiguration, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.AksNetworkingConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ClusterFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).ClusterFqdn = (string) content.GetValueForProperty("ClusterFqdn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).ClusterFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("SystemService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SystemService = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISystemService[]) content.GetValueForProperty("SystemService",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SystemService, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISystemService>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SystemServiceTypeConverter.ConvertFrom));
            }
            if (content.Contains("AgentCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AgentCount = (int?) content.GetValueForProperty("AgentCount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AgentCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AgentVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AgentVMSize = (string) content.GetValueForProperty("AgentVMSize",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AgentVMSize, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterPurpose"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).ClusterPurpose = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ClusterPurpose?) content.GetValueForProperty("ClusterPurpose",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).ClusterPurpose, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ClusterPurpose.CreateFrom);
            }
            if (content.Contains("LoadBalancerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).LoadBalancerType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LoadBalancerType?) content.GetValueForProperty("LoadBalancerType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).LoadBalancerType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LoadBalancerType.CreateFrom);
            }
            if (content.Contains("LoadBalancerSubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).LoadBalancerSubnet = (string) content.GetValueForProperty("LoadBalancerSubnet",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).LoadBalancerSubnet, global::System.Convert.ToString);
            }
            if (content.Contains("SslConfigurationCert"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationCert = (string) content.GetValueForProperty("SslConfigurationCert",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationCert, global::System.Convert.ToString);
            }
            if (content.Contains("SslConfigurationKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationKey = (string) content.GetValueForProperty("SslConfigurationKey",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationKey, global::System.Convert.ToString);
            }
            if (content.Contains("SslConfigurationCname"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationCname = (string) content.GetValueForProperty("SslConfigurationCname",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationCname, global::System.Convert.ToString);
            }
            if (content.Contains("AkNetworkingConfigurationSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationSubnetId = (string) content.GetValueForProperty("AkNetworkingConfigurationSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("AkNetworkingConfigurationServiceCidr"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationServiceCidr = (string) content.GetValueForProperty("AkNetworkingConfigurationServiceCidr",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationServiceCidr, global::System.Convert.ToString);
            }
            if (content.Contains("SslConfigurationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationStatus = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus?) content.GetValueForProperty("SslConfigurationStatus",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationStatus, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.SslConfigStatus.CreateFrom);
            }
            if (content.Contains("SslConfigurationLeafDomainLabel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationLeafDomainLabel = (string) content.GetValueForProperty("SslConfigurationLeafDomainLabel",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationLeafDomainLabel, global::System.Convert.ToString);
            }
            if (content.Contains("SslConfigurationOverwriteExistingDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationOverwriteExistingDomain = (bool?) content.GetValueForProperty("SslConfigurationOverwriteExistingDomain",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).SslConfigurationOverwriteExistingDomain, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AkNetworkingConfigurationDnsServiceIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationDnsServiceIP = (string) content.GetValueForProperty("AkNetworkingConfigurationDnsServiceIP",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationDnsServiceIP, global::System.Convert.ToString);
            }
            if (content.Contains("AkNetworkingConfigurationDockerBridgeCidr"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationDockerBridgeCidr = (string) content.GetValueForProperty("AkNetworkingConfigurationDockerBridgeCidr",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaPropertiesInternal)this).AkNetworkingConfigurationDockerBridgeCidr, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.AksSchemaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AksSchemaProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.AksSchemaProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AksSchemaProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AksSchemaProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AksSchemaProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAksSchemaProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// AKS properties
    [System.ComponentModel.TypeConverter(typeof(AksSchemaPropertiesTypeConverter))]
    public partial interface IAksSchemaProperties

    {

    }
}