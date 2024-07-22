# Custom Commands - Why?
## Overview
There are two main reasons why we use custom cmdlet definitions:

1. The cmdlets do not just issue ARM REST API calls, rather then also directly issue `helm` requests towards the Kubernetes cluster
2. In a perfect world, updating configuration for an active connected Kubernetes cluster would use an ARM PATCH REST API call but it does not.

## ARM and helm
The Connected Kubernetes cmdlets send ARM REST API request in the expected manner but also issue 'helm' configuration requests directly to the cluster.  As far as the interfaces and structure of the cmdlets goes, this results in the following:

- The cmdlets take optional parameters that are not part of the ARM REST API and these cause `helm` configuration changes
- The structure of the custom cmdlets has to take account of **both** ARM and `helm` operations before reporting status back to the caller.

## UPDATE/GET/PUT not UPDATE/PATCH or SET/GET/PUT
Updates to a running Kubernetes cluster are made using the following ARM REST API sequence:

- Perform an ARM GET
- Merge in the new configuration
- Perform a (re)PUT.

In standard Powershell cmdlet processing, this should be using a `Get`/`Set` sequence but an Update cmdlet has already been published and back-compatibility requires that we maintain this structure.

> QUESTION: Should we actually keep `Update` unchanged and actually use `Get`/`Set`?