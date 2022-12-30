using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Milionerzy_Kacper_Tkacz
{
    class ReadPlayerData
    {
        private static string playerDataBase = File.ReadAllText(@"D:\programowanie 2021zima\Milionerzy Kacper Tkacz\Milionerzy Kacper Tkacz\PlayerData.json");
        public static ListOfPlayersToJSON listOfPlayers = JsonSerializer.Deserialize<ListOfPlayersToJSON>(playerDataBase);

    }
}
