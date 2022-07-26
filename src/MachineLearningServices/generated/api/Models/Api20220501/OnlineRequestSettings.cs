// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Online deployment scoring requests configuration.</summary>
    public partial class OnlineRequestSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IOnlineRequestSettings,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IOnlineRequestSettingsInternal
    {

        /// <summary>Backing field for <see cref="MaxConcurrentRequestsPerInstance" /> property.</summary>
        private int? _maxConcurrentRequestsPerInstance;

        /// <summary>
        /// The number of maximum concurrent requests per node allowed per deployment. Defaults to 1.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? MaxConcurrentRequestsPerInstance { get => this._maxConcurrentRequestsPerInstance; set => this._maxConcurrentRequestsPerInstance = value; }

        /// <summary>Backing field for <see cref="MaxQueueWait" /> property.</summary>
        private global::System.TimeSpan? _maxQueueWait;

        /// <summary>
        /// The maximum amount of time a request will stay in the queue in ISO 8601 format.
        /// Defaults to 500ms.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public global::System.TimeSpan? MaxQueueWait { get => this._maxQueueWait; set => this._maxQueueWait = value; }

        /// <summary>Backing field for <see cref="RequestTimeout" /> property.</summary>
        private global::System.TimeSpan? _requestTimeout;

        /// <summary>
        /// The scoring timeout in ISO 8601 format.
        /// Defaults to 5000ms.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public global::System.TimeSpan? RequestTimeout { get => this._requestTimeout; set => this._requestTimeout = value; }

        /// <summary>Creates an new <see cref="OnlineRequestSettings" /> instance.</summary>
        public OnlineRequestSettings()
        {

        }
    }
    /// Online deployment scoring requests configuration.
    public partial interface IOnlineRequestSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The number of maximum concurrent requests per node allowed per deployment. Defaults to 1.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of maximum concurrent requests per node allowed per deployment. Defaults to 1.",
        SerializedName = @"maxConcurrentRequestsPerInstance",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxConcurrentRequestsPerInstance { get; set; }
        /// <summary>
        /// The maximum amount of time a request will stay in the queue in ISO 8601 format.
        /// Defaults to 500ms.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum amount of time a request will stay in the queue in ISO 8601 format.
        Defaults to 500ms.",
        SerializedName = @"maxQueueWait",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? MaxQueueWait { get; set; }
        /// <summary>
        /// The scoring timeout in ISO 8601 format.
        /// Defaults to 5000ms.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scoring timeout in ISO 8601 format.
        Defaults to 5000ms.",
        SerializedName = @"requestTimeout",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? RequestTimeout { get; set; }

    }
    /// Online deployment scoring requests configuration.
    internal partial interface IOnlineRequestSettingsInternal

    {
        /// <summary>
        /// The number of maximum concurrent requests per node allowed per deployment. Defaults to 1.
        /// </summary>
        int? MaxConcurrentRequestsPerInstance { get; set; }
        /// <summary>
        /// The maximum amount of time a request will stay in the queue in ISO 8601 format.
        /// Defaults to 500ms.
        /// </summary>
        global::System.TimeSpan? MaxQueueWait { get; set; }
        /// <summary>
        /// The scoring timeout in ISO 8601 format.
        /// Defaults to 5000ms.
        /// </summary>
        global::System.TimeSpan? RequestTimeout { get; set; }

    }
}