// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>Request approvals details</summary>
    public partial class RequestApprovalsDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IRequestApprovalsDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IRequestApprovalsDetailsInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Gets offer display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Icon" /> property.</summary>
        private string _icon;

        /// <summary>Gets or sets the icon url</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string Icon { get => this._icon; set => this._icon = value; }

        /// <summary>Backing field for <see cref="MessageCode" /> property.</summary>
        private long? _messageCode;

        /// <summary>Gets or sets the notification message id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public long? MessageCode { get => this._messageCode; set => this._messageCode = value; }

        /// <summary>Backing field for <see cref="OfferId" /> property.</summary>
        private string _offerId;

        /// <summary>Gets offer id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string OfferId { get => this._offerId; set => this._offerId = value; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanNotificationDetails[] _plan;

        /// <summary>Gets or sets removed plans notifications</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanNotificationDetails[] Plan { get => this._plan; set => this._plan = value; }

        /// <summary>Backing field for <see cref="PublisherId" /> property.</summary>
        private string _publisherId;

        /// <summary>Gets or sets publisher id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string PublisherId { get => this._publisherId; set => this._publisherId = value; }

        /// <summary>Creates an new <see cref="RequestApprovalsDetails" /> instance.</summary>
        public RequestApprovalsDetails()
        {

        }
    }
    /// Request approvals details
    public partial interface IRequestApprovalsDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Gets offer display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets offer display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Gets or sets the icon url</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the icon url",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string Icon { get; set; }
        /// <summary>Gets or sets the notification message id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the notification message id",
        SerializedName = @"messageCode",
        PossibleTypes = new [] { typeof(long) })]
        long? MessageCode { get; set; }
        /// <summary>Gets offer id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets offer id",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferId { get; set; }
        /// <summary>Gets or sets removed plans notifications</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets removed plans notifications",
        SerializedName = @"plans",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanNotificationDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanNotificationDetails[] Plan { get; set; }
        /// <summary>Gets or sets publisher id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets publisher id",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherId { get; set; }

    }
    /// Request approvals details
    internal partial interface IRequestApprovalsDetailsInternal

    {
        /// <summary>Gets offer display name</summary>
        string DisplayName { get; set; }
        /// <summary>Gets or sets the icon url</summary>
        string Icon { get; set; }
        /// <summary>Gets or sets the notification message id</summary>
        long? MessageCode { get; set; }
        /// <summary>Gets offer id</summary>
        string OfferId { get; set; }
        /// <summary>Gets or sets removed plans notifications</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanNotificationDetails[] Plan { get; set; }
        /// <summary>Gets or sets publisher id</summary>
        string PublisherId { get; set; }

    }
}