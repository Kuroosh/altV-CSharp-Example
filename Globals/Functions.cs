using System;
using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Resources.Chat.Api;

namespace CykaBlyat.Globals
{
    public static class Functions
    {
        public static void SendChatMessageToAll(string text)
        {
            try
            {
                foreach (IPlayer otherPlayers in Alt.GetAllPlayers())
                    otherPlayers?.SendChatMessage(text);
            }
            catch(Exception ex){ Core.Debug.CatchException(ex); }
        }

        public static void SpawnPlayerOnSpawnpoint(IPlayer player)
        {
            try
            {
                if((PedModel)player.Model != PedModel.FreemodeMale01) 
                    player.Model = (uint)PedModel.FreemodeMale01;
                player.Position = Constants.Spawnpoints[new Random().Next(0, Constants.Spawnpoints.Count)];
            }
            catch(Exception ex){ Core.Debug.CatchException(ex); }
        }
    }
}