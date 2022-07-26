// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>
    /// Azure FirstParty Managed Certificate provided by other first party resource providers to enable HTTPS.
    /// </summary>
    public partial class AzureFirstPartyManagedCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAzureFirstPartyManagedCertificate,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IAzureFirstPartyManagedCertificateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificate"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificate __certificate = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.Certificate();

        /// <summary>Certificate expiration date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string ExpirationDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal)__certificate).ExpirationDate; }

        /// <summary>Internal Acessors for ExpirationDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal.ExpirationDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal)__certificate).ExpirationDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal)__certificate).ExpirationDate = value; }

        /// <summary>Internal Acessors for Subject</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal.Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal)__certificate).Subject; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal)__certificate).Subject = value; }

        /// <summary>Subject name in the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal)__certificate).Subject; }

        /// <summary>The type of the secret resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType? Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal)__certificate).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal)__certificate).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SecretType)""); }

        /// <summary>Creates an new <see cref="AzureFirstPartyManagedCertificate" /> instance.</summary>
        public AzureFirstPartyManagedCertificate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__certificate), __certificate);
            await eventListener.AssertObjectIsValid(nameof(__certificate), __certificate);
        }
    }
    /// Azure FirstParty Managed Certificate provided by other first party resource providers to enable HTTPS.
    public partial interface IAzureFirstPartyManagedCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificate
    {

    }
    /// Azure FirstParty Managed Certificate provided by other first party resource providers to enable HTTPS.
    internal partial interface IAzureFirstPartyManagedCertificateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICertificateInternal
    {

    }
}