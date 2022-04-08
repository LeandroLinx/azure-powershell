// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(AmazonS3DataSourceTypeConverter))]
    public partial class AmazonS3DataSource
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3DataSource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AmazonS3DataSource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3Properties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3PropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourceInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DataSourceType) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourceInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DataSourceType.CreateFrom);
            }
            if (content.Contains("Scan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourceInternal)this).Scan = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScan[]) content.GetValueForProperty("Scan",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourceInternal)this).Scan, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScan>(__y, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ScanTypeConverter.ConvertFrom));
            }
            if (content.Contains("CollectionReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionReferenceName = (string) content.GetValueForProperty("CollectionReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("Collection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).Collection = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICollectionReference) content.GetValueForProperty("Collection",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).Collection, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.CollectionReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ServiceUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).ServiceUrl = (string) content.GetValueForProperty("ServiceUrl",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).ServiceUrl, global::System.Convert.ToString);
            }
            if (content.Contains("RoleArn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).RoleArn = (string) content.GetValueForProperty("RoleArn",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).RoleArn, global::System.Convert.ToString);
            }
            if (content.Contains("CollectionLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("CollectionLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CollectionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionType = (string) content.GetValueForProperty("CollectionType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3DataSource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AmazonS3DataSource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3Properties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3PropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IProxyResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourceInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DataSourceType) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourceInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DataSourceType.CreateFrom);
            }
            if (content.Contains("Scan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourceInternal)this).Scan = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScan[]) content.GetValueForProperty("Scan",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IDataSourceInternal)this).Scan, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IScan>(__y, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ScanTypeConverter.ConvertFrom));
            }
            if (content.Contains("CollectionReferenceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionReferenceName = (string) content.GetValueForProperty("CollectionReferenceName",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionReferenceName, global::System.Convert.ToString);
            }
            if (content.Contains("Collection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).Collection = (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.ICollectionReference) content.GetValueForProperty("Collection",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).Collection, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.CollectionReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).LastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("LastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).LastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ServiceUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).ServiceUrl = (string) content.GetValueForProperty("ServiceUrl",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).ServiceUrl, global::System.Convert.ToString);
            }
            if (content.Contains("RoleArn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).RoleArn = (string) content.GetValueForProperty("RoleArn",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).RoleArn, global::System.Convert.ToString);
            }
            if (content.Contains("CollectionLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("CollectionLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CollectionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionType = (string) content.GetValueForProperty("CollectionType",((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSourceInternal)this).CollectionType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3DataSource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AmazonS3DataSource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3DataSource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AmazonS3DataSource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AmazonS3DataSource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.IAmazonS3DataSource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    [System.ComponentModel.TypeConverter(typeof(AmazonS3DataSourceTypeConverter))]
    public partial interface IAmazonS3DataSource

    {

    }
}