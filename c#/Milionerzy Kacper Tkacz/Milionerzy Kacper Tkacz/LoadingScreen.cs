using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy_Kacper_Tkacz
{
    class LoadingScreen : Game
    {
        public static void EntryLoading()
        {
            Console.Write("Podaj nazwe gracza: ");
            string name = Console.ReadLine();
            Player.Name = name;

            bool ageChecker = true;
            while (ageChecker == true)
            {
                Console.Write("\nPodaj swoj wiek: ");
                var inputAge = Console.ReadLine();
                if (int.TryParse(inputAge, out int age))
                {

                    if (age < 18) Console.WriteLine("Musisz byc pelnoletni aby zagrac.");
                    else if (age >= 100) Console.WriteLine("Jestes za stary aby zagrac");
                    else if (age >= 18 || age < 100)
                    {
                        Player.Age = age;
                        ageChecker = false;
                    }
                }
                else
                {
                    Console.WriteLine("To raczej nie jest liczba -_-");
                }
            }
        }
        public static void Loading()
        {
            bool difficultyChecker = true;
            while (difficultyChecker == true)
            {
                Console.Clear();
                LoadingScreenText();

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {

                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        difficulty = new Easy();
                        difficultyChecker = false;
                        Console.Clear();
                        break;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        difficulty = new Medium();
                        difficultyChecker = false;
                        Console.Clear();
                        break;

                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        difficulty = new Hard();
                        difficultyChecker = false;
                        Console.Clear();
                        break;
                }
            }
            
            PlayGame(difficulty);
        }
        static void LoadingScreenText()
        {
            Console.WriteLine("\n Wybierz poziom trudnosci: ");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t 1. Latwy.\n");
            Console.WriteLine("\t 2. Sredni.\n");
            Console.WriteLine("\t 3. Trudny.\n");
        }
    }
}
