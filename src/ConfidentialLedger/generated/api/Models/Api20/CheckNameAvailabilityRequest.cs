// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Extensions;

    /// <summary>The check availability request body.</summary>
    public partial class CheckNameAvailabilityRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20.ICheckNameAvailabilityRequest,
        Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Models.Api20.ICheckNameAvailabilityRequestInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the resource for which availability needs to be checked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailabilityRequest" /> instance.</summary>
        public CheckNameAvailabilityRequest()
        {

        }
    }
    /// The check availability request body.
    public partial interface ICheckNameAvailabilityRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.IJsonSerializable
    {
        /// <summary>The name of the resource for which availability needs to be checked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource for which availability needs to be checked.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConfidentialLedger.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// The check availability request body.
    internal partial interface ICheckNameAvailabilityRequestInternal

    {
        /// <summary>The name of the resource for which availability needs to be checked.</summary>
        string Name { get; set; }
        /// <summary>The resource type.</summary>
        string Type { get; set; }

    }
}