#
# Module manifest for module 'Az.MachineLearningServices'
#
# Generated by: Microsoft Corporation
#
# Generated on: 6/24/2022
#

@{

# Script module or binary module file associated with this manifest.
RootModule = './Az.MachineLearningServices.psm1'

# Version number of this module.
ModuleVersion = '0.1.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '56293047-9014-4c88-96b7-98b69c3b687d'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell: MachineLearningServices cmdlets'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.8.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = './bin/Az.MachineLearningServices.private.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = './Az.MachineLearningServices.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Get-AzMLServiceQuota', 'Get-AzMLServiceUsage', 
               'Get-AzMLServiceVMSize', 'Get-AzMLWorkspace', 
               'Get-AzMLWorkspaceBatchDeployment', 
               'Get-AzMLWorkspaceBatchEndpoint', 'Get-AzMLWorkspaceCodeVersion', 
               'Get-AzMLWorkspaceComponentContainer', 
               'Get-AzMLWorkspaceComponentVersion', 'Get-AzMLWorkspaceCompute', 
               'Get-AzMLWorkspaceComputeKey', 'Get-AzMLWorkspaceComputeNode', 
               'Get-AzMLWorkspaceConnection', 'Get-AzMLWorkspaceDataContainer', 
               'Get-AzMLWorkspaceDatastore', 'Get-AzMLWorkspaceDatastoreSecret', 
               'Get-AzMLWorkspaceDataVersion', 
               'Get-AzMLWorkspaceEnvironmentContainer', 
               'Get-AzMLWorkspaceEnvironmentVersion', 'Get-AzMLWorkspaceFeature', 
               'Get-AzMLWorkspaceJob', 'Get-AzMLWorkspaceKey', 
               'Get-AzMLWorkspaceModelContainer', 'Get-AzMLWorkspaceModelVersion', 
               'Get-AzMLWorkspaceNotebookAccessToken', 
               'Get-AzMLWorkspaceNotebookKey', 'Get-AzMLWorkspaceOnlineDeployment', 
               'Get-AzMLWorkspaceOnlineDeploymentLog', 
               'Get-AzMLWorkspaceOnlineDeploymentSku', 
               'Get-AzMLWorkspaceOnlineEndpoint', 
               'Get-AzMLWorkspaceOnlineEndpointKey', 
               'Get-AzMLWorkspaceOnlineEndpointToken', 
               'Get-AzMLWorkspaceOutboundNetworkDependencyEndpoint', 
               'Get-AzMLWorkspaceStorageAccountKey', 
               'Invoke-AzMLWorkspaceDiagnose', 'Invoke-AzMLWorkspaceNotebook', 
               'New-AzMLWorkspace', 'New-AzMLWorkspaceAksObject', 
               'New-AzMLWorkspaceAmlComputeObject', 
               'New-AzMLWorkspaceBatchDeployment', 
               'New-AzMLWorkspaceBatchEndpoint', 'New-AzMLWorkspaceCodeVersion', 
               'New-AzMLWorkspaceCommandJobObject', 
               'New-AzMLWorkspaceComponentContainer', 
               'New-AzMLWorkspaceComponentVersion', 'New-AzMLWorkspaceCompute', 
               'New-AzMLWorkspaceComputeInstanceObject', 
               'New-AzMLWorkspaceComputeStartStopScheduleObject', 
               'New-AzMLWorkspaceConnection', 
               'New-AzMLWorkspaceCustomModelJobInputObject', 
               'New-AzMLWorkspaceCustomModelJobOutputObject', 
               'New-AzMLWorkspaceDatabricksObject', 
               'New-AzMLWorkspaceDataContainer', 
               'New-AzMLWorkspaceDataFactoryObject', 
               'New-AzMLWorkspaceDataLakeAnalyticsObject', 
               'New-AzMLWorkspaceDatastore', 
               'New-AzMLWorkspaceDatastoreBlobObject', 
               'New-AzMLWorkspaceDatastoreCredentialObject', 
               'New-AzMLWorkspaceDatastoreDataLakeGen1Object', 
               'New-AzMLWorkspaceDatastoreDataLakeGen2Object', 
               'New-AzMLWorkspaceDatastoreFileObject', 
               'New-AzMLWorkspaceDatastoreKeyCredentialObject', 
               'New-AzMLWorkspaceDatastoreNoneCredentialObject', 
               'New-AzMLWorkspaceDatastoreSasCredentialObject', 
               'New-AzMLWorkspaceDatastoreServicePrincipalCredentialObject', 
               'New-AzMLWorkspaceDataVersion', 
               'New-AzMLWorkspaceEnvironmentVersion', 
               'New-AzMLWorkspaceHDInsightObject', 'New-AzMLWorkspaceJob', 
               'New-AzMLWorkspaceJobServiceObject', 
               'New-AzMLWorkspaceKubernetesObject', 
               'New-AzMLWorkspaceLiteralJobInputObject', 
               'New-AzMLWorkspaceMLFlowModelJobInputObject', 
               'New-AzMLWorkspaceMLFlowModelJobOutputObject', 
               'New-AzMLWorkspaceMLTableJobInputObject', 
               'New-AzMLWorkspaceMLTableJobOutputObject', 
               'New-AzMLWorkspaceModelContainer', 'New-AzMLWorkspaceModelVersion', 
               'New-AzMLWorkspaceOnlineDeployment', 
               'New-AzMLWorkspaceOnlineEndpoint', 
               'New-AzMLWorkspaceOnlineEndpointKey', 
               'New-AzMLWorkspacePipelineJobObject', 
               'New-AzMLWorkspaceQuotaPropertiesObject', 
               'New-AzMLWorkspaceSharedPrivateLinkResourceObject', 
               'New-AzMLWorkspaceSweepJobObject', 
               'New-AzMLWorkspaceSynapseSparkObject', 
               'New-AzMLWorkspaceTritonModelJobInputObject', 
               'New-AzMLWorkspaceTritonModelJobOutputObject', 
               'New-AzMLWorkspaceUriFileJobInputObject', 
               'New-AzMLWorkspaceUriFileJobOutputObject', 
               'New-AzMLWorkspaceUriFolderJobInputObject', 
               'New-AzMLWorkspaceUriFolderJobOutputObject', 
               'New-AzMLWorkspaceVirtualMachineObject', 'Remove-AzMLWorkspace', 
               'Remove-AzMLWorkspaceBatchDeployment', 
               'Remove-AzMLWorkspaceBatchEndpoint', 
               'Remove-AzMLWorkspaceCodeVersion', 
               'Remove-AzMLWorkspaceComponentContainer', 
               'Remove-AzMLWorkspaceComponentVersion', 
               'Remove-AzMLWorkspaceCompute', 'Remove-AzMLWorkspaceConnection', 
               'Remove-AzMLWorkspaceDataContainer', 
               'Remove-AzMLWorkspaceDatastore', 'Remove-AzMLWorkspaceDataVersion', 
               'Remove-AzMLWorkspaceEnvironmentContainer', 
               'Remove-AzMLWorkspaceEnvironmentVersion', 'Remove-AzMLWorkspaceJob', 
               'Remove-AzMLWorkspaceModelContainer', 
               'Remove-AzMLWorkspaceModelVersion', 
               'Remove-AzMLWorkspaceOnlineDeployment', 
               'Remove-AzMLWorkspaceOnlineEndpoint', 
               'Restart-AzMLWorkspaceCompute', 'Start-AzMLWorkspaceCompute', 
               'Stop-AzMLWorkspaceCompute', 'Stop-AzMLWorkspaceJob', 
               'Sync-AzMLWorkspaceKey', 'Update-AzMLServiceQuota', 
               'Update-AzMLWorkspace', 'Update-AzMLWorkspaceBatchDeployment', 
               'Update-AzMLWorkspaceBatchEndpoint', 'Update-AzMLWorkspaceCompute', 
               'Update-AzMLWorkspaceOnlineDeployment', 
               'Update-AzMLWorkspaceOnlineEndpoint'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = '*'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ResourceManager','ARM','PSModule','MachineLearningServices'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        # ReleaseNotes = ''

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

