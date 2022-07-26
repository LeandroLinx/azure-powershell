// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PowerShell;

    /// <summary>Friendly Rules name mapping to the any Rules or secret related information.</summary>
    [System.ComponentModel.TypeConverter(typeof(RuleTypeConverter))]
    public partial class Rule
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.Rule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRule" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRule DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Rule(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.Rule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRule" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRule DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Rule(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Rule" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Rule" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRule FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.Rule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Rule(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.RulePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).DeploymentStatus = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus?) content.GetValueForProperty("DeploymentStatus",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).DeploymentStatus, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus.CreateFrom);
            }
            if (content.Contains("SetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).SetName = (string) content.GetValueForProperty("SetName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).SetName, global::System.Convert.ToString);
            }
            if (content.Contains("Order"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Order = (int?) content.GetValueForProperty("Order",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Order, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Condition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Condition = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleCondition[]) content.GetValueForProperty("Condition",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Condition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleCondition>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleConditionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Action = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1[]) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Action, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleAction1TypeConverter.ConvertFrom));
            }
            if (content.Contains("MatchProcessingBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).MatchProcessingBehavior = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior?) content.GetValueForProperty("MatchProcessingBehavior",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).MatchProcessingBehavior, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.Rule"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Rule(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.RulePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.IdentityType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).DeploymentStatus = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus?) content.GetValueForProperty("DeploymentStatus",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).DeploymentStatus, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeploymentStatus.CreateFrom);
            }
            if (content.Contains("SetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).SetName = (string) content.GetValueForProperty("SetName",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).SetName, global::System.Convert.ToString);
            }
            if (content.Contains("Order"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Order = (int?) content.GetValueForProperty("Order",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Order, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Condition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Condition = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleCondition[]) content.GetValueForProperty("Condition",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Condition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleCondition>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleConditionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Action = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1[]) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).Action, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IDeliveryRuleAction1>(__y, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleAction1TypeConverter.ConvertFrom));
            }
            if (content.Contains("MatchProcessingBehavior"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).MatchProcessingBehavior = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior?) content.GetValueForProperty("MatchProcessingBehavior",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).MatchProcessingBehavior, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.MatchProcessingBehavior.CreateFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IRuleInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.AfdProvisioningState.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Friendly Rules name mapping to the any Rules or secret related information.
    [System.ComponentModel.TypeConverter(typeof(RuleTypeConverter))]
    public partial interface IRule

    {

    }
}