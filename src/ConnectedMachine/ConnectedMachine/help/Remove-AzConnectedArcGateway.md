---
external help file: Az.ConnectedArc Gateway-help.xml
Module Name: Az.ConnectedArc Gateway
online version: https://learn.microsoft.com/powershell/module/az.connectedarc gateway/remove-azconnectedarcgateway
schema: 2.0.0
---

# Remove-AzConnectedArc Gateway

## SYNOPSIS
The operation to delete an Arc Gateway.

## SYNTAX

### Delete (Default)
```
Remove-AzConnectedArcGateway -Name <String> -ResourceGroupName <String> [-SubscriptionId <String>]
 [-DefaultProfile <PSObject>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### DeleteViaIdentity
```
Remove-AzConnectedArcGateway -InputObject <IConnectedArc GatewayIdentity> [-DefaultProfile <PSObject>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The operation to delete an Arc Gateway.

## EXAMPLES

### Example 1: Remove a connected arc gateway
```powershell
Remove-AzConnectedArcGateway -Name myArc Gateway -ResourceGroupName myRG
```

Deletes the connected arc gateway.

### Example 2: Remove connected arc gateways via the pipeline
```powershell
Get-AzConnectedArcGateway -ResourceGroupName contoso-connected-arc gateways | Remove-AzConnectedArcGateway
```

Removes all arc gateways in the `contoso-connected-arc gateways` resource group.

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

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ConnectedArc Gateway.Models.IConnectedArc GatewayIdentity
Parameter Sets: DeleteViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the Arc Gateway.

```yaml
Type: System.String
Parameter Sets: Delete
Aliases: Arc GatewayName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

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

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Delete
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
Parameter Sets: Delete
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

## INPUTS

!!PDS: Define this somewhere.
### Microsoft.Azure.PowerShell.Cmdlets.ConnectedArc Gateway.Models.IConnectedArcGatewayIdentity

## OUTPUTS

### System.Boolean

## NOTES

## RELATED LINKS
