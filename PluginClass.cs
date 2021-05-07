using Synapse.Api.Enum;
using Synapse.Api.Plugin;
using System.Collections.Generic;

namespace CustomDoorAccess
{
    [PluginInformation(
        Name = "Custom Door Access ",
        Author = "Bonjemus",
        Description = "A plug-in which allows to setup doors/generators permissions.",
        LoadPriority = 1,
        SynapseMajor = SynapseController.SynapseMajor,
        SynapseMinor = SynapseController.SynapseMinor,
        SynapsePatch = SynapseController.SynapsePatch,
        Version = "1.1.0"
        )]
    public class PluginClass : AbstractPlugin
    {
        [Config(section = "Custom Door Access")]
        public static Configs.Configs Configs;

        public class CustomDoorPermission
        {
            public DoorType doorType;
            public bool replaceDefaultItemsPermissions;
            public List<int> AllowedItems;
            public List<RoleType> RolesWhichCanBypass;
            public List<Team> TeamsWhichCanBypass;
        }

        public override void Load()
        {
            new Handlers.EventHandler();
        }
    }
}
