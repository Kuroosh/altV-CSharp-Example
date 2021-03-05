using System;
using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Resources.Chat.Api;

namespace CykaBlyat.Commands
{
    public class FreeroamCommands
    {

        [Command("createvehicle")]
        public static void CreatePlayerVehicle(IPlayer player, string VehicleName)
        {
            try
            {
                IVehicle vehicle = Alt.CreateVehicle(Alt.Hash(VehicleName), player.Position, player.Rotation);
                if (vehicle is null || !vehicle.Exists)
                    player.SendChatMessage("Dolbajob... your car doesn't exists : " + VehicleName);
                else
                    player.SendChatMessage("Your car is now ready... go and escape before you go to gulag!");
                
            }
            catch (Exception ex)
            {
                Core.Debug.CatchException(ex);
            }
        }
        
    }
}