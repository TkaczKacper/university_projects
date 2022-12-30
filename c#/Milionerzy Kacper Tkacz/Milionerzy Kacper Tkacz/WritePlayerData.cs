using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Milionerzy_Kacper_Tkacz
{
    class WritePlayerData : ReadPlayerData
    {
        public static void WritePlayerToJSON()
        {
            bool newEntry = true;
            for (int i = 0; i < listOfPlayers.PlayerToJSON.Count; i++)
            {
                if (listOfPlayers.PlayerToJSON[i].PlayerName.Contains(Player.Name) && listOfPlayers.PlayerToJSON[i].Age == Player.Age)
                {
                    int scoreUpdate = listOfPlayers.PlayerToJSON[i].Score + Player.Score;
                    listOfPlayers.PlayerToJSON.RemoveAt(i);
                    PlayerToJSON playerToAdd = new PlayerToJSON();
                    playerToAdd.PlayerName = Player.Name;
                    playerToAdd.Age = Player.Age;
                    playerToAdd.Score = scoreUpdate;
                    listOfPlayers.PlayerToJSON.Add(playerToAdd);
                    string fileName = @"D:\programowanie 2021zima\Milionerzy Kacper Tkacz\Milionerzy Kacper Tkacz\PlayerData.json";
                    string jsonString = JsonSerializer.Serialize(listOfPlayers);
                    File.WriteAllText(fileName, jsonString);
                    newEntry = false;
                }
            }
            if(newEntry == true)
            {
                PlayerToJSON playerToAdd = new PlayerToJSON();
                playerToAdd.PlayerName = Player.Name;
                playerToAdd.Age = Player.Age;
                playerToAdd.Score = Player.Score;

                listOfPlayers.PlayerToJSON.Add(playerToAdd);
                string fileName = @"D:\programowanie 2021zima\Milionerzy Kacper Tkacz\Milionerzy Kacper Tkacz\PlayerData.json";
                string jsonString = JsonSerializer.Serialize(listOfPlayers);
                File.WriteAllText(fileName, jsonString);
            }
        }
    }
}
