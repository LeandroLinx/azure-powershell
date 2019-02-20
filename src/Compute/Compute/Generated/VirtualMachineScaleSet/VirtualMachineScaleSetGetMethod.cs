//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Get, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Vmss", DefaultParameterSetName = "DefaultParameter")]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class GetAzureRmVmss : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                string resourceGroupName = this.ResourceGroupName;
                string vmScaleSetName = this.VMScaleSetName;

                if (!string.IsNullOrEmpty(resourceGroupName) && !string.IsNullOrEmpty(vmScaleSetName))
                {
                    if (this.ParameterSetName.Equals("FriendMethod"))
                    {
                        var result = VirtualMachineScaleSetsClient.GetInstanceView(resourceGroupName, vmScaleSetName);
                        var psObject = new PSVirtualMachineScaleSetInstanceView();
                        ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSetInstanceView, PSVirtualMachineScaleSetInstanceView>(result, psObject);
                        WriteObject(psObject);
                    }
                    else if (this.ParameterSetName.Equals("OSUpgradeHistoryMethodParameter"))
                    {
                        var result = VirtualMachineScaleSetsClient.GetOSUpgradeHistory(resourceGroupName, vmScaleSetName);
                        var resultList = result.ToList();
                        var nextPageLink = result.NextPageLink;
                        while (!string.IsNullOrEmpty(nextPageLink))
                        {
                            var pageResult = VirtualMachineScaleSetsClient.GetOSUpgradeHistoryNext(nextPageLink);
                            foreach (var pageItem in pageResult)
                            {
                                resultList.Add(pageItem);
                            }
                            nextPageLink = pageResult.NextPageLink;
                        }
                        var psObject = new List<PSUpgradeOperationHistoricalStatusInfo>();
                        foreach (var r in resultList)
                        {
                            psObject.Add(ComputeAutomationAutoMapperProfile.Mapper.Map<UpgradeOperationHistoricalStatusInfo, PSUpgradeOperationHistoricalStatusInfo>(r));
                        }
                        WriteObject(psObject, true);
                    }
                    else
                    {
                        var result = VirtualMachineScaleSetsClient.Get(resourceGroupName, vmScaleSetName);
                        var psObject = new PSVirtualMachineScaleSet();
                        ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSet, PSVirtualMachineScaleSet>(result, psObject);
                        WriteObject(psObject);
                    }
                }
                else if (!string.IsNullOrEmpty(resourceGroupName))
                {
                    var result = VirtualMachineScaleSetsClient.List(resourceGroupName);
                    var resultList = result.ToList();
                    var nextPageLink = result.NextPageLink;
                    while (!string.IsNullOrEmpty(nextPageLink))
                    {
                        var pageResult = VirtualMachineScaleSetsClient.ListNext(nextPageLink);
                        foreach (var pageItem in pageResult)
                        {
                            resultList.Add(pageItem);
                        }
                        nextPageLink = pageResult.NextPageLink;
                    }
                    var psObject = new List<PSVirtualMachineScaleSetList>();
                    foreach (var r in resultList)
                    {
                        psObject.Add(ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSet, PSVirtualMachineScaleSetList>(r));
                    }
                    WriteObject(psObject, true);
                }
                else
                {
                    var result = VirtualMachineScaleSetsClient.ListAll();
                    var resultList = result.ToList();
                    var nextPageLink = result.NextPageLink;
                    while (!string.IsNullOrEmpty(nextPageLink))
                    {
                        var pageResult = VirtualMachineScaleSetsClient.ListAllNext(nextPageLink);
                        foreach (var pageItem in pageResult)
                        {
                            resultList.Add(pageItem);
                        }
                        nextPageLink = pageResult.NextPageLink;
                    }
                    var psObject = new List<PSVirtualMachineScaleSetList>();
                    foreach (var r in resultList)
                    {
                        psObject.Add(ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSet, PSVirtualMachineScaleSetList>(r));
                    }
                    WriteObject(psObject, true);
                }
            });
        }

        [Parameter(
            Position = 0,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        [ResourceNameCompleter("Microsoft.Compute/virtualMachineScaleSets", "ResourceGroupName")]
        [Alias("Name")]
        public string VMScaleSetName { get; set; }

        [Parameter(
            ParameterSetName = "FriendMethod",
            Mandatory = true)]
        public SwitchParameter InstanceView { get; set; }

        [Parameter(
            ParameterSetName = "OSUpgradeHistoryMethodParameter",
            Mandatory = true)]
        public SwitchParameter OSUpgradeHistory { get; set; }
    }
}
