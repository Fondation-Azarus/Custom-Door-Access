# Custom-Door-Access
A plug-in which allows to setup doors/generators permissions.

## Configs
Here's the default configs :
```# Doors' permission :
customDoorPermissionsList:
- doorName: 096
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

Put "`-1`" to include when the player isn't holding anything.
"`replaceDefaultItemsPermissions`" and "`rolesWhichCanBypass`"/"`teamsWhichCanBypass`" are independant.
By the way you can add multiple doors.
