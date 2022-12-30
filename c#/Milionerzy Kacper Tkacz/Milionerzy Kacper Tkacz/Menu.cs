using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy_Kacper_Tkacz
{
    class Menu
    {
        public static void ShowMenu()
        {
            while (true)
            {
                Console.CursorVisible = false;
                Console.Clear();
                MenuText();

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    //Menu 1
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Console.Clear();
                        LoadingScreen.Loading();
                        Console.ReadKey();
                        ShowMenu();
                        break;
                    //Menu 2
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        HowToPlay();
                        break;
                    //Menu 3
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Ranking.RankingToText();
                        break;
                    //Menu 4
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.Escape:
                    case ConsoleKey.D4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void MenuText() 
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t 1. Rozpocznij gre.\n");
            Console.WriteLine("\t 2. Jak grac?\n");
            Console.WriteLine("\t 3. Ranking graczy.\n");
            Console.WriteLine("\t 4. Zamknij gre.\n");
        }
        static void HowToPlay()
        {
            Console.Clear();

            Console.WriteLine("\n");
            Console.WriteLine(" Gra sklada sie z 10 losowych pytan pobieranych z ogolnej bazy wszystkich pytan. " +
                "\n W zaleznosci od wybranego poziomu trudnosci, musimy zmiescic sie w okreslonym czasie. " +
                "\n Po odpowiedzeniu poprawnie na pytanie dostajemy okreslona ilosc $$. " +
                "\n Jednak nie kazde pytanie gwarantuje zdobycia danej kwoty. " +
                "\n\n\t\t Zycze powodzenia B) ");

            Console.WriteLine("\n\n Aby wrocic do menu wcisnij dowolny klawisz... ");
            Console.ReadKey();
        }
    }
}
