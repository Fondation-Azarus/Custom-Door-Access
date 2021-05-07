using Synapse.Config;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomDoorAccess.Configs
{
    public class Configs : AbstractConfigSection
    {
        // Doors :
        [Description("Doors' permission :")]
        public List<PluginClass.CustomDoorPermission> customDoorPermissionsList = new List<PluginClass.CustomDoorPermission>
        {
            new PluginClass.CustomDoorPermission { doorType = Synapse.Api.Enum.DoorType.HCZ_096, replaceDefaultItemsPermissions = true, AllowedItems = new List<int> { 0, 14 }, RolesWhichCanBypass = new List<RoleType> { RoleType.NtfScientist }, TeamsWhichCanBypass = new List<Team> { Team.SCP } }
        };

        // Generators :
        [Description("Generators' allowed items :")]
        public List<int> AllowedItems = new List<int> { 2, 19 };

        [Description("Are vanilla generators' permissions replaced ? :")]
        public bool replaceDefaultItemsPermissions = true;

        [Description("Roles that can ByPass generators' permission ('replaceDefaultItemsPermissions' doesn't need to be true for this to work) :")]
        public List<RoleType> RolesWhichCanBypass = new List<RoleType> { RoleType.ClassD };

        [Description("Teams that can ByPass generators' permission ('replaceDefaultItemsPermissions' doesn't need to be true for this to work) :")]
        public List<Team> TeamsWhichCanBypass = new List<Team> { Team.MTF };
    }
}