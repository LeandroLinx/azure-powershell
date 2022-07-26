// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>
    /// Defines the parameters for using CDN managed certificate for securing custom domain.
    /// </summary>
    public partial class CdnCertificateSourceParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICdnCertificateSourceParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICdnCertificateSourceParametersInternal
    {

        /// <summary>Backing field for <see cref="CertificateType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateType _certificateType;

        /// <summary>Type of certificate used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateType CertificateType { get => this._certificateType; set => this._certificateType = value; }

        /// <summary>Internal Acessors for TypeName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICdnCertificateSourceParametersInternal.TypeName { get => this._typeName; set { {_typeName = value;} } }

        /// <summary>Backing field for <see cref="TypeName" /> property.</summary>
        private string _typeName= @"CdnCertificateSourceParameters";

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string TypeName { get => this._typeName; }

        /// <summary>Creates an new <see cref="CdnCertificateSourceParameters" /> instance.</summary>
        public CdnCertificateSourceParameters()
        {

        }
    }
    /// Defines the parameters for using CDN managed certificate for securing custom domain.
    public partial interface ICdnCertificateSourceParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>Type of certificate used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Type of certificate used",
        SerializedName = @"certificateType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateType CertificateType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        string TypeName { get;  }

    }
    /// Defines the parameters for using CDN managed certificate for securing custom domain.
    internal partial interface ICdnCertificateSourceParametersInternal

    {
        /// <summary>Type of certificate used</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CertificateType CertificateType { get; set; }

        string TypeName { get; set; }

    }
}