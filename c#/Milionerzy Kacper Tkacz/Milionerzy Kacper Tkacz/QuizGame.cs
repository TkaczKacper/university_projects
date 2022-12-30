using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Milionerzy_Kacper_Tkacz
{
    class QuizGame : Game
    {

        private static string answer;
        public static int CorrectAnswers;

        public void QuestionToString(int i)
        {
            MoneyEngine.EngineMoney();
            Console.WriteLine($" Pytanie za: ${Wallet.PossibleWin}");
            Console.WriteLine($" Gwarantowana wygrana to: ${Wallet.CurrentWin}");
            Console.WriteLine(" Pozostaly czas na odpowiedz: ");
            Console.WriteLine($" Pozostale zycia: {lives} \n\n");
            Console.SetCursorPosition(3, 6);

            Console.WriteLine(questionBase.Questions[i].Contents);
            Console.WriteLine();
            Console.WriteLine("\t" + questionBase.Questions[i].AnsA);
            Console.WriteLine("\t" + questionBase.Questions[i].AnsB);
            Console.WriteLine("\t" + questionBase.Questions[i].AnsC);
            Console.WriteLine("\t" + questionBase.Questions[i].AnsD);

            Console.SetCursorPosition(3, 14);
            Console.WriteLine("Twoja odpowiedz: ");
        }
        public void CurrentQuestion(int i, Counter counter)
        {
            QuestionToString(i);
            InputKey();
            if (counter.count < 0)
            {
                counter.Stop();
                EndingScreen.TimesUpEnding();
                continueGame = false;
            }
            else if (questionBase.Questions[i].CorrectAns != answer)
            {
                lives--;
                if(lives > 0)
                {
                    counter.Stop();
                    CorrectAnswers++;
                    Console.Clear();
                }
                else
                {
                    counter.Stop();
                    continueGame = false;
                    MoneyEngine.EngineMoney();
                    EndingScreen.Ending();
                    Console.ReadKey();
                }
                //ScoreCalculator.Score();
            }
            else
            {
                counter.Stop();
                CorrectAnswers++;
                //ScoreCalculator.Score();
                if (CorrectAnswers > 9)
                {
                    MoneyEngine.EngineMoney();
                    EndingScreen.BestEnding();
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
        static void InputKey()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                    case ConsoleKey.A:
                        answer = "A";
                        break;

                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                    case ConsoleKey.B:
                        answer = "B";
                        break;

                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                    case ConsoleKey.C:
                        answer = "C";
                        break;

                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                    case ConsoleKey.D:
                        answer = "D";
                        break;
                    default:
                        InputKey();
                        break;
                }
                break;
            }
        }
    }
}
