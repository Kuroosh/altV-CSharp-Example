using System;
using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Resources.Chat.Api;

namespace CykaBlyat.Events
{
    public class ScriptEvents
    {
        [ScriptEvent(ScriptEventType.PlayerConnect)]
        public static void OnPlayerConnect(IPlayer player, string reason)
        {
            try
            {
                Globals.Functions.SpawnPlayerOnSpawnpoint(player);
                player.SendChatMessage("Blyat Yebani rot .. sdarova cyka " + player.Name);
                Globals.Functions.SendChatMessageToAll("Blyat Cyka ... " + player.Name + " joined eto Dolbajob Server.");
            }
            catch(Exception ex){ Core.Debug.CatchException(ex); }
        }
        
        [ScriptEvent(ScriptEventType.PlayerDisconnect)]
        public static void OnPlayerDisconnect(IPlayer player, string reason)
        {
            try
            {
                Globals.Functions.SendChatMessageToAll("PISDEZ! " + player.Name + " left this fucking server yebani rot!");
            }
            catch(Exception ex){ Core.Debug.CatchException(ex); }
        }

        [ScriptEvent(ScriptEventType.PlayerEnterVehicle)]
        public static void OnPlayerEnterVehicle(IVehicle veh, IPlayer player, byte seat)
        {
            try
            {
                player.SendChatMessage("oyyy zaebis bratan.. davai davai go ogrableni with your : " + (VehicleModel)veh.Model + " schlucha!");
            }
            catch(Exception ex){ Core.Debug.CatchException(ex); }
        }
        
        [ScriptEvent(ScriptEventType.PlayerLeaveVehicle)]
        public static void OnPlayerLeaveVehicle(IVehicle veh, IPlayer player, byte seat)
        {
            try
            {
                player.SendChatMessage("Pochemu ty dolbajob leave your fucking vehicle ?! i will put you in gulag dolbajob!");
            }
            catch(Exception ex){ Core.Debug.CatchException(ex); }
        }
    }
}