using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zniwa_Kacper_Tkacz
{
    class Game
    {
        //game initialization
        static public void PlayGame()
        {
            Console.SetWindowSize(60, 28);
            Console.Clear();
            DateTime timeLast = DateTime.Now;
            int speed = 100;
            Harvester harvester = new Harvester();
            Border border = new Border();
            Wheat wheat = new Wheat();
            PlayLevel2 playLevel2 = new PlayLevel2();
            int lives = 5;
            int wheatHarvested = 0;
            int timeElapsedInms = 0;
            bool exit = false;
            int toHarvest = wheat.WheatXCoord.Count;

            while (!exit)
            {
                //movement function
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo inputKey = Console.ReadKey();

                    switch (inputKey.Key)
                    {
                        case ConsoleKey.Escape:
                            MainMenu.ShowMenu();
                            exit = true;
                            break;
                        case ConsoleKey.LeftArrow:
                            harvester.Direction = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            harvester.Direction = Direction.Right;
                            break;
                        case ConsoleKey.UpArrow:
                            harvester.Direction = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            harvester.Direction = Direction.Down;
                            break;
                    }
                }
                
                if((DateTime.Now - timeLast).TotalMilliseconds >= speed)
                {
                    timeElapsedInms += 100;
                    //harvester crash checker
                    if (harvester.BorderHitted)
                    {
                        harvester = new Harvester();
                        harvester.Move();
                        timeLast = DateTime.Now;
                        lives--;
                    }
                    //wheat harvested checker
                    for (int i = 0; i < wheat.WheatXCoord.Count; i++)
                    {
                        if (wheat.WheatXCoord[i].Equals(harvester.HarvesterCoordinate.X) && wheat.WheatYCoord[i].Equals(harvester.HarvesterCoordinate.Y))
                        {
                            wheat.WheatYCoord.RemoveAt(i);
                            wheat.WheatXCoord.RemoveAt(i);
                            wheatHarvested++;
                            toHarvest--;
                        }
                    }
                    if (toHarvest == 0)
                    {
                        playLevel2.PlayLevel2Game();
                        exit = true;
                    }
                    //game over checker
                    if (lives == 0) TooMuchDamage();
                    //move forward
                    else
                    {
                        harvester.Move();
                        timeLast = DateTime.Now;
                    }
                }
            }
            Console.Clear();
            GameCompleted();

            void TooMuchDamage()
            {
                Console.SetWindowSize(80, 28);
                Console.Clear();
                Console.WriteLine("             _        ______     _   _    ____    ____     __   __  _____   ");
                Console.WriteLine("     /\\     | |      |  ____|   | \\ | |  / __ \\  |  _ \\    \\ \\ / / |  __ \\  ");
                Console.WriteLine("    /  \\    | |      | |__      |  \\| | | |  | | | |_) |    \\ V /  | |  | | ");
                Console.WriteLine("   / /\\ \\   | |      |  __|     | . ` | | |  | | |  _ <      > <   | |  | | ");
                Console.WriteLine("  / ____ \\  | |____  | |____    | |\\  | | |__| | | |_) |    / . \\  | |__| | ");
                Console.WriteLine(" /_/    \\_\\ |______| |______|   |_| \\_|  \\____/  |____/    /_/ \\_\\ |_____/  ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("Przez uderzenia w plot zepsules kombajn.");
                Console.WriteLine(wheat.WheatYCoord.Count);
                Thread.Sleep(1000);
                Console.WriteLine("Straciles mozliwosc zarobku, lecz wciaz mozesz zagrac ponownie.");
                Thread.Sleep(1000);
                if (wheatHarvested == 0) Console.WriteLine("Udalo Ci sie zebrac " + wheatHarvested + " pol zboza.");
                if (wheatHarvested == 1) Console.WriteLine("Udalo Ci sie zebrac " + wheatHarvested + " pole zboza.");
                if (wheatHarvested == 2 || wheatHarvested == 3 || wheatHarvested == 4) Console.WriteLine("Udalo Ci sie zebrac " + wheatHarvested + " pola zboza.");
                if (wheatHarvested >= 5) Console.WriteLine("Udalo Ci sie zebrac " + wheatHarvested + " pol zboza.");
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.WriteLine("Aby kontynuowac wcisnij dowolny klawisz.");
                Console.ReadKey();
                MainMenu.ShowMenu();
            }
           
            void GameCompleted()
            {
                int money = (lives * wheatHarvested) - (timeElapsedInms / 1500);
                if (money < 0) money = 0;

                Console.SetWindowSize(110, 20);
                Console.CursorVisible = false;

                Console.WriteLine(" .d8888b.  8888888b.         d8888 88888888888 888     888 888             d8888  .d8888b. 888888 8888888888 ");
                Console.WriteLine("d88P  Y88b 888   Y88b       d88888     888     888     888 888            d88888 d88P  Y88b   88b 888        ");
                Console.WriteLine("888    888 888    888      d88P888     888     888     888 888           d88P888 888    888   888 888        ");
                Console.WriteLine("888        888   d88P     d88P 888     888     888     888 888          d88P 888 888          888 8888888    ");
                Console.WriteLine("888  88888 8888888P      d88P  888     888     888     888 888         d88P  888 888          888 888        ");
                Console.WriteLine("888    888 888 T88b     d88P   888     888     888     888 888        d88P   888 888    888   888 888        ");
                Console.WriteLine("Y88b  d88P 888  T88b   d8888888888     888     Y88b. .d88P 888       d8888888888 Y88b  d88P   88P 888        ");
                Console.WriteLine("  Y8888P88 888   T88b d88P     888     888       Y88888P   88888888 d88P     888   Y8888P     888 8888888888 ");
                Console.WriteLine("                                                                                            .d88P            ");
                Console.WriteLine("                                                                                          .d88P              ");
                Console.WriteLine("                                                                                         888P                ");
                Console.WriteLine("");

                Console.WriteLine("Udalo Ci sie przetrwac zniwa.");
                Console.WriteLine("Za zebrane zboze zarobiles $" + money);
                Console.WriteLine("");
                Console.WriteLine("Mam nadzieje ze sie podobalo, milego dnia zycze!");
                Console.WriteLine("");
                Console.WriteLine("Aby wrocic do menu glownego wcisnij dowolny przycisk.");
            }
        }
    }
}
