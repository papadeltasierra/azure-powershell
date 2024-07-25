if(($null -eq $TestName) -or ($TestName -contains 'New-AzConnectedKubernetes'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzConnectedKubernetes.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzConnectedKubernetes' {
    It 'CreateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}


Describe 'Get-SubscriptionIdFromResourceId' {
    It 'Finds the subscription id from a resource id' {
        InModuleScope Az.ConnectedKubernetes.custom {
            $resourceId = '/subscriptions/12345678-9ABC-DEF0-1234-56789ABCDEF0/resourceGroups/rg/providers/Microsoft.Kubernetes/connectedClusters/cluster'
            $subscriptionId = Get-SubscriptionIdFromResourceId -ResourceId $resourceId
            $subscriptionId | Should -Be '12345678-9ABC-DEF0-1234-56789ABCDEF0'
        }
    }
    It 'Finds no subscription id in a resource id' {
        InModuleScope Az.ConnectedKubernetes.custom {
            $resourceId = '/not-a-subscription/12345678-9ABC-DEF0-1234-56789ABCDEF0/resourceGroups/rg/providers/Microsoft.Kubernetes/connectedClusters/cluster'
            $subscriptionId = Get-SubscriptionIdFromResourceId -ResourceId $resourceId
            $subscriptionId | Should -Be $null
        }
    }
}