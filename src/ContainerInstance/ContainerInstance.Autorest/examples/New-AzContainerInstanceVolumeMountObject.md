### Example 1: Specify a volume mount available to a container instance
```powershell
New-AzContainerInstanceVolumeMountObject -Name "mnt" -MountPath "/mnt/azfile" -ReadOnly $true
```

```output
MountPath   Name ReadOnly
---------   ---- --------
/mnt/azfile mnt  True
```

This command specifies a volume mount available to a container instance


