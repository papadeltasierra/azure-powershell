---
external help file: Az.ConnectedArcGateway-help.xml
Module Name: Az.ConnectedArcGateway
online version: https://learn.microsoft.com/powershell/module/az.connectedarcgateway/get-azconnectedarcgateway
schema: 2.0.0
---

# Get-AzConnectedArcGateway

## SYNOPSIS
Retrieves information about the model view or the instance view of a Arc Gateway.

## SYNTAX

### List1 (Default)
```
Get-AzConnectedArcGateway [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### Get
```
Get-AzConnectedArcGateway -Name <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-Expand <String>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List
```
Get-AzConnectedArcGateway -ResourceGroupName <String> [-SubscriptionId <String[]>] [-Expand <String>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Retrieves information about the model view or the instance view of a Arc Gateway.

## EXAMPLES

### Example 1: List all Arc Gateways in a subscription
```powershell
Get-AzConnectedArcGateway -SubscriptionId ********-****-****-****-**********
```

```output
Name           Location OSName   Status     ProvisioningState
----           -------- ------   ------     -----------------
winwestus2_1   westus2  windows  Connected  Succeeded
linwestus2_1   westus2  linux    Connected  Succeeded
winwestus2_2   westus2  windows  Connected  Succeeded
winwestus2_3   westus2  windows  Connected  Succeeded
```

Lists all Arc Gateways in a subscription.
If subscription isn't specified, it will use the subscription from your current Azure PowerShell context.

### Example 2: List all Arc Gateways in a resource group
```powershell
Get-AzConnectedArcGateway -ResourceGroupName contoso-arc-gateways
```

```output
Name           Location OSName   Status     ProvisioningState
----           -------- ------   ------     -----------------
winwestus2_2   westus2  windows  Connected  Succeeded
winwestus2_3   westus2  windows  Connected  Succeeded
```

List all Arc Gateways in a resource group.

### Example 3: Get a Arc Gateway in a resource group by name
```powershell
Get-AzConnectedArcGateway -ResourceGroupName contoso-arc-gateways -Name winwestus2_1
```

```output
Name           Location OSName   Status     ProvisioningState
----           -------- ------   ------     -----------------
winwestus2_1   westus2  windows  Connected  Succeeded
```

Get a Arc Gateway in a resource group by name.

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Expand
The expand expression to apply on the operation.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the Arc Gateway.

```yaml
Type: System.String
Parameter Sets: Get
Aliases: MachineName

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
Parameter Sets: Get, List
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
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ConnectedArcGateway.Models.IArcGateway

## NOTES

## RELATED LINKS
