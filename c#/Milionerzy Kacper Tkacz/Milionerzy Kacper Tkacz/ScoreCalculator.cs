using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy_Kacper_Tkacz
{
    class ScoreCalculator
    {
        public static int DifficultyScore;

        private static int Calculate()
        {
            return ((DifficultyScore + Game.lives) * QuizGame.CorrectAnswers); 
        }

        public static void Score()
        {
            Player.Score = Calculate();
        }
    }
}
