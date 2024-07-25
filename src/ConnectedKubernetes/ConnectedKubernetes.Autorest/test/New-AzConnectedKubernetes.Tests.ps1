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

Describe 'Invoke-HealthCheckDP' {
    It 'Golden path' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Env access token' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Unhealthy (not 200 response)' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

Describe 'Invoke-RestMethodWithRetries' {
    It 'Golden path' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'URI parameters' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Retry required' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'request failed' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

Describe 'Invoke-RawRequest' {
    It 'Golden path' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'JSON headers' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'String headers' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Authorization provided' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'JSON body' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Unrecognised body type' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'URL parameters' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'No protocol or system name' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Error response' -skip {
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

Describe 'Get-ConfigDpEndpoint' {
    It 'Golden path' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Read ARM metadata' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'No arcConfigEndpoint' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Read default ConfigDPEndoint' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

Describe 'Get-MetaData' {
    It 'Golden path' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Error response' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Exception during REST API.' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

Describe 'Get-ValuesFile' {
    It 'Golden path' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'No values filename' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'No values file' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Starts/ends with quote or double-quote' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

Describe 'Get-HelmValues' {
    It 'Golden path' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Custom release train' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Env access token' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Empty content' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Exception reading content' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

Describe 'Get-ChartPath' {
    It 'Golden Path' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Cannot clean-up existing chart path' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Pre-onboarding' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }   
}

Describe 'Get-HelmChart' {
    It 'Golden path' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Agent older than 1.14.0' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'NewPath' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Has KubeConfig' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Has KubeContext' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Requires retry' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
