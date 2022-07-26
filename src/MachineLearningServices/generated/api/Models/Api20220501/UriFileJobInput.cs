// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class UriFileJobInput :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IUriFileJobInput,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IUriFileJobInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetJobInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetJobInput __assetJobInput = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.AssetJobInput();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobInput __jobInput = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.JobInput();

        /// <summary>Description for the input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobInputInternal)__jobInput).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobInputInternal)__jobInput).Description = value ?? null; }

        /// <summary>Input Asset Delivery Mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.InputDeliveryMode? Mode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetJobInputInternal)__assetJobInput).Mode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetJobInputInternal)__assetJobInput).Mode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.InputDeliveryMode)""); }

        /// <summary>[Required] Specifies the type of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobInputInternal)__jobInput).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobInputInternal)__jobInput).Type = value ; }

        /// <summary>[Required] Input Asset URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetJobInputInternal)__assetJobInput).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetJobInputInternal)__assetJobInput).Uri = value ; }

        /// <summary>Creates an new <see cref="UriFileJobInput" /> instance.</summary>
        public UriFileJobInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__assetJobInput), __assetJobInput);
            await eventListener.AssertObjectIsValid(nameof(__assetJobInput), __assetJobInput);
            await eventListener.AssertNotNull(nameof(__jobInput), __jobInput);
            await eventListener.AssertObjectIsValid(nameof(__jobInput), __jobInput);
        }
    }
    public partial interface IUriFileJobInput :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetJobInput,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobInput
    {

    }
    internal partial interface IUriFileJobInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IAssetJobInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobInputInternal
    {

    }
}