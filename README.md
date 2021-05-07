# Custom-Door-Access
A plug-in which allows to setup doors/generators permissions.

## Configs
Here's the default configs :
```# Doors' permission :
customDoorPermissionsList:
- doorType: HCZ_096
  replaceDefaultItemsPermissions: true
  allowedItems:
  - 0
  - 14
  rolesWhichCanBypass:
  - NtfScientist
  teamsWhichCanBypass:
  - SCP
# Generators' allowed items :
allowedItems:
- 2
- 19
# Are vanilla generators' permissions replaced ? :
replaceDefaultItemsPermissions: true
# Roles that can ByPass generators' permission ('replaceDefaultItemsPermissions' doesn't need to be true for this to work) :
rolesWhichCanBypass:
- ClassD
# Teams that can ByPass generators' permission ('replaceDefaultItemsPermissions' doesn't need to be true for this to work) :
teamsWhichCanBypass:
- MTF
```

Put "`-1`" to include every items.
"`replaceDefaultItemsPermissions`" and "`rolesWhichCanBypass`"/"`teamsWhichCanBypass`" are independant.
You can find all the items' IDs/DoorTypes/RoleTypes/Teams [here](https://docs.synapsesl.xyz/resources).
You can also put multiple RoleTypes/Teams.
By the way you can add multiple doors.

## Installation
1. [Install Synapse](https://docs.synapsesl.xyz/setup/setup).
2. Place the `.dll` file that you can download [here]() in your plug-in directory.
3. Restart/Start your server.
