if(($null -eq $TestName) -or ($TestName -contains 'Start-AzWebAppTriggeredWebJob'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Start-AzWebAppTriggeredWebJob.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Start-AzWebAppTriggeredWebJob' {
    It 'Start' {
        { Start-AzWebAppTriggeredWebJob -ResourceGroupName $env.webJobResourceGroup -AppName $env.webApp -Name $env.triggeredJob01 } | Should -Not -Throw
    }

    It 'StartViaIdentity' {
        $job = Get-AzWebAppTriggeredWebJob -ResourceGroupName $env.webJobResourceGroup -AppName $env.webApp -Name $env.triggeredJob02
        { Start-AzWebAppTriggeredWebJob -InputObject $job.Id } | Should -Not -Throw
    }
}
