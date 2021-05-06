using Synapse;
using Synapse.Api.Events.SynapseEventArguments;
using System.Linq;

namespace CustomDoorAccess.Handlers
{
    public class EventHandler
    {
        public EventHandler()
        {
            Server.Get.Events.Player.PlayerGeneratorInteractEvent += OnGenerator;
            Server.Get.Events.Map.DoorInteractEvent += OnDoor;
        }

        private void OnGenerator(PlayerGeneratorInteractEventArgs ev)
        {
            if (ev.Player == null || ev.Generator == null) return;

            if (PluginClass.Configs.RolesWhichCanBypass != null && PluginClass.Configs.RolesWhichCanBypass.Contains(ev.Player.RoleType) || PluginClass.Configs.TeamsWhichCanBypass != null && PluginClass.Configs.TeamsWhichCanBypass.Contains(ev.Player.Team))
                ev.Allow = true;

            else if (PluginClass.Configs.replaceDefaultItemsPermissions)
                if (PluginClass.Configs.AllowedItems != null && (PluginClass.Configs.AllowedItems.Contains(ev.Player.ItemInHand.ID) || (PluginClass.Configs.AllowedItems.Contains(-1) && ev.Player.ItemInHand == null)))
                    ev.Allow = true;
                else
                    ev.Allow = false;

            else if (PluginClass.Configs.AllowedItems != null && (PluginClass.Configs.AllowedItems.Contains(ev.Player.ItemInHand.ID) || (PluginClass.Configs.AllowedItems.Contains(-1) && ev.Player.ItemInHand == null))) ev.Allow = true;
        }

        private void OnDoor(DoorInteractEventArgs ev)
        {
            if (ev.Player == null || ev.Door == null) return;

            PluginClass.CustomDoorPermission cdp = PluginClass.Configs.customDoorPermissionsList.FirstOrDefault(n => n.doorName == ev.Door.Name);
            if (cdp == null) return;



            else if (cdp.RolesWhichCanBypass != null && cdp.RolesWhichCanBypass.Contains(ev.Player.RoleType) || cdp.TeamsWhichCanBypass != null && cdp.TeamsWhichCanBypass.Contains(ev.Player.Team))
                ev.Allow = true;

            else if (cdp.replaceDefaultItemsPermissions)
                if (cdp.AllowedItems != null && (cdp.AllowedItems.Contains(ev.Player.ItemInHand.ID) || (cdp.AllowedItems.Contains(-1) && ev.Player.ItemInHand == null)))
                    ev.Allow = true;
                else
                    ev.Allow = false;

            else if (cdp.AllowedItems != null && cdp.AllowedItems.Contains(ev.Player.ItemInHand.ID)) ev.Allow = true;
        }
    }
}