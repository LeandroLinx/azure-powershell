// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>The configuration settings of the Azure Active Directory app registration.</summary>
    public partial class AzureActiveDirectoryRegistration :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryRegistration,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IAzureActiveDirectoryRegistrationInternal
    {

        /// <summary>Backing field for <see cref="ClientId" /> property.</summary>
        private string _clientId;

        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string ClientId { get => this._clientId; set => this._clientId = value; }

        /// <summary>Backing field for <see cref="ClientSecretCertificateIssuer" /> property.</summary>
        private string _clientSecretCertificateIssuer;

        /// <summary>
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string ClientSecretCertificateIssuer { get => this._clientSecretCertificateIssuer; set => this._clientSecretCertificateIssuer = value; }

        /// <summary>
        /// Backing field for <see cref="ClientSecretCertificateSubjectAlternativeName" /> property.
        /// </summary>
        private string _clientSecretCertificateSubjectAlternativeName;

        /// <summary>
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing
        /// purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string ClientSecretCertificateSubjectAlternativeName { get => this._clientSecretCertificateSubjectAlternativeName; set => this._clientSecretCertificateSubjectAlternativeName = value; }

        /// <summary>Backing field for <see cref="ClientSecretCertificateThumbprint" /> property.</summary>
        private string _clientSecretCertificateThumbprint;

        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string ClientSecretCertificateThumbprint { get => this._clientSecretCertificateThumbprint; set => this._clientSecretCertificateThumbprint = value; }

        /// <summary>Backing field for <see cref="ClientSecretSettingName" /> property.</summary>
        private string _clientSecretSettingName;

        /// <summary>
        /// The app setting name that contains the client secret of the relying party application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string ClientSecretSettingName { get => this._clientSecretSettingName; set => this._clientSecretSettingName = value; }

        /// <summary>Backing field for <see cref="OpenIdIssuer" /> property.</summary>
        private string _openIdIssuer;

        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string OpenIdIssuer { get => this._openIdIssuer; set => this._openIdIssuer = value; }

        /// <summary>Creates an new <see cref="AzureActiveDirectoryRegistration" /> instance.</summary>
        public AzureActiveDirectoryRegistration()
        {

        }
    }
    /// The configuration settings of the Azure Active Directory app registration.
    public partial interface IAzureActiveDirectoryRegistration :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Client ID of this relying party application, known as the client_id.
        This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        other 3rd party OpenID Connect providers.
        More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property acts as
        a replacement for the Client Secret Certificate Thumbprint. It is also optional.",
        SerializedName = @"clientSecretCertificateIssuer",
        PossibleTypes = new [] { typeof(string) })]
        string ClientSecretCertificateIssuer { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing
        /// purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing purposes. This property acts as
        a replacement for the Client Secret Certificate Thumbprint. It is also optional.",
        SerializedName = @"clientSecretCertificateSubjectAlternativeName",
        PossibleTypes = new [] { typeof(string) })]
        string ClientSecretCertificateSubjectAlternativeName { get; set; }
        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        a replacement for the Client Secret. It is also optional.",
        SerializedName = @"clientSecretCertificateThumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string ClientSecretCertificateThumbprint { get; set; }
        /// <summary>
        /// The app setting name that contains the client secret of the relying party application.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The app setting name that contains the client secret of the relying party application.",
        SerializedName = @"clientSecretSettingName",
        PossibleTypes = new [] { typeof(string) })]
        string ClientSecretSettingName { get; set; }
        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        This URI is a case-sensitive identifier for the token issuer.
        More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html",
        SerializedName = @"openIdIssuer",
        PossibleTypes = new [] { typeof(string) })]
        string OpenIdIssuer { get; set; }

    }
    /// The configuration settings of the Azure Active Directory app registration.
    internal partial interface IAzureActiveDirectoryRegistrationInternal

    {
        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        /// This setting is required for enabling OpenID Connection authentication with Azure Active Directory or
        /// other 3rd party OpenID Connect providers.
        /// More information on OpenID Connect: http://openid.net/specs/openid-connect-core-1_0.html
        /// </summary>
        string ClientId { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        string ClientSecretCertificateIssuer { get; set; }
        /// <summary>
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing
        /// purposes. This property acts as
        /// a replacement for the Client Secret Certificate Thumbprint. It is also optional.
        /// </summary>
        string ClientSecretCertificateSubjectAlternativeName { get; set; }
        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property
        /// acts as
        /// a replacement for the Client Secret. It is also optional.
        /// </summary>
        string ClientSecretCertificateThumbprint { get; set; }
        /// <summary>
        /// The app setting name that contains the client secret of the relying party application.
        /// </summary>
        string ClientSecretSettingName { get; set; }
        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        /// When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://login.microsoftonline.com/v2.0/{tenant-guid}/.
        /// This URI is a case-sensitive identifier for the token issuer.
        /// More information on OpenID Connect Discovery: http://openid.net/specs/openid-connect-discovery-1_0.html
        /// </summary>
        string OpenIdIssuer { get; set; }

    }
}