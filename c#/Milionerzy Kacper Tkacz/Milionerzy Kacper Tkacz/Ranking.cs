using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Milionerzy_Kacper_Tkacz
{
    class Ranking : ReadPlayerData
    {
        static void Sorting()
        {
            int breaker = 0;
            var sortedJSON = from Score in listOfPlayers.PlayerToJSON orderby Score.Score descending select Score;

            foreach(var Score in sortedJSON)
            {
                breaker++;
                Console.WriteLine("\t\t\t Miejsce " + breaker);
                Console.WriteLine($" Gracz o nazwie: {Score.PlayerName}");
                Console.WriteLine($" W wieku {Score.Age} lat.");
                Console.WriteLine($" Laczny wynik: {Score.Score}");
                Console.WriteLine("\n\n");
                if (breaker == 3) break;
            }

        }

        public static void RankingToText()
        {
            Console.Clear();
            Console.WriteLine("\t\t Top 3 graczy to: \n\n\n");
            Sorting();
            Console.WriteLine("\n\n\n Wcisnij dowolny klawisz aby wrocic do menu... ");    
            Console.ReadKey();
        }
    }
}
