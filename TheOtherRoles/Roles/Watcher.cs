using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace TheOtherRoles
{
    [HarmonyPatch]
    public class Watcher : RoleBase<Watcher>
    {
        public static Color color = Palette.Purple;

        public Watcher()
        {
            RoleType = roleId = RoleType.Watcher;
        }

        public override void OnMeetingStart() { }
        public override void OnMeetingEnd() { }
        public override void FixedUpdate() { }
        public override void OnKill(PlayerControl target) { }
        public override void OnDeath(PlayerControl killer = null) { }
        public override void HandleDisconnect(PlayerControl player, DisconnectReasons reason) { }

        public static void MakeButtons(HudManager hm) { }
        public static void SetButtonCooldowns() { }

        public static void clearAndReload()
        {
            players = new List<Watcher>();
        }
    }
}