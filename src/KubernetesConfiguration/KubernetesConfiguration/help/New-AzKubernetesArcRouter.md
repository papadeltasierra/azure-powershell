---
external help file: Az.KubernetesConfiguration-help.xml
Module Name: Az.KubernetesConfiguration
online version: https://learn.microsoft.com/powershell/module/az.kubernetesconfiguration/new-azkubernetesarcrouter
schema: 2.0.0
---

# New-AzKubernetesArcRoute

## SYNOPSIS
Create a new Kubernetes Cluster Arc Route.

## SYNTAX

```
New-AzKubernetesArcRoute -ClusterName <String> -Name <String> -ResourceGroupName <String>
[-Gateway <String>] [-SubscriptionId <String>] [-ConfigurationSetting <String>] [-ProtectedConfigurationSettings <String>] [-AsJob] [-NoWait] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create a new Kubernetes Cluster Arc Route.

## EXAMPLES

### Example 1: Create a new Kubernetes Cluster Arc Route.
```powershell
New-AzKubernetesArcRouter -ClusterName azpstest_cluster_arc -Name azpstest-router -ResourceGroupName azps_test_group -Gateway ?????
```

```output
Name              ProvisioningState
----              -----------------
azpstest-router   Succeeded
```

Create a new Kubernetes Cluster Arc Router.

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConfigurationSettings
Confirguration settings to be added to the Kubernetes Arc Arc Route.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClusterName
The name of the kubernetes cluster.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of the Arc Route.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: Arc ClusterName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProtectedConfigurationSettings
Protected Configuration settings to be added to the Kubernetes Arc Arc Route.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

!!PDS: When we implement Update we definitely want to support object input (see CmdLet best practise)

## INPUTS

## OUTPUTS

!!PDS: We need to define the arc route object that is output here and somehow the link below will do that but the API version and object is wrong!

### Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20221101.IArc Router

## NOTES

ALIASES

New-AzK8sArcRoute

## RELATED LINKS
