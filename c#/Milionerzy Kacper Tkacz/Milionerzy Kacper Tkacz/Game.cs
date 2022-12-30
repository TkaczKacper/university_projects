using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Text.Json;

namespace Milionerzy_Kacper_Tkacz
{
    class Game
    {
        public static bool continueGame;
        public static int lives;
        public static int time;
        public static DifficultySettings difficulty;
        private static string questions = File.ReadAllText(@"D:\programowanie 2021zima\Milionerzy Kacper Tkacz\Milionerzy Kacper Tkacz\base.json");
        public static DataBase questionBase = JsonSerializer.Deserialize<DataBase>(questions);

        public static void PlayGame(DifficultySettings difficulty)
        {
            QuizGame.CorrectAnswers = 0;
            Player.Score = 0;
            difficulty.DifficultyLevel();
            difficulty.Time();
            difficulty.Lives();
            QuizGame questions = new QuizGame();
            Array questionNumbers = Lottery.QuestionNumber(10, questionBase.Questions.Count);
            continueGame = true;

            foreach (int i in questionNumbers)
            {
                var counter = new Counter(time);
                counter.Start();
                questions.CurrentQuestion(i, counter);
                counter.Stop();
                if (continueGame == false) break;
                else continue;
            }
            ScoreCalculator.Score();
            WritePlayerData.WritePlayerToJSON();
            Menu.ShowMenu();
        }
        
    }
}
