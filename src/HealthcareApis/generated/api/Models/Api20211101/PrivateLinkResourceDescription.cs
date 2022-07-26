// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>The Private Endpoint Connection resource.</summary>
    public partial class PrivateLinkResourceDescription :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IPrivateLinkResourceDescription,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IPrivateLinkResourceDescriptionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResource __privateLinkResource = new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.PrivateLinkResource();

        /// <summary>The private link resource group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal)__privateLinkResource).GroupId; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal)__privateLinkResource).Id; }

        /// <summary>Internal Acessors for GroupId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal.GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal)__privateLinkResource).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal)__privateLinkResource).GroupId = value; }

        /// <summary>Internal Acessors for RequiredMember</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal.RequiredMember { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal)__privateLinkResource).RequiredMember; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal)__privateLinkResource).RequiredMember = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal)__privateLinkResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal)__privateLinkResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal)__privateLinkResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal)__privateLinkResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal)__privateLinkResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal)__privateLinkResource).Type = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemData Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IPrivateLinkResourceDescriptionInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal)__privateLinkResource).Name; }

        /// <summary>Resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceProperties Property { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal)__privateLinkResource).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal)__privateLinkResource).Property = value ?? null /* model class */; }

        /// <summary>The private link resource required member names.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string[] RequiredMember { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal)__privateLinkResource).RequiredMember; }

        /// <summary>The private link resource Private link DNS zone name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string[] RequiredZoneName { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal)__privateLinkResource).RequiredZoneName; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal)__privateLinkResource).RequiredZoneName = value ?? null /* arrayOf */; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inlined)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inlined)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inlined)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IResourceInternal)__privateLinkResource).Type; }

        /// <summary>Creates an new <see cref="PrivateLinkResourceDescription" /> instance.</summary>
        public PrivateLinkResourceDescription()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__privateLinkResource), __privateLinkResource);
            await eventListener.AssertObjectIsValid(nameof(__privateLinkResource), __privateLinkResource);
        }
    }
    /// The Private Endpoint Connection resource.
    public partial interface IPrivateLinkResourceDescription :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResource
    {
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
    /// The Private Endpoint Connection resource.
    internal partial interface IPrivateLinkResourceDescriptionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.IPrivateLinkResourceInternal
    {
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api10.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
}