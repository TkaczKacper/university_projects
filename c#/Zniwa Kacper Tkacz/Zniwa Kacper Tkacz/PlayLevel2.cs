using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zniwa_Kacper_Tkacz
{
    class PlayLevel2
    {
        //second level initialization
        public void PlayLevel2Game()
        {
            Console.SetWindowSize(60, 23);
            Console.CursorVisible = false;
            DateTime timeLast = DateTime.Now;

            //Jezeli ciezko Ci jest przejsc labirynt to zmien wartosc na wieksza
            int speed = 55;

            Console.Clear();
            Tractor tractor = new Tractor();
            SellPoint sellPoint = new SellPoint();
            bool exit = false;

            while (!exit)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo inputKey = Console.ReadKey();
                    //control keys 
                    switch (inputKey.Key)
                    {
                        case ConsoleKey.Escape:
                            MainMenu.ShowMenu();
                            exit = true;
                            break;
                        case ConsoleKey.LeftArrow:
                            tractor.Direction = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            tractor.Direction = Direction.Right;
                            break;
                        case ConsoleKey.UpArrow:
                            tractor.Direction = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            tractor.Direction = Direction.Down;
                            break;
                    }
                }
                //movement function
                if ((DateTime.Now - timeLast).TotalMilliseconds >= speed)
                {
                    //tractor crash checker
                    if (tractor.Level2BorderHitted) GameOver();
                    //tractor reached sell point checker
                    if (sellPoint.CurrentSellPoint.X == tractor.TractorCoordinate.X && sellPoint.CurrentSellPoint.Y == tractor.TractorCoordinate.Y) exit = true;
                    
                    tractor.Move();
                    timeLast = DateTime.Now;
                }
            }
        }
        void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Rozsypales cale plony, nic nie zarabiasz.");
            Console.WriteLine("");
            Thread.Sleep(500);
            Console.WriteLine("Aby wrocic do menu wcisnij dowolny klawisz.");
            Console.ReadKey();
            MainMenu.ShowMenu();
        }
    }
}
