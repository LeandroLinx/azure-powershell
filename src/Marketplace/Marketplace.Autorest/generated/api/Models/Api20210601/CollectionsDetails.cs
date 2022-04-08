// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>Collection name and id.</summary>
    public partial class CollectionsDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.ICollectionsDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.ICollectionsDetailsInternal
    {

        /// <summary>Backing field for <see cref="CollectionId" /> property.</summary>
        private string _collectionId;

        /// <summary>Collection id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string CollectionId { get => this._collectionId; set => this._collectionId = value; }

        /// <summary>Backing field for <see cref="CollectionName" /> property.</summary>
        private string _collectionName;

        /// <summary>Collection name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string CollectionName { get => this._collectionName; set => this._collectionName = value; }

        /// <summary>Creates an new <see cref="CollectionsDetails" /> instance.</summary>
        public CollectionsDetails()
        {

        }
    }
    /// Collection name and id.
    public partial interface ICollectionsDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Collection id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection id.",
        SerializedName = @"collectionId",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionId { get; set; }
        /// <summary>Collection name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Collection name.",
        SerializedName = @"collectionName",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionName { get; set; }

    }
    /// Collection name and id.
    internal partial interface ICollectionsDetailsInternal

    {
        /// <summary>Collection id.</summary>
        string CollectionId { get; set; }
        /// <summary>Collection name.</summary>
        string CollectionName { get; set; }

    }
}